using NUnit.Framework;
using PlingPlangPlong;

namespace PlingPlangPlongTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(21, "PlingPlong")]
        [TestCase(28,"Plong")]
        [TestCase(30, "PlingPlang")]
        [TestCase(34, "34")]


        public void FactorsStringTests(int value, string expectedValue)
        {
            var acutalValue = Program.RainDrops(value);
            Assert.AreEqual(expectedValue, acutalValue);
        }

    }
}