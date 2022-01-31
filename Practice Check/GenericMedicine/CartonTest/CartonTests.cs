using NUnit.Framework;
using System.IO;
using System;
using GenericMedicine;

namespace CartonTest
{
    [TestFixture]
    public class CartonTests
    {
        Program obj = new Program();

        [TestCase(2, "12/23/2023", "A-423/abc, xyz")]
        [TestCase(1002, "12/26/2023", "A-423/abc, xyz")]
        public void CartonObjectCreation(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Medicine med = obj.CreateMedicineDetail("abc-34983", "xyz-948903", "carbon iron", DateTime.Parse("12/12/2022"), 2.3);
            Assert.DoesNotThrow(() => obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, med));
        }

        [TestCase(-2, "12/23/2021", "A-423/abc, xyz")]
        [TestCase(-100, "12/23/2021", "A-423/abc, xyz")]
        public void LessThanZeroStripCount(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Medicine med = obj.CreateMedicineDetail("abc-34983", "xyz-948903", "carbon iron", DateTime.Parse("12/12/2022"), 2.3);

            var ex = Assert.Throws<Exception>(() => obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, med));
            Assert.That(ex.Message, Is.EqualTo("Incorrect strip count. Please check"));
        }

        [TestCase(2, "12/23/2000", "A-423/abc, xyz")]
        [TestCase(100, "12/23/1900", "A-423/abc, xyz")]
        public void LaunchDateCheck(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Medicine med = obj.CreateMedicineDetail("abc-34983", "xyz-948903", "carbon iron", DateTime.Parse("12/12/2022"), 2.3);

            var ex = Assert.Throws<Exception>(() => obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, med));
            Assert.That(ex.Message, Is.EqualTo("Incorrect launch date. Please provide valid value"));
        }

        [TestCase(2, "12/23/2022", "A-423/abc, xyz")]
        [TestCase(100, "12/23/2022", "A-423/abc, xyz")]
        public void NullCartonObject(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            Assert.AreEqual(obj.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, null), null);
        }
    }
}
