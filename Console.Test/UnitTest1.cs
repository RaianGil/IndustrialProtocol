using NUnit.Framework;

namespace Console.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            testIndustrialProtocol.runGet_Error();
            Assert.Pass();
        }
    }
}