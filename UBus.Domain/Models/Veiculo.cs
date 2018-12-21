using System;
using System.Collections.Generic;
using UBus.Domain.Shared;

namespace UBus.Domain.Models
{
    public class Veiculo : Entity
    {
        public Veiculo(Guid id, string marca, string modelo, IEnumerable<ItemAdicional> itemAdicional)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            ItemAdicional = itemAdicional;
        }

        // Empty constructor for EF
        protected Veiculo() {
            ItemAdicional = new List<ItemAdicional>();
        }

        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public virtual IEnumerable<ItemAdicional> ItemAdicional {get; private set;}

        public void InserirItemAdicional(IEnumerable<ItemAdicional> itensAdicionais)
        {
            ItemAdicional = itensAdicionais;
        }
    }
}
