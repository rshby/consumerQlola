// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using consumerQlola.Helper;
using consumerQlola.Models.DTO;
using consumerQlola.Queue;
using GraphQL;
using GraphQL.Client.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;

Console.WriteLine("Hello, World!");

IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true).AddEnvironmentVariables().Build();

// connect to rabbitMQ
var rbtMQ = new ConnectRabbitMQ();
var (conn, err) = rbtMQ.ConnectToRabbitMQ();
if (err != null)
{
    System.Environment.Exit(1);
}

// declare channel
var channel = conn.CreateModel();

// declare queue
var testQlola = channel.QueueDeclare("testQlola", true, false, false, null);

// declare consumer
var consumer = new EventingBasicConsumer(channel);

// declare GraphqlClient
GraphQLHttpClientHandler graphqlClientHndler = new GraphQLHttpClientHandler();

consumer.Received += async (model, ea) =>
{
        try
        {
            GraphQLHttpClient _graphQLHttpClient = graphqlClientHndler.GetGraphQlApiClient();
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);

            // get request object
            var req = JsonConvert.DeserializeObject<OverbookingRequest>(message);

            // create query
            string joined = "statusCode statusDesc accountDebit nameDebit statusDebit accountCredit nameCredit statusCredit amountTrx remark dateTrx journalSeq trrefn currencyDebit currencyCredit tellerId amountDebited amountCredited tranType channelId amountFee recordStatus uniqueId";
            StringBuilder _strQuery = new StringBuilder();
            _strQuery.AppendLine("mutation AbcsOvbInternal ($tranType: String, $channelId: String!, $accountDebit: String!, $currencyDebit: String!, $accountCredit: String!, $currencyCredit: String!, $amountTrx: Float!, $amountFee: Float, $accountFee: String, $remark: String, $tellerId: String, $uniqueId: String) {");
            _strQuery.AppendLine("abcsOvbInternal(");
            _strQuery.AppendLine("request: { tranType: $tranType, channelId: $channelId, accountDebit: $accountDebit, currencyDebit: $currencyDebit, accountCredit: $accountCredit, currencyCredit: $currencyCredit, amountTrx: $amountTrx, amountFee: $amountFee, accountFee: $accountFee, remark: $remark, tellerId: $tellerId, uniqueId: $uniqueId }");
            _strQuery.AppendLine(") {");
            _strQuery.AppendLine(joined);
            _strQuery.AppendLine("}");
            _strQuery.AppendLine("}");

            // create request graphQL
            var query = new GraphQLRequest(query: _strQuery.ToString(), variables: new OverbookingRequest()
            {
                TranType = req.TranType,
                ChannelId = req.ChannelId,
                AccountDebit = req.AccountDebit,
                CurrencyDebit = req.CurrencyDebit,
                AccountCredit = req.AccountCredit,
                CurrencyCredit = req.CurrencyCredit,
                AmountTrx = req.AmountTrx,
                AmountFee = req.AmountFee,
                Remark = req.Remark,
                TellerId = req.TellerId,
                UniqueId = req.UniqueId,
            }, null);

            // proses hit
            var request = new GraphQLRequest(query);

            // receive response
            GraphQLResponse<OverbookingResult>? response = new GraphQLResponse<OverbookingResult>();

            response = await _graphQLHttpClient.SendQueryAsync<OverbookingResult>(request);

            // ambil responsenya

            Console.WriteLine("result data");
            Console.WriteLine(JsonConvert.SerializeObject(response.Data.AbcsOvbInternal));
            Console.WriteLine();

            // get errors : jika null -> tidak ada error
            Console.WriteLine("errors");
            Console.WriteLine(JsonConvert.SerializeObject(response.Errors));
            Console.WriteLine();
            Console.WriteLine("success send");
        }
        catch (Exception err)
        {
            Console.WriteLine($"error : {err}");
        }
};

channel.BasicConsume(testQlola.QueueName, true, "",false, false, null, consumer);

Console.WriteLine("waiting message...");
Console.ReadLine();