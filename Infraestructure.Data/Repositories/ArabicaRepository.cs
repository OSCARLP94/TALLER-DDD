using Domain.Abstracts;
using Domain.Entities;
using Infraestructura.Data.Base;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data.Base;

namespace Infraestructure.Data.Repositories
{
    public class ArabicaRepository : GenericRepository<Arabica>, IArabicaRepository
    {
        public ArabicaRepository(IDbContext context)
              : base(context)
        {

        }

    }
}
