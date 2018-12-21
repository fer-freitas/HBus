using System;
using System.Collections.Generic;
using UBus.Domain.Models;

namespace UBus.Domain.Interfaces
{
    public interface IFuncionarioRepository : IRepository<Funcionario>
    {
        IEnumerable<Funcionario> ObterTodosPorRota(Guid rotaId);
    }
}
