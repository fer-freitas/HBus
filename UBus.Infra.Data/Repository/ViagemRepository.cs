using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using UBus.Domain.Interfaces;
using UBus.Domain.Models;
using UBus.Infra.Data.Context;

namespace UBus.Infra.Data.Repository
{
    public class ViagemRepository : Repository<Viagem>, IViagemRepository
    {
        public ViagemRepository(UBusContext context)
            : base(context)
        {

        }

        public void MudarFuncionario(Guid id, Guid funcionarioId)
        {
            var entity = DbSet.Find(id);
            entity.MudarFuncionario(funcionarioId);

            DbSet.Update(entity);
            Db.SaveChanges();
        }

        public IEnumerable<Viagem> ObterPorRota(Guid rotaId)
        {
            return DbSet
                .AsNoTracking()
                .Where(x => x.RotaId == rotaId);
        }

        public IEnumerable<Viagem> ObterTodosToday()
        {
            return DbSet
                .AsNoTracking()
                .Where(x => x.DataAtualizacao == DateTime.Now);
        }
    }
}
