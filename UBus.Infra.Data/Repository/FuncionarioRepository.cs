using System;
using System.Collections.Generic;
using System.Linq;
using UBus.Domain.Interfaces;
using UBus.Domain.Models;
using UBus.Infra.Data.Context;

namespace UBus.Infra.Data.Repository
{
    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(UBusContext context)
            : base(context)
        {

        }

        public IEnumerable<Funcionario> ObterTodosPorRota(Guid rotaId)
        {
            var viagens = Db.Viagens.Where(x => x.RotaId == rotaId).ToList();
            return Db.Funcionarios.Where(r => viagens.Any(f => f.FuncionarioId == r.Id));
        }
    }
}