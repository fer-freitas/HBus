using System;
using System.Collections.Generic;
using UBus.Application.ViewModels;

namespace UBus.Application.Interfaces
{
    public interface IItinerarioAppService : IDisposable
    {
        void Register(ItinerarioViewModel itinerarioViewModel);
        IEnumerable<ItinerarioViewModel> ObterTodos();
        ItinerarioViewModel ObterPorId(Guid id);
        void Atualizar(ItinerarioViewModel itinerarioViewModel);
        void Excluir(Guid id);
    }
}
