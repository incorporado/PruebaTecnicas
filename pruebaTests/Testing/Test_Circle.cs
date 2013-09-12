using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prueba
{
    [TestClass]
    public class Test_Circle
    {
        [TestMethod]
        public void TestMethod1()
        {
           Prueba unaPrueba = new Prueba();
           Assert.IsTrue(unaPrueba.sumar(1, 0) == 2,"TODO BIEN");
           Assert.AreEqual(unaPrueba.sumar(1, 0), unaPrueba.sumar(1, 0));
        }
    }
}
