using System;
using UBus.Domain.Shared;

namespace UBus.Domain.Models
{
    public class Viagem:Entity
    {
        public Viagem(Guid id, string latitude, string longitude, DateTime dataAtualizacao, 
            DateTime dataConclusao, string status,
            Guid rotaId, Guid funcionarioId, Guid veiculoId)
        {
            Id = id;
            Latitude = latitude;
            Longitude = longitude;
            DataAtualizacao = dataAtualizacao;
            DataConclusao = dataConclusao;
            Status = status;
            RotaId = rotaId;
            VeiculoId = veiculoId;
        }

        protected Viagem()
        {
        }

        public void MudarFuncionario(Guid funcionarioId)
        {
            FuncionarioId = funcionarioId;
        }

        public string Latitude { get; private set; }
        public string Longitude { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
        public DateTime? DataConclusao { get; private set; }
        public string Status { get; private set; }
        public Guid RotaId { get; private set; }
        public Guid VeiculoId { get; private set; }
        public Guid FuncionarioId { get; private set; }
    }
}
