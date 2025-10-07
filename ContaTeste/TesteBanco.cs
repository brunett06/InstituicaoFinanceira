using ControleContas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ControleContas.Tests
{
    [TestClass]
    public class BancoTests
    {
        [TestMethod]
        public void TestarCriacaoBancoValido()
        {
            // cen�rio
            string nome = "Banco Caixa";
            int numero = 1;

            // a��o
            Banco banco = new Banco(nome, numero);

            // verifica��o
            Assert.AreEqual(nome, banco.Nome);
            Assert.AreEqual(numero, banco.Numero);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestarCriacaoBancoComNomeInvalido()
        {
            // nome vazio
            Banco banco = new Banco("", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestarCriacaoBancoComNumeroInvalido()
        {
            // n�mero negativo
            Banco banco = new Banco("Banco Teste", -5);
        }
    }
}
