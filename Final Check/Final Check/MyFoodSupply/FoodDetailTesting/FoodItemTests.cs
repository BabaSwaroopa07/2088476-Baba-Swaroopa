using NUnit.Framework;
using System.IO;
using System;
using MyFoodSupply;

namespace FoodDetailTesting
{
    [TestFixture]
    public class FoodItemTests
    {
        Program obj = new Program();

        
        [TestCase("Chocolates",2,"12/12/2022", 23.23)]
        [TestCase("Blueberry", 2, "12/10/2022", 21000.00)]
        public void FoodDetailCreate(string name, int dishType, DateTime expiryDate, double price)
        {
            Assert.DoesNotThrow(() => obj.CreateFoodDetail(name,dishType,expiryDate,price));
        }

        
        [TestCase("", 2, "12/12/2021", 23.23)]
        [TestCase("", 2, "12/10/2021", 21000.00)]
        public void ExceptionEmptyName(string name, int dishType, DateTime expiryDate, double price)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(ex.Message, Is.EqualTo("Please provide valid foodItem"));
        }

        [TestCase("chocolates", 2, "12/12/2021", -0.00001)]
        [TestCase("Blueberry", 2, "12/10/2021", -10000)]
        public void NegativePriceException(string name, int dishType, DateTime expiryDate, double price)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(ex.Message, Is.EqualTo("Please check the valid value"));
        }

        [TestCase("chocolates", 2, "12/12/2020", 200)]
        [TestCase("Blueberry", 2, "12/10/2000",22.22)]
        public void ExpiryDate(string name, int dishType, DateTime expiryDate, double price)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.That(ex.Message, Is.EqualTo("Please provide valid date"));
        }

    }
}
