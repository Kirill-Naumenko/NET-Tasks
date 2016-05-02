using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using System.Collections.Generic;
using Task_2;

namespace Tests
{
    [TestClass]
    public class TestTask2
    {
        private List<BigInteger> list;
        [TestInitialize]
        public void Initialize()
        {
             list = new List<BigInteger>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(Fibonacci.Fib(i));
            }
        }


        [TestMethod]
        public void TestPoint1()
        {
            
            

            List<BigInteger> expected = new List<BigInteger>();
            List<BigInteger> actual = new List<BigInteger>();

            expected.Add(0);
            expected.Add(1);
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);

            actual = Point1.GetAnswer(list);


            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
            
            


        }

        [TestMethod]
        public void TestPoint2()
        {
            

            List<BigInteger> expected = new List<BigInteger>();
            List<BigInteger> actual = new List<BigInteger>();

            
            expected.Add(1);
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);

            actual = Point2.GetAnswer(list);


            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }


        }

        [TestMethod]
        public void TestPoint3()
        {
            

            List<BigInteger> expected = new List<BigInteger>();
            List<BigInteger> actual = new List<BigInteger>();

            expected.Add(0);

            actual = Point3.GetAnswer(list);


            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }


        }

        [TestMethod]
        public void TestPoint4()
        {
            

            List<double> expected = new List<double>();
            List<double> actual = new List<double>();

            expected.Add(1); //Корень из цифры 2 округленный в нижнюю сторону

            actual = Point4.GetAnswer(list);


            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }


        }

        [TestMethod]
        public void TestPoint5()
        {
            List<BigInteger> numbers = new List<BigInteger>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(Fibonacci.Fib(i));
            }

            List<BigInteger> expected = new List<BigInteger>();
            List<BigInteger> actual = new List<BigInteger>();

            expected.Add(34);
            expected.Add(13);
            expected.Add(21);

            actual = Point5.GetAnswer(numbers);


            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }


        }

        //[TestMethod]
        //public void TestPoint6()
        //{
        //    List<BigInteger> list = new List<BigInteger>();
        //    for (int i = 0; i < 15; i++)
        //    {
        //        list.Add(i);
        //    }

        //    List<BigInteger> expected = new List<BigInteger>();
        //    List<BigInteger> actual = new List<BigInteger>();

        //    expected.Add(10);
        //    expected.Add(11);
        //    expected.Add(12);
        //    expected.Add(13);
        //    expected.Add(14);
        //    expected.Add(15);

        //    actual = Point5.GetAnswer(list);


        //    Assert.AreEqual(expected, actual);


        //}

        [TestMethod]
        public void TestPoint7()
        {
            

            BigInteger expected = 3;
            BigInteger actual;


            actual = Point7.GetAnswer(list);


            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void TestPoint8()
        {
            

            double expected = 1;
            double actual; 

           


            actual = Point8.GetAnswer(list);


            Assert.AreEqual(expected, actual);


        }
    }



    
}
