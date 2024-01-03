// See https://aka.ms/new-console-template for more information

using System.Text;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using publisher.Models.DTO;
using publisher.Queue;

Console.WriteLine("Hello, World!");

// connect to rabbitMQ
ConnectRabbit rabbit = new ConnectRabbit();
var (conn, err) = rabbit.ConnectToRabbitMQ();
if (err != null)
{
    System.Environment.Exit(1);
}

// open channel
var channel = conn.CreateModel();

// declare queue
var testQlola = channel.QueueDeclare("testQlola", true, false, false, null);

// send message
var messageBody = new  OverbookingRequest()
{
    UniqueId = "rshby1002",
    TellerId = "0999999",
    Remark = "test dari publisher reo",
    AmountTrx = 2.0,
    CurrencyCredit = "USD",
    AccountCredit = "045202000001809",
    CurrencyDebit = "USD",
    AccountDebit = "045202000009807",
    ChannelId = "CMS001",
    TranType = "AC41"
};

var messageBodyJson = JsonConvert.SerializeObject(messageBody);
var body = Encoding.UTF8.GetBytes(messageBodyJson);

var properties = channel.CreateBasicProperties();
properties.Persistent = true;

channel.BasicPublish("", testQlola.QueueName, false, properties, body);

Console.WriteLine(messageBodyJson);

