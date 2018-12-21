using System;
using UBus.Domain.Shared;

namespace UBus.Domain.Models
{
    public class Funcionario:Entity
    {
        public Funcionario(Guid id, string primeiroNome, string ultimoNome, bool ativo)
        {
            Id = id;
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Ativo = ativo;
        }

        // Empty constructor for EF
        protected Funcionario()
        {
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public bool Ativo { get; private set; }
    }
}
