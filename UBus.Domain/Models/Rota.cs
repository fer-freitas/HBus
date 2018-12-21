using System;
using System.Collections.Generic;
using UBus.Domain.Shared;

namespace UBus.Domain.Models
{
    public class Rota:Entity
    {
        public Rota(Guid id, string origem, string destino, DateTime inicio, DateTime fim, decimal valor, IEnumerable<Itinerario> itinerarios)
        {
            Id = id;
            Origem = origem;
            Destino = destino;
            Inicio = inicio;
            Fim = fim;
            Valor = valor;
            Itinerarios = itinerarios;
        }

        // Empty constructor for EF
        protected Rota()
        {
        }

        public string Origem { get; private set; }
        public string Destino { get; private set; }
        public DateTime Inicio { get; private set; }
        public DateTime Fim { get; private set; }
        public decimal Valor { get; private set; }
        public virtual IEnumerable<Itinerario> Itinerarios { get; private set; }

    }
}
