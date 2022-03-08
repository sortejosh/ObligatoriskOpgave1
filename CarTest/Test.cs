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
        public void LicensePlateTest()
        {
            Car car = new Car(1, "Audi", 1500, "AA12345");
            car.LicensePlate = "AA12345";
            Assert.AreEqual("AA12345", car.LicensePlate);
            car.LicensePlate = "AA";
            Assert.AreEqual("AA", car.LicensePlate);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "12345678");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "1");
            /*
            Teacher teacher = new Teacher("Anders");
            teacher.Salary = 100;
            Assert.AreEqual(100, teacher.Salary);

            teacher.Salary = 0;
            Assert.AreEqual(0, teacher.Salary);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacher.Salary = -1);
            */
        }
    }
}