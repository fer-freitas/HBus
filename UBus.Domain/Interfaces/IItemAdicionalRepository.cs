using System;
using System.Collections.Generic;
using UBus.Domain.Models;

namespace UBus.Domain.Interfaces
{
    public interface IItemAdicionalRepository : IRepository<ItemAdicional>
    {
        IEnumerable<ItemAdicional> ObterPorVeiculo(Guid veiculoId);
    }
}
