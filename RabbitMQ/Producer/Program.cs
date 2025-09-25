using Producer.Exchanges;
using RabbitMQ.Client;

var factory = new ConnectionFactory() { HostName = "localhost", VirtualHost = "smart_dev", UserName = "smart-project", Password = "1234" };

TopicExchange directExchange = new TopicExchange(factory);
FanoutExchange fanoutExchange = new FanoutExchange(factory);
HeaderExchange headerExchange = new HeaderExchange(factory);
Console.WriteLine("Enter messages to send (type 'exit' to quit):");

while (true)
{
    string? input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input)) continue;
    if (input.ToLower() == "exit") break;

    await directExchange.SendMessage(input);


}