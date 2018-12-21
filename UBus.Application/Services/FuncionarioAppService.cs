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
    public class FuncionarioAppService : IFuncionarioAppService
    {
        private readonly IMapper _mapper;
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioAppService(IMapper mapper,
                              IFuncionarioRepository funcionarioRepository)
        {
            _mapper = mapper;
            _funcionarioRepository = funcionarioRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<FuncionarioViewModel> ObterTodos()
        {
            return _funcionarioRepository.ObterTodos().ProjectTo<FuncionarioViewModel>();
        }

        public FuncionarioViewModel ObterPorId(Guid id)
        {
            return _mapper.Map<FuncionarioViewModel>(_funcionarioRepository.ObterPorId(id));
        }

        public void Register(FuncionarioViewModel funcionarioViewModel)
        {
            _funcionarioRepository.Add(_mapper.Map<Funcionario>(funcionarioViewModel));
        }

        public void Excluir(Guid id)
        {
            _funcionarioRepository.Excluir(id);
        }

        public void Atualizar(FuncionarioViewModel funcionarioViewModel)
        {
            _funcionarioRepository.Atualizar(_mapper.Map<Funcionario>(funcionarioViewModel));
        }

    }
}
