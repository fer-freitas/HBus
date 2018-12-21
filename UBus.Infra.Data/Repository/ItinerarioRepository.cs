using UBus.Domain.Interfaces;
using UBus.Domain.Models;
using UBus.Infra.Data.Context;

namespace UBus.Infra.Data.Repository
{
    public class ItinerarioRepository : Repository<Itinerario>, IItinerarioRepository
    {
        public ItinerarioRepository(UBusContext context)
            : base(context)
        {

        }
    }
}
