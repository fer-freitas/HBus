using System;
using System.Collections.Generic;
using UBus.Application.ViewModels;

namespace UBus.Application.Interfaces
{
    public interface IVeiculoAppService : IDisposable
    {
        void Register(VeiculoViewModel veiculoViewModel);
        IEnumerable<VeiculoViewModel> ObterTodos();
        IEnumerable<VeiculoViewModel> ObterItensAdicionaisPorRota(Guid rotaId);
        IEnumerable<VeiculoViewModel> ObterPorAtivoIgualAVerdadeiro();
        VeiculoViewModel ObterPorId(Guid id);
        void Atualizar(VeiculoViewModel veiculoViewModel);
        void Excluir(Guid id);
    }
}
