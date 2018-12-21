using System;
using System.Collections.Generic;
using UBus.Domain.Models;

namespace UBus.Domain.Interfaces
{
    public interface IViagemRepository : IRepository<Viagem>
    {
        IEnumerable<Viagem> ObterTodosToday();
        IEnumerable<Viagem> ObterPorRota(Guid rotaId);

        void MudarFuncionario(Guid id, Guid funcionarioId);
    }
}
