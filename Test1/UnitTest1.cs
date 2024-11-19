using Calculadora.Modelos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestSuma()
        {
            double num1 = 3, num2 = 6;
            Operacion op = new Operacion();
            double resultado = op.Sumar(num1, num2);
            Assert.AreEqual(9, resultado);
        }

        [TestMethod]
        public void TestResta()
        {
            double num1 = 3, num2 = 6;
            Operacion op = new Operacion();
            double resultado = op.Restar(num1, num2);
            Assert.AreEqual(-3, resultado);
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            double num1 = 3, num2 = 6;
            Operacion op = new Operacion();
            double resultado = op.Multiplicar(num1, num2);
            Assert.AreEqual(18, resultado);
        }

        [TestMethod]
        public void TestDivision()
        {
            double num1 = 3, num2 = 6;
            Operacion op = new Operacion();
            double resultado = op.Dividir(num1, num2);
            Assert.AreEqual(0.5, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionPorCero()
        {
            double num1 = 3, num2 = 0;
            Operacion op = new Operacion();
            double resultado = op.Dividir(num1, num2);
        }
    }

}
