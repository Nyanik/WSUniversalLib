using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestCalc
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void Check_BadProductType_True()
        {
            int rezult = -1;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(5, 2, 10, 10, 10);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_BadMaterialType_True()
        {
            int rezult = -1;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 6, 10, 10, 10);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_FirstProductTypeFirstMaterialTypeEasy_True()
        {
            int rezult = 1097;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(1, 1, 10, 10, 10);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_SecondProductTypeFirstMaterialTypeEasy_True()
        {
            int rezult = 2493;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(2, 1, 10, 10, 10);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_ThirdProductTypeFirstMaterialTypeEasy_True()
        {
            int rezult = 8405;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 1, 10, 10, 10);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_FirstProductTypeSecondMaterialTypeEasy_True()
        {
            int rezult = 1099;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(1, 2, 10, 10, 10);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_SecondProductTypeSecondMaterialTypeEasy_True()
        {
            int rezult = 2497;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(2, 2, 10, 10, 10);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_ThirdProductTypeSecondMaterialTypeEasy_True()
        {
            int rezult = 8420;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 2, 10, 10, 10);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_NegativeArea_True()
        {
            int rezult = -1;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 2, 10, 10, -10);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_NegativeCount_True()
        {
            int rezult = -1;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 2, -10, -10, 10);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_FirstProductTypeFirstMaterialTypeHard_True()
        {
            int rezult = 48;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(1, 1, 1, (float)6.6, (float)6.6);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_ThirdProductTypeFirstMaterialTypeHard_True()
        {
            int rezult = 367;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 1, 1, (float)6.6, (float)6.6);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_FirstProductTypeSecondMaterialTypeHard_True()
        {
            int rezult = 48;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(1, 2, 1, (float)6.6, (float)6.6);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_SecondProductTypeSecondMaterialTypeHard_True()
        {
            int rezult = 109;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(2, 2, 1, (float)6.6, (float)6.6);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_ThirdProductTypeSecondMaterialTypeHard_True()
        {
            int rezult = 367;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 2, 1, (float)6.6, (float)6.6);

            Assert.AreEqual(rezult, actual);
        }
    }
}
