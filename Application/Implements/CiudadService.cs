using Application.Abstracts;
using Application.Base;
using Domain.Abstracts;
using Domain.Entities;

namespace Application.Implements
{
    public class CiudadService : EntityService<Ciudad>, ICiudadService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly ICiudadRepository _ciudadRepository;

        public CiudadService(IUnitOfWork unitOfWork, ICiudadRepository ciudadRepository)
            : base(unitOfWork, ciudadRepository)
        {
            _unitOfWork = unitOfWork;
            _ciudadRepository = ciudadRepository;
        }
    }
}
