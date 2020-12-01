using System;
using System.Collections.Generic;
using Kinvo.Domain.Entities;
using Kinvo.Domain.Enumerators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kinvo.Tests
{
    [TestClass]
    public class DominioUnitTest
    {
        [TestMethod]
        public void TesteNoDominioParaValidarDados()
        {
            var produtos = new List<Produto>();

            //Ações
            var acoesBradesco = new Produto()
            {
                Nome = "Ações BBDC4",
                CategoriaProduto = CategoriaProduto.Acoes,
                Instituicao = "XP Investimentos",
                AtivoSigla = "BBDC4",
                Qtde = 100,
                PrecoCompra = (Decimal)23.90,
                DataInicio = DateTime.Now,
                TaxaCorretagem = 0
            };
            produtos.Add(acoesBradesco);

            //FIIs
            var fiiMaxiRenda = new Produto()
            {
                Nome = "FII MXRF11",
                CategoriaProduto = CategoriaProduto.FundosImobiliarios,
                Instituicao = "Modal",
                AtivoSigla = "MXRF11",
                Qtde = 50,
                PrecoCompra = (Decimal)10.54,
                DataInicio = DateTime.Now,
                TaxaCorretagem = 0
            };
            produtos.Add(fiiMaxiRenda);

            //Renda Fixa Pre
            var rendaFixaPre = new Produto()
            {
                Nome = "RENDA FIXA PRE",
                CategoriaProduto = CategoriaProduto.RendaFixaPre,
                Instituicao = "Rico",
                Qtde = 5,
                PrecoCompra = (Decimal)1000,
                TaxaAnual = (Decimal)5.5,
                DataInicio = DateTime.Now,
                TaxaCorretagem = 0
            };
            produtos.Add(fiiMaxiRenda);

        }
    }
}
