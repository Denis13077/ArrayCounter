using ArrayCounter;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public static void PositiveNumbers()
        {
            Assert.AreEqual("6", ArraySum.SumNumbers(new []{"1", "2", "3"}));
        }
            
        [Test]
        public static void EmptyString()
        {
            Assert.AreEqual("0", ArraySum.SumNumbers(new []{""}));
        }
        
        [Test]
        public static void NegativeNumbers()
        {
            Assert.AreEqual("6", ArraySum.SumNumbers(new []{"-1", "-2", "-3"}));
        }
    }
}