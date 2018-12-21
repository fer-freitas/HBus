using System;
using System.Collections.Generic;
using UBus.Application.ViewModels;

namespace UBus.Application.Interfaces
{
    public interface IViagemAppService : IDisposable
    {
        void Register(ViagemViewModel viagemViewModel);
        IEnumerable<ViagemViewModel> ObterTodos();
        ViagemViewModel ObterPorId(Guid id);
        void Atualizar(ViagemViewModel viagemViewModel);
        void Excluir(Guid id);
    }
}
