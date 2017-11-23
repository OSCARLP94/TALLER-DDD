using Application.Abstracts;
using Application.Base;
using Domain.Abstracts;
using Domain.Entities;

namespace Application.Implements
{
    public class DescriptorService : EntityService<Descriptor>, IDescriptorService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IDescriptorRepository _descriptorRepository;

        public DescriptorService(IUnitOfWork unitOfWork, IDescriptorRepository descriptorRepository)
            : base(unitOfWork, descriptorRepository)
        {
            _unitOfWork = unitOfWork;
            _descriptorRepository = descriptorRepository;
        }
    }
}
