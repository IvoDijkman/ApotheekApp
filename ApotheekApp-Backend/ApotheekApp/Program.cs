using Microsoft.Extensions.Hosting;
using ApotheekApp.Business;

namespace ApotheekApp
{
    public class Program
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