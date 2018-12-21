using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using UBus.Application.Interfaces;
using UBus.Application.ViewModels;
using UBus.Domain.Interfaces;
using UBus.Domain.Models;

namespace UBus.Application.Services
{
    public class ItinerarioAppService : IItinerarioAppService
    {
        private readonly IMapper _mapper;
        private readonly IItinerarioRepository _itinerarioRepository;

        public ItinerarioAppService(IMapper mapper,
                                  IItinerarioRepository itinerarioRepository)
        {
            _mapper = mapper;
            _itinerarioRepository = itinerarioRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<ItinerarioViewModel> ObterTodos()
        {
            return _itinerarioRepository.ObterTodos().ProjectTo<ItinerarioViewModel>();
        }

        public ItinerarioViewModel ObterPorId(Guid id)
        {
            return _mapper.Map<ItinerarioViewModel>(_itinerarioRepository.ObterPorId(id));
        }

        public void Register(ItinerarioViewModel itinerarioViewModel)
        {
            _itinerarioRepository.Add(_mapper.Map<Itinerario>(itinerarioViewModel));
        }

        public void Excluir(Guid id)
        {
            _itinerarioRepository.Excluir(id);
        }

        public void Atualizar(ItinerarioViewModel itinerarioViewModel)
        {
            _itinerarioRepository.Atualizar(_mapper.Map<Itinerario>(itinerarioViewModel));
        }
    }
}
