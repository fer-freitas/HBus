using UBus.Domain.Interfaces;
using UBus.Domain.Models;
using UBus.Infra.Data.Context;

namespace UBus.Infra.Data.Repository
{
    public class RotaRepository : Repository<Rota>, IRotaRepository
    {
        public RotaRepository(UBusContext context)
            : base(context)
        {

        }
    }
}
