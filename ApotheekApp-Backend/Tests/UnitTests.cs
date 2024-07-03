using Microsoft.Extensions.Hosting;
using ApotheekApp.Business;

namespace ApotheekApp.Tests
{
    public static class Hoster
    {
        public static IHost HostBuilder()
        {
            IHost host = Host.CreateDefaultBuilder().ConfigureServices(config => config.BuildTest())
                             .Build();
            return host;
        }
    }

    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{

        //}

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}
    }
}