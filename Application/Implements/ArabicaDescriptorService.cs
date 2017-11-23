using Application.Abstracts;
using Application.Base;
using Domain.Abstracts;
using Domain.Entities;

namespace Application.Implements
{
    public class ArabicaDescriptorService : EntityService<ArabicaDescriptor>, IArabicaDescriptorService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IArabicaDescriptorRepository _arabicaDescriptorRepository;

        public ArabicaDescriptorService(IUnitOfWork unitOfWork, IArabicaDescriptorRepository arabicaDescriptorRepository)
            : base(unitOfWork, arabicaDescriptorRepository)
        {
            _unitOfWork = unitOfWork;
            _arabicaDescriptorRepository = arabicaDescriptorRepository;
        }
    }
}
