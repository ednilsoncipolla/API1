using Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        TaxaJuros _taxaJuros;

        public TaxaJurosService(TaxaJuros taxaJuros)
        {
            _taxaJuros = taxaJuros;
        }

        public async Task<double> Get()
        {
            return _taxaJuros.Get();
        }
    }
}
