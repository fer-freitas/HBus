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
    public class ViagemAppService : IViagemAppService
    {
        private readonly IMapper _mapper;
        private readonly IViagemRepository _viagemRepository;

        public ViagemAppService(IMapper mapper,
                                  IViagemRepository viagemRepository)
        {
            _mapper = mapper;
            _viagemRepository = viagemRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<ViagemViewModel> ObterTodos()
        {
            return _viagemRepository.ObterTodos().ProjectTo<ViagemViewModel>();
        }

        public ViagemViewModel ObterPorId(Guid id)
        {
            return _mapper.Map<ViagemViewModel>(_viagemRepository.ObterPorId(id));
        }

        public void Register(ViagemViewModel viagemViewModel)
        {
            _viagemRepository.Add(_mapper.Map<Viagem>(viagemViewModel));
        }

        public void Excluir(Guid id)
        {
            _viagemRepository.Excluir(id);
        }

        public void Atualizar(ViagemViewModel viagemViewModel)
        {
            _viagemRepository.Atualizar(_mapper.Map<Viagem>(viagemViewModel));
        }
    }
}
