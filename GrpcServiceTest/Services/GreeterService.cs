using Grpc.Core;
using GrpcServiceTest;
using Microsoft.AspNetCore.Http;
using System.Diagnostics.CodeAnalysis;

namespace GrpcServiceTest.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            var ret = new HelloReply { Message = "Hello " + request.Name, Resultados = { 
                    new Resultado() { Title=" - Title 1", Url="wsx", Snippets = {"123"}},
                    new Resultado() { Title = " - Title 2", Url = "qaz", Snippets = {"abc"}}
                } 
            };

            var retTask = Task.FromResult(ret);
            return retTask;
        }
    }
}