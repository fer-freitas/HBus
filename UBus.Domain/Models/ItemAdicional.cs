using System;
using UBus.Domain.Shared;

namespace UBus.Domain.Models
{
    public class ItemAdicional:Entity
    {
        public ItemAdicional(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        // Empty constructor for EF
        protected ItemAdicional() { }

        public string Nome { get; private set; }

        public Guid VeiculoId { get; private set; }
        public virtual Veiculo Veiculo { get; private set; }
    }
}
