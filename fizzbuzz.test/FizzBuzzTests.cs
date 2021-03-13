using NUnit.Framework;
using fizzbuzz;
namespace fizzbuzz.test
{
    public class FizzBuzzTests
    {

        [Test]
        public void Given3ReturnFizz()
        {
            Assert.AreEqual(new FizzBuzz().Execute(3), "Fizz");
        }

        [Test]
        public void Given5ReturnBuzz()
        {
            Assert.AreEqual(new FizzBuzz().Execute(5), "Buzz");
        }

        [Test]
        public void Given6ReturnFizz()
        {
            Assert.AreEqual(new FizzBuzz().Execute(6), "Fizz");
        }

        [Test]
        public void Given1Return1()
        {
            Assert.AreEqual(new FizzBuzz().Execute(1), "1");
        }


        [Test]
        public void Given2Return2()
        {
            Assert.AreEqual(new FizzBuzz().Execute(2), "2");
        }

        [Test]
        public void Given10ReturnBuzz()
        {
            Assert.AreEqual(new FizzBuzz().Execute(10), "Buzz");
        }

        [Test]
        public void Given15ReturnFizzBuzz()
        {
            Assert.AreEqual(new FizzBuzz().Execute(15), "FizzBuzz");
        }

        [Test]
        public void Given30ReturnFizzBuzz()
        {
            Assert.AreEqual(new FizzBuzz().Execute(30), "FizzBuzz");
        }
    }
}