using NUnit.Framework;

namespace ArrayCounter
{
    public class Tests
    {
        [Test]
        public static void PositiveNumbers()
        {
            Assert.AreEqual("6", Program.SumNumbers(new []{"1", "2", "3"}));
        }
            
        [Test]
        public static void EmptyString()
        {
            Assert.AreEqual("0", Program.SumNumbers(new []{""}));
        }
        
        [Test]
        public static void NegativeNumbers()
        {
            Assert.AreEqual("-6", Program.SumNumbers(new []{"-1", "-2", "-3"}));
        }
    }
}