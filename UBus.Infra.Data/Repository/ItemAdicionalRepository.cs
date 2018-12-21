using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using UBus.Domain.Interfaces;
using UBus.Domain.Models;
using UBus.Infra.Data.Context;

namespace UBus.Infra.Data.Repository
{
    public class ItemAdicionalRepository : Repository<ItemAdicional>, IItemAdicionalRepository
    {
        public ItemAdicionalRepository(UBusContext context)
            : base(context)
        {

        }

        public IEnumerable<ItemAdicional> ObterPorVeiculo(Guid veiculoId)
        {
            return DbSet.AsNoTracking().Where(x => x.VeiculoId == veiculoId);
        }
    }
}
