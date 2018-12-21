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
    public class RotaAppService : IRotaAppService
    {
        private readonly IMapper _mapper;
        private readonly IRotaRepository _rotaRepository;

        public RotaAppService(IMapper mapper,
                                  IRotaRepository rotaRepository)
        {
            _mapper = mapper;
            _rotaRepository = rotaRepository;
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<RotaViewModel> ObterTodos()
        {
            return _rotaRepository.ObterTodos().ProjectTo<RotaViewModel>();
        }

        public RotaViewModel ObterPorId(Guid id)
        {
            return _mapper.Map<RotaViewModel>(_rotaRepository.ObterPorId(id));
        }

        public void Register(RotaViewModel rotaViewModel)
        {
            _rotaRepository.Add(_mapper.Map<Rota>(rotaViewModel));
        }

        public void Excluir(Guid id)
        {
            _rotaRepository.Excluir(id);
        }

        public void Atualizar(RotaViewModel rotaViewModel)
        {
            _rotaRepository.Atualizar(_mapper.Map<Rota>(rotaViewModel));
        }
    }
}
