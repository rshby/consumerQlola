using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.CompilerServices;
using RabbitMQ.Client;

namespace consumerQlola.Queue;

public class ConnectRabbitMQ
{
    // global variabel
    private IConfiguration _config;

    // constructor
    public ConnectRabbitMQ()
    {
        this._config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true).AddEnvironmentVariables().Build();
    }

    // method to connect
    public (IConnection, Exception?) ConnectToRabbitMQ()
    {
        try
        {
            ConnectionFactory connectionFactory = new ConnectionFactory();
            connectionFactory.HostName = _config.GetValue<string>("rabbitMQ:host");
            connectionFactory.UserName = _config.GetValue<string>("rabbitMQ:user");
            connectionFactory.Password = _config.GetValue<string>("rabbitMQ:password");
            connectionFactory.Port = int.Parse(_config.GetValue<string>("rabbitMQ:port"));

            return (connectionFactory.CreateConnection(), null);
        }
        catch (Exception err)
        {
            Console.WriteLine($"error cant connect rabbitMQ : {err}");
            return (null, err);
        }
    }
}