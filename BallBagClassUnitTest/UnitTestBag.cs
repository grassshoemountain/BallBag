using BallBagClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BallBagClassUnitTest
{
    [TestClass]
    public class UnitTestBag
    {
        [TestMethod]
        public void TestCreateBag()
        {
            Bag bag1 = new Bag();
            Bag bag2 = new Bag();
            Assert.IsTrue(Bag.GetNumberOfBags() == 2);
            Assert.IsTrue(bag2.ToString() == "Bag #2: <empty>;");

            bag1.AddRange(new System.Collections.Generic.List<int> {1, 2, 3});

            System.Console.WriteLine(bag1.ToString());

            Assert.IsTrue(bag1.ToString() == "Bag #1: 1, 2, 3;");
        }
    }
}
