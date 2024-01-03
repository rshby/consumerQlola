using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;

namespace publisher.Queue;

public class ConnectRabbit
{
    // global variable
    private IConfiguration _config;

    // constructor
    public ConnectRabbit()
    {
        _config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true)
            .AddEnvironmentVariables().Build();
    }

    // method to connect rabbitmq
    public (IConnection, Exception?) ConnectToRabbitMQ()
    {
        try
        {
            ConnectionFactory conn = new ConnectionFactory()
            {
                HostName = _config.GetValue<string>("rabbitMQ:host"),
                UserName = _config.GetValue<string>("rabbitMQ:user"),
                Password = _config.GetValue<string>("rabbitMQ:password"),
                Port = int.Parse(_config.GetValue<string>("rabbitMQ:port")),
            };

            return (conn.CreateConnection(), null);
        }
        catch (Exception err)
        {
            Console.WriteLine($"error cant connect rabbitMQ : {err}");
            return (null, err);
        }
    }
}