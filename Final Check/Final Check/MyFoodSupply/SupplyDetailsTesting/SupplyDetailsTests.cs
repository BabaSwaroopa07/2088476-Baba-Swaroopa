using NUnit.Framework;
using System.IO;
using System;
using MyFoodSupply;

namespace SupplyDetailsTesting
{
    public class SupplyDetailsTests
    {
        Program obj = new Program();


        [TestCase(2, "12/10/2022", "Hydi",23.22)]
        [TestCase(10, "12/11/2022", "Klara",45)]
        public void CartonObjectCreation(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail food = obj.CreateFoodDetail("Blueberry", 2, DateTime.Parse("12/12/2022"), 21000.00);
            Assert.DoesNotThrow(() => obj.CreateSupplyDetail(foodItemCount,requestDate,sellerName,packingCharge,food));
            
        }

        [TestCase(-2, "12/10/2021", "Hydi", 23.22)]
        [TestCase(-10, "12/11/2021", "Klara", 45)]
        public void LessThanZeroFoodItemCount(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail food = obj.CreateFoodDetail("Blueberry", 2, DateTime.Parse("12/12/2022"), 21000.00);

            var ex = Assert.Throws<Exception>(() => obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));
            Assert.That(ex.Message, Is.EqualTo("Please check the Food item which is selected"));
        }

        [TestCase(2, "12/10/2023", "Hydi", 23.22)]
        [TestCase(10, "12/11/2023", "Klara", 45)]
        public void RequestDateValidity(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            FoodDetail food = obj.CreateFoodDetail("Blueberry", 2, DateTime.Parse("12/12/2022"), 21000.00);

            var ex = Assert.Throws<Exception>(() => obj.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, food));
            Assert.That(ex.Message, Is.EqualTo("Please check the request Date"));
        }

        [TestCase(2, "12/10/2021", "Hydi", 23.22)]
        [TestCase(10, "12/11/2021", "Klara", 45)]
        public void NullSupplyObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge)
        {
            Assert.AreEqual(obj.CreateSupplyDetail(foodItemCount,requestDate,sellerName,packingCharge,null), null);
        }


    }
}
