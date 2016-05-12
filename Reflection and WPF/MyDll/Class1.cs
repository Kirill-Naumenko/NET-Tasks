using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyDll
{
    public class Class1
    {

        public int x { get; set; }

        public Class1()
        {

        }

        public void LALALA()
        {

        }

        public int  MTHD()
        {
            return 1;
        }

    }

    [TestClass]
    public class Test
    {

        [TestMethod]
        public void Test1()
        {
            Class1 c = new Class1();
            c.LALALA();
            Assert.AreEqual(1, c.MTHD());
        }

    }
}
