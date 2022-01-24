using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using CalcLibrary;
namespace CalcLibraryTests
{
   [TestFixture]
    public class CalculatorTests
    {
        SimpleCalculator Sut;

        [SetUp]
        public void Initialize()
        {
            Sut = new SimpleCalculator();
        }
        [TearDown]
        public void CleanUp()
        {
            Sut = null;
        }
        [Test]
        [TestCase(15,20,35)]
        [TestCase(10.0,20.0,30.0)]
        public void Addition(double input1,double input2,double expected)
        {
            double Actual = Sut.Addition(input1,input2);
            Assert.AreEqual(expected, Actual);  
        }


       
        

        
    }
}
