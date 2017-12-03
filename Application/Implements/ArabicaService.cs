using Application.Abstracts;
using Application.Base;
using Domain.Abstracts;
using Domain.Business;
using Domain.Entities;
using System;

namespace Application.Implements
{
    public class ArabicaService : EntityService<Arabica>, IArabicaService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IArabicaRepository _arabicaRepository;
        ArabicaBll arabicaBll = new ArabicaBll();
        public ArabicaService(IUnitOfWork unitOfWork, IArabicaRepository arabicaRepository)
            : base(unitOfWork, arabicaRepository)
        {
            _unitOfWork = unitOfWork;
            _arabicaRepository = arabicaRepository;
        }

        public string Create(string idMuestra)
        {
            Random rnd = new Random();
            //------Preparamos el clon
            ArabicaFactoryPrototype arabicaPrototype = new ArabicaFactoryPrototype();
            arabicaPrototype.IdMuestra = idMuestra;
            //-----

            Arabica entity = arabicaPrototype.CloneArabica();  
            entity.Id = Convert.ToString(rnd.Next(1000000, 9999999));
            try
            {
                _arabicaRepository.Add(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                return "Error. " + ex.ToString();
            }

            return "Ok";
        }

        public bool Edit(Arabica entity)
        {
            entity.Calificacion = arabicaBll.CalculaPuntaje(entity);
            try
            {
                _arabicaRepository.Edit(entity);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
