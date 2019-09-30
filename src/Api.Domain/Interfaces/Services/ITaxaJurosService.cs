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
        /// Retorna a taxa atual de atualização mensal de valores
        /// </summary>
        /// <returns></returns>
        Task<double> Get();

    }
}
