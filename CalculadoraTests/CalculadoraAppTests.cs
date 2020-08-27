using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
using System;

namespace CalculadoraTests
{
    [TestClass]
    public class CalculadoraAppTests
    {
        [TestMethod]
        public void TestSomaComDoisValores()
        {
            //Arrange - Prepara o teste, instancia classes...
            double op1 = 5;
            double op2 = 2;
            double expected = 7;
            CalculadoraApp calc = new CalculadoraApp();
            //Act - Instancia o método que quer executar, os parâmetros e aí chama ele...
            double retornoTeste = calc.Soma(op1, op2);

            //Assert - Verifica se o retorno é o retorno esperado.
            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestSomaComDoisOutrosValores()
        {

            double op1 = 4;
            double op2 = 1;
            double expected = 5;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Soma(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestSomaComUmDosValoresNegativo()
        {

            double op1 = -37;
            double op2 = 1;
            double expected = -36;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Soma(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestSomaComUmDosValoresReais()
        {

            double op1 = -37.67;
            double op2 = 1.6;
            double expected = -36.07;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Soma(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestMultiplicacaoComDoisValores()
        {

            double op1 = 23;
            double op2 = 3;
            double expected = 69;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Multiplicar(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestMultiplicacaoComUmValorNegativo()
        {

            double op1 = 23;
            double op2 = -3;
            double expected = -69;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Multiplicar(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestMultiplicacaoComDoisValoresNegativos()
        {

            double op1 = -23;
            double op2 = -3;
            double expected = 69;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Multiplicar(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestMultiplicacaoComUmValorReal()
        {

            double op1 = -23;
            double op2 = 3.02;
            double expected = -69.46;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Multiplicar(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestSubtracaoComDoisValores()
        {

            double op1 = 23;
            double op2 = 3;
            double expected = 20;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Subtrair(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestSubtracaoComUmValorNegativo()
        {

            double op1 = 23;
            double op2 = -3;
            double expected = 26;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Subtrair(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestSubtracaoComUmValorReal()
        {

            double op1 = 23;
            double op2 = 3.02;
            double expected = 19.98;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Subtrair(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }


        [TestMethod]
        public void TestDivisaoComDoisValores()
        {

            double op1 = 22;
            double op2 = 2;
            double expected = 11;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Divisao(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestDivisaoComUmValorNegativo()
        {

            double op1 = 22;
            double op2 = -2;
            double expected = -11;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Divisao(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        public void TestDivisaoComUmValorReal()
        {

            double op1 = 22;
            double op2 = 0.5;
            double expected = 44;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Divisao(op1, op2);

            Assert.AreEqual(expected, retornoTeste);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void TestDivisaoComUmValorIgualAZero()
        {

            double op1 = 22;
            double op2 = 0;
            double expected = 0;
            CalculadoraApp calc = new CalculadoraApp();

            double retornoTeste = calc.Divisao(op1, op2);
        }
    }
}