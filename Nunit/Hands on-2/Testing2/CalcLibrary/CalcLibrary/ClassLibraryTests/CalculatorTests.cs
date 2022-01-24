using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using CalcLibrary;
namespace ClassLibraryTests
{
    public class CalculatorTests
    {
        SimpleCalculator Sut;

        [SetUp]
        public void Intialize()
        {
            Sut = new SimpleCalculator();

        }
        [TearDown]
        public void CleanUp()
        {
            Sut = null;
        }
        [Test]
        [TestCase(5.0,7.0,12.0)]
        [TestCase(10.0,9.0,19.0)]
        public void TestAndClear(double input1,double input2,double expected)
        {
            double result = Sut.Addition(input1, input2);
            Assert.AreEqual(expected, result);
            Sut.AllClear();
        }
        [Test]
        [TestCase(20.0,10.0,10.0)]
        [TestCase(40.0,10.0,30.0)]
        public void SubstractionTest(double input1,double input2,double expected)
        {
            double result = Sut.Subtraction(input1,input2);
            Assert.AreEqual(expected, result);

        }
        [Test]
        [TestCase(10.0,2.0,20.0)]
        [TestCase(5,5,25)]

        public void MultiplicationTest(double input1,double input2,double expected)
        {
            double result = Sut.Multiplication(input1, input2);
            Assert.AreEqual(expected, result);
        }
        [Test]
        [TestCase(9.0,3.0,3.0)]
        [TestCase(9.0,0.0,1.0)]
        public void DivisionTest(double input1,double input2,double expected)
        {
            try
            {
                double result = Sut.Division(input1,input2);
                Assert.AreEqual(expected, result); 
            }
            catch (ArgumentException)
            {
                Assert.Fail("Division by zero");
            }
        }


    }
}
