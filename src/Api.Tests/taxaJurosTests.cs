using Domain.Entities;
using System;
using Xunit;
using FluentAssertions;
using Domain.Interfaces;
using Application.Controllers;

namespace Testes
{
    public class taxaJurosTests
    {
        [Fact]
        public void taxaJurosTest1()
        {
            TaxaJuros taxaJuros = new TaxaJuros();
            taxaJuros.Should().Be(taxaJuros is ITaxaJuros, "Tipo/Interface incorreta");
        }

        [Fact]
        public void taxaJurosTest2()
        {
            TaxaJuros taxaJuros = new TaxaJuros();
            taxaJuros.Get().Should().BeGreaterThan(0.0, "Taxa retornou valor menor ou igual a zero");
        }

    }
}
