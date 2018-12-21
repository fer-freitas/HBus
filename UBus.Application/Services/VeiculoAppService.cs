using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using UBus.Application.Interfaces;
using UBus.Application.ViewModels;
using UBus.Domain.Interfaces;
using UBus.Domain.Models;

namespace UBus.Application.Services
{
    public class VeiculoAppService : IVeiculoAppService
    {
        private readonly IMapper _mapper;
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IViagemRepository _viagemRepository;
        private readonly IItemAdicionalRepository _itemAdicionalRepository;

        public VeiculoAppService(IMapper mapper,
                                  IVeiculoRepository veiculoRepository,
                                  IViagemRepository viagemRepository,
                                  IItemAdicionalRepository itemAdicionalRepository)
        {
            _mapper = mapper;
            _veiculoRepository = veiculoRepository;
            _viagemRepository = viagemRepository;
            _itemAdicionalRepository = itemAdicionalRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<VeiculoViewModel> ObterTodos()
        {
            return _veiculoRepository.ObterTodos().ProjectTo<VeiculoViewModel>();
        }

        public IEnumerable<VeiculoViewModel> ObterPorAtivoIgualAVerdadeiro()
        {
            throw new NotImplementedException();
        }

        public VeiculoViewModel ObterPorId(Guid id)
        {
            return _mapper.Map<VeiculoViewModel>(_veiculoRepository.ObterPorId(id));
        }

        public void Register(VeiculoViewModel veiculoViewModel)
        {
            _veiculoRepository.Add(_mapper.Map<Veiculo>(veiculoViewModel));
        }

        public void Excluir(Guid id)
        {
            _veiculoRepository.Excluir(id);
        }

        public void Atualizar(VeiculoViewModel veiculoViewModel)
        {
            _veiculoRepository.Atualizar(_mapper.Map<Veiculo>(veiculoViewModel));
        }

        public IEnumerable<VeiculoViewModel> ObterItensAdicionaisPorRota(Guid rotaId)
        {
            var viagens = _viagemRepository.ObterPorRota(rotaId).ToList();
            var veiculosId = viagens.Select(x => x.VeiculoId);
            var veiculos = _veiculoRepository.ObterTodos().Where(x => veiculosId.Contains(x.Id)).ToList();

            foreach (var veiculo in veiculos)
            {
                veiculo.InserirItemAdicional(_itemAdicionalRepository.ObterPorVeiculo(veiculo.Id));
            }

            return _mapper.Map<IEnumerable<VeiculoViewModel>>(veiculos);
        }
    }
}
