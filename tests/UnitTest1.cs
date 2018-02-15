using System;
using Xunit;
using System.Threading.Tasks;
using Orleans;
using Orleans.TestingHost;
using interfaces;
using grains;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.False(false, "It should be false");
        }

        [Fact]
        public async Task SimpleTextCorrectly()
        {
            var cluster = new TestCluster();
            cluster.Deploy();

            var hello = cluster.GrainFactory.GetGrain<ISimpleText>(0);
            var greeting = await hello.GetString("one");

            cluster.StopAllSilos();

            Assert.Equal("Your message is: one", greeting);
        }
    }
}
