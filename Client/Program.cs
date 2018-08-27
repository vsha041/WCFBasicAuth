using System;
using Client.TestService;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new Service1Client
            {
                ClientCredentials =
                {
                    UserName =
                    {
                        UserName = @"domain\username",
                        Password = @"password"
                    }
                }
            };
            var data = client.GetData(12);
            Console.WriteLine(data);
        }
    }
}
