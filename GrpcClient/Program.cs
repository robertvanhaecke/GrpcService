using Grpc.Net.Client;
using System;
using static GrpcService.Greeter;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Lucedy";

            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new GreeterClient(channel);

            var response = client.SayHello(new GrpcService.HelloRequest { Name = name });

            Console.WriteLine($"{response.Message}!");
            Console.ReadLine();
        }
    }
}
