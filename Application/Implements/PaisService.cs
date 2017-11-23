using Application.Abstracts;
using Application.Base;
using Domain.Abstracts;
using Domain.Entities;

namespace Application.Implements
{
    public class PaisService: EntityService<Pais>, IPaisService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IPaisRepository _paisRepository;

        public PaisService(IUnitOfWork unitOfWork, IPaisRepository paisRepository)
            : base(unitOfWork, paisRepository)
        {
            _unitOfWork = unitOfWork;
            _paisRepository = paisRepository;
        }
    }
}
