using Application.Abstracts;
using Application.Base;
using Domain.Abstracts;
using Domain.Entities;

namespace Application.Implements
{
    public class VeredaService : EntityService<Vereda>, IVeredaService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IVeredaRepository _veredaRepository;

        public VeredaService(IUnitOfWork unitOfWork, IVeredaRepository veredaRepository)
            : base(unitOfWork, veredaRepository)
        {
            _unitOfWork = unitOfWork;
            _veredaRepository = veredaRepository;
        }
    }
}
