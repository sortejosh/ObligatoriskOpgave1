using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave1
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void IdTest()
        {
            Car car = new Car(4, "Tesla", 2000, "AB12345");
            car.Id = 4;
            Assert.IsInstanceOfType(car.Id, typeof(int));
        }

            [TestMethod()]
            public void ModelTest()
            {
                Car car = new Car(2, "XPeng", 110000, "AB01234");
                car.Model = "XPeng";
                Assert.AreEqual("XPeng", car.Model);

                car.Model = "Honda";
                Assert.AreEqual("Honda", car.Model);

                Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Model = "5");
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Model = "1");
            }

            [TestMethod()]
            public void PriceTest()
            {
                Car car = new Car(3, "Tesla", 2000, "AB12345");
                car.Price = 2000;
                Assert.AreEqual(2000, car.Price);
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Price = 0);
            }
            [TestMethod()]
        public void LicensePlateTest()
                {
                    Car car = new Car(1, "XPeng", 129000, "AB12345");
                    car.LicensePlate = "AA12345";
                    Assert.AreEqual("AA12345", car.LicensePlate);
                    car.LicensePlate = "AA";
                    Assert.AreEqual("AA", car.LicensePlate);
                    Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "01234567");
                    Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "1");

             }
    }
}
    
