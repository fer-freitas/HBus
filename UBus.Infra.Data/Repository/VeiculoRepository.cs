using UBus.Domain.Interfaces;
using UBus.Domain.Models;
using UBus.Infra.Data.Context;

namespace UBus.Infra.Data.Repository
{
    public class VeiculoRepository : Repository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(UBusContext context)
            : base(context)
        {
        }
    }
}