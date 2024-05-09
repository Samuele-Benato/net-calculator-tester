using net_calculator_tester;

namespace TestProject
{
    public class Tests
    {
        Calculator calculator = new Calculator();

        [SetUp]
        public void Setup()
        {

        }
        
        [Test]
        public void TestAdd()
        {
            
            float result = calculator.Add(2,45); // rendere la classe statica
            Assert.AreEqual(47, result);
        }

        [Test]
        public void TestSubstract()
        {
            float result = calculator.Substract(2, 45);
            Assert.AreEqual(-43, result);
        }

        [Test]
        public void TestDivide()
        {
            float result = calculator.Divide(6, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestMultiply()
        {
            float result = calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }
    }
}