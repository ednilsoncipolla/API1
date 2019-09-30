using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ITaxaJurosService
    {
        /// <summary>
        /// Busca taxa de atualização mensal de valores
        /// </summary>
        /// <returns>Indice para atualização de valores</returns>
        Task<double> Get();

    }
}
