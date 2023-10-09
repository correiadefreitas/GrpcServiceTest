using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcServiceClient;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7246");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "123 456", Age=32, Corpus = Corpus.Web });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine($" Reply 0 {reply.Resultados[0]?.Title} Reply 1 {reply.Resultados[1]?.Snippets[0]}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();