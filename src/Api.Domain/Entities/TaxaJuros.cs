using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Entidade de Taxas e Juros
    /// </summary>
    public class TaxaJuros : ITaxaJuros
    {
        public TaxaJuros()
        {
            _IdcTaxaJuros = 0.01;
        }

        double _IdcTaxaJuros;

        /// <summary>
        /// Indice de atualização de valores
        /// </summary>
        public double IdcTaxaJuros { get => _IdcTaxaJuros; set => _IdcTaxaJuros = value; }
        public double Get()
        {
            return _IdcTaxaJuros;
        }
    }
}
