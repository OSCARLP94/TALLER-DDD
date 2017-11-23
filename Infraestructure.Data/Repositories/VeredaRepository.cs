using Domain.Abstracts;
using Domain.Entities;
using Infraestructura.Data.Base;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data.Base;

namespace Infraestructure.Data.Repositories
{
    public class VeredaRepository : GenericRepository<Vereda>, IVeredaRepository
    {
        public VeredaRepository(IDbContext context)
              : base(context)
        {

        }

    }
}
