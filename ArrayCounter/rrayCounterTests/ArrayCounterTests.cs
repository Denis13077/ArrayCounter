using ArrayCounter;
using NUnit.Framework;

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
        
        [Test]
        public static void NumbersWithLetters()
        {
            Assert.AreEqual("1", ArraySum.SumNumbers(new []{"0", "a", "b", "1"}));
        }
        
        [Test]
        public static void NumbersWithSpecialChar()
        {
            Assert.AreEqual("9", ArraySum.SumNumbers(new []{"9", "@", "/", "\\"}));
        }
    }
}