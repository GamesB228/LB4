using Microsoft.VisualStudio.TestTools.UnitTesting;
using LB4;
using System.Collections.Generic;

namespace MaterialTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestClass]
        public class MaterialTests
        {
            [TestMethod]
            public void Cement_Discount_Test()
            {
                Cement cement = new Cement("Цемент", 100, 60, 25);
                Assert.AreEqual(5400, cement.CalculateCost());
            }

            [TestMethod]
            public void Wood_Strength_Test()
            {
                Wood wood = new Wood("Дерево", 200, 10, "Лакування");
                Assert.AreEqual(3000, wood.CalculateCost());
            }

            [TestMethod]
            public void TotalCost_Test()
            {
                var materials = new List<BuildingMaterial>
            {
                new Cement("Цемент", 100, 60, 25),
                new Wood("Дерево", 200, 10, "Без обробки")
            };

                MaterialCalculator calc = new MaterialCalculator();
                Assert.AreEqual(5400 + 2000, calc.TotalCost(materials));
            }
            [TestMethod]
            public void Negative_Quantity_Test()
            {
                Cement cement = new Cement("Цемент", 100, -5, 25);
                Assert.AreEqual(-500, cement.CalculateCost());
            }

            [TestMethod]
            public void Empty_Material_List_Test()
            {
                MaterialCalculator calc = new MaterialCalculator();
                Assert.AreEqual(0, calc.TotalCost(new List<BuildingMaterial>()));
            }

            [TestMethod]
            public void Expired_Cement_Test()
            {
                Cement cement = new Cement("Цемент", 100, 10, 25);
                DateTime expiredDate = DateTime.Now.AddDays(-1);
                Assert.IsFalse(cement.CheckExpiry(expiredDate));
            }
        }
    }
}
