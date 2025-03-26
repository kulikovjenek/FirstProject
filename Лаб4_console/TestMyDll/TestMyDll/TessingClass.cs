using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using KulikovLibrary;


namespace TestMyDll
{
    [TestFixture]
    class TessingClass
    {
        [Test]
        public void TestCalsKulikov()
        {
            ClassicAssert.AreEqual(4, matOperations.Add(2, 2));
            ClassicAssert.AreEqual(4, matOperations.Substract(6, 2));
            ClassicAssert.AreEqual(4, matOperations.Multi(2, 2));
            ClassicAssert.AreEqual(4, matOperations.Divide(8, 2));
            ClassicAssert.AreEqual(4, matOperations.Divide(80, 20));

        }
    }
}
