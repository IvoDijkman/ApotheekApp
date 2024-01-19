using Microsoft.Extensions.Hosting;
using ApotheekApp.Business;

namespace ApotheekApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using IHost host = Host.CreateDefaultBuilder()
                               .ConfigureServices(config => config.BuildStandard())
                               .Build();



            Console.WriteLine("Done-");
        }
    }
}