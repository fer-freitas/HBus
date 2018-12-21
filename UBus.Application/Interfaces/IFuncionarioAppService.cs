using System;
using System.Collections.Generic;
using UBus.Application.ViewModels;

namespace UBus.Application.Interfaces
{
    public interface IFuncionarioAppService : IDisposable
    {
        void Register(FuncionarioViewModel funcionarioViewModel);
        IEnumerable<FuncionarioViewModel> ObterTodos();
        FuncionarioViewModel ObterPorId(Guid id);
        void Atualizar(FuncionarioViewModel funcionarioViewModel);
        void Excluir(Guid id);
    }
}
