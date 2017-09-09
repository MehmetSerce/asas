using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiing
{
    [TestFixture]
    public class UnitTest
    {
        [TestCase]
        public void test1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestCase]
        public void test2()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
