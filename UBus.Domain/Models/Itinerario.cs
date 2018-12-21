using System;
using UBus.Domain.Shared;

namespace UBus.Domain.Models
{
    public class Itinerario:Entity
    {
        // Empty constructor for EF
        protected Itinerario(Guid id, string local, string hora, Guid rotaId)
        {
            Id = id;
            Local = local;
            Hora = hora;
            RotaId = rotaId;
        }

        public string Local { get; private set; }
        public string Hora { get; private set; }
        public Guid RotaId { get; private set; }
        public virtual Rota Rota { get; private set; }
    }
}
