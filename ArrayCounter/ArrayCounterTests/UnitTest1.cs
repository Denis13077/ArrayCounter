using NUnit.Framework;
using ArrayCounter;

namespace ArrayCounterTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("0",  ArraySum.SumNumbers(new []{""}));
        }
    }
}