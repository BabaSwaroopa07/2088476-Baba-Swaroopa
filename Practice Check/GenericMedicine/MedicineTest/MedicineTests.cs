using NUnit.Framework;
using System.IO;
using System;
using GenericMedicine;

namespace MedicineTestProject
{
    [TestFixture]
    public class MedicineTests
    {
        Program obj = new Program();

        [SetUp]
        public void Setup()
        {

        }

        [TestCase("abc", "xyz", "carbon", "12/12/2022", 2314)]
        [TestCase("abc-34983", "xyz-948903", "carbon iron", "02/10/2022", 2.3)]
        public void MedicineObjectCreation(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Assert.DoesNotThrow(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
        }

        [TestCase("", "xyz-948903", "carbon iron", "02/10/2022", 2.3)]
        [TestCase("", "xy", "carbon", "02/10/2023", 24)]
        public void EmptyNameException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Medicine name cannot be empty. Please provide valid value"));
        }

        [TestCase("abc", "xyz-948903", "carbon iron", "02/10/2022", -2.3)]
        [TestCase("abc", "xy", "carbon", "02/10/2023", -24)]
        public void LessThanZeroPriceException(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect value for Medicine price per strip. Please provide valid value"));
        }

        [TestCase("abc", "xyz-948903", "carbon iron", "02/10/2020", 2.3)]
        [TestCase("abc", "xy", "carbon", "02/12/1900", 24)]
        public void ExpriyDateCheck(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {

            var ex = Assert.Throws<Exception>(() => obj.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect expiry date. Please provide valid value"));
        }


    }




}

