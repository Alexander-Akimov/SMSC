using SMSC.Client;
using SMSC.Domain.Objects;
using System;
using System.Collections.Generic;

namespace TestClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseUrl = @"https://localhost:5001";

            using (var smscClient = new SmscClient(baseUrl))
            {
                var requestPkg = new PackageRequest
                {
                    Login = "User1",
                    Password = "333",
                    Send = new List<RequestMsg> {
                        new RequestMsg{Id="1", Receiver="", Sender="sender", Value="bigmessage"}
                    }
                };
                var result = smscClient.SendMessageAsync(requestPkg).Result;
                if (result == null)
                {
                    Console.WriteLine(smscClient.Error);
                }

            };
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
