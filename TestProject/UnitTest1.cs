using net_calculator_tester;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
       
        [Test]
        public void TestAdd()
        {
            float result = Calculator.Add(2,45);
            Assert.AreEqual(47, result);
        }

        [Test]
        public void TestSubstract()
        {
            float result = Calculator.Substract(2, 45);
            Assert.AreEqual(-43, result);
        }

        [Test]
        public void TestDivide()
        {
            float result = Calculator.Divide(6, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestMultiply()
        {
            float result = Calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }
    }
}