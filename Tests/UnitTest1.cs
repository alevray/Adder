using NUnit.Framework;

namespace Tests
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
            var a = AddLib.Adder.Add(10, 20);
            Assert.That(a, Is.EqualTo(30));
        }
    }
}