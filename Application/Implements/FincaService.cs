using Application.Abstracts;
using Application.Base;
using Domain.Abstracts;
using Domain.Entities;

namespace Application.Implements
{
    public class FincaService : EntityService<Finca>, IFincaService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IFincaRepository _fincaRepository;

        public FincaService(IUnitOfWork unitOfWork, IFincaRepository fincaRepository)
            : base(unitOfWork, fincaRepository)
        {
            _unitOfWork = unitOfWork;
            _fincaRepository = fincaRepository;
        }
    }
}
