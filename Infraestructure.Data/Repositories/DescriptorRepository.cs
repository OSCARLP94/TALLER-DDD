using Domain.Abstracts;
using Domain.Entities;
using Infraestructura.Data.Base;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data.Base;

namespace Infraestructure.Data.Repositories
{
    public class DescriptorRepository : GenericRepository<Descriptor>, IDescriptorRepository
    {
        public DescriptorRepository(IDbContext context)
              : base(context)
        {

        }

    }
}
