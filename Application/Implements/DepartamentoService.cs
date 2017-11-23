using Application.Abstracts;
using Application.Base;
using Domain.Abstracts;
using Domain.Entities;

namespace Application.Implements
{
    public class DepartamentoService: EntityService<Departamento>, IDepartamentoService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoService(IUnitOfWork unitOfWork, IDepartamentoRepository departamentoRepository)
            : base(unitOfWork, departamentoRepository)
        {
            _unitOfWork = unitOfWork;
            _departamentoRepository = departamentoRepository;
        }
    }
}
