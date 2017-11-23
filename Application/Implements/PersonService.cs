using Application.Abstracts;
using Application.Base;
using System.Linq;
using Domain.Abstracts;
using Domain.Entities;
using System.Collections.Generic;
using Domain.Business;
using System;

namespace Application.Implements
{
    public class PersonService : EntityService<Person>, IPersonService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IPersonRepository _personRepository;
        PersonaBll personBll = new PersonaBll();
        public PersonService(IUnitOfWork unitOfWork, IPersonRepository personRepository)
            : base(unitOfWork, personRepository)
        {
            _unitOfWork = unitOfWork;
            _personRepository = personRepository;
        }

        public bool Create(Person entity)
        {
            Random rnd = new Random();
            entity.Id = Convert.ToString(rnd.Next(10000, 99999));

            var personas= _personRepository.GetAll().ToList().SkipWhile(s => s.Id == entity.Id); //Evita a si mismo
            if (entity.Rol == "Catador")
            {
                if (personBll.ValidateCatador(entity).StartsWith("Error"))
                {
                    return false;
                }
            }
           
            if (personBll.ValidatePersona(entity, personas).StartsWith("Error"))
            {
                return false;
            }

            try
            {
                _personRepository.Add(entity);
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
