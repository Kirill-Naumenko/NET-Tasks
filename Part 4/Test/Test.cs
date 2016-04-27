using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;
using Task_3;
using Task_4;
using Task_5;

namespace Test
{
    [TestClass]
    public class Test

    {
        [TestMethod]
        public void TestTask1()
        {
            Point a = new Point(2, 2);
            Point b = new Point(2, 2);
            Point c = new Point(3, 3);
            Point d = null;
            Point e = a;
         

            Assert.IsTrue(a.Equals(b));
            Assert.IsFalse(a.Equals(c));
            Assert.IsFalse(a.Equals(d));
            Assert.IsTrue(a.Equals(e));
           
        }

        [TestMethod]
        public void TestTask5()
        {
            Rectangle rec1 = new Rectangle(4, 4);
            Rectangle rec2 = new Rectangle(1, 3);

            Assert.AreEqual(5, Counter.count(rec1, rec2));

            rec1 = new Rectangle(8, 9);
            rec2 = new Rectangle(3, 2);

            Assert.AreEqual(12, Counter.count(rec1, rec2));

            rec1 = new Rectangle(3, 3);
            rec2 = new Rectangle(1, 1);

            Assert.AreEqual(9, Counter.count(rec1, rec2));
        }

        [TestMethod]
        public void TestTask4()
        {

            Product product = new Product();
            Bag bag = new Bag();
            Cashier casier = new Cashier();

            Assert.IsTrue(bag.add(product));
            Assert.IsTrue(bag.remove(product));

            Product tempProduct1 = new Product(1000);
            Product tempProduct2 = new Product(2000);
            bag.add(tempProduct1);
            bag.add(tempProduct2);
            double summary = casier.getSummaryPrice(bag);
            Assert.AreEqual(3000, summary);
            


            
                
        }


    }
}
