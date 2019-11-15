using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Test__1.Model;
using Unit_Test__1.Model.Impl;

namespace Unit_Test_1_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructItem()
        {
            var idNum = 11111;
            var desc = "Item_11111";
            var unitOfMeasure = UnitOfMeasure.BOX;
            var weight = 22;
            var firstItem = new ItemImpl(idNum, desc, unitOfMeasure, weight);

            Assert.AreEqual(idNum, firstItem.IdNumber);
            Assert.AreEqual(desc, firstItem.Description);
            Assert.AreEqual(unitOfMeasure, firstItem.Uom);
            Assert.AreEqual(weight, firstItem.Weight);
        }
    }
}
