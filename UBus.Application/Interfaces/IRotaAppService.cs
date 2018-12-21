using System;
using System.Collections.Generic;
using System.Text;
using UBus.Application.ViewModels;

namespace UBus.Application.Interfaces
{
    public interface IRotaAppService : IDisposable
    {
        void Register(RotaViewModel rotaViewModel);
        IEnumerable<RotaViewModel> ObterTodos();
        RotaViewModel ObterPorId(Guid id);
        void Atualizar(RotaViewModel rotaViewModel);
        void Excluir(Guid id);
    }
}
