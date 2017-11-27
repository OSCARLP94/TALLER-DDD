using Application.Abstracts;
using Application.Base;
using Domain;
using Domain.Abstracts;
using Domain.Business;
using Domain.Entities;
using Infraestructure.Data;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data;
using System;

namespace Application.Implements
{   
    public class SesionCatadoService : EntityService<SesionCatado>, ISesionCatadoService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly ISesionCatadoRepository _sesionCatadoRepository;
        SesionCatadoBll sesionCatadoBll = new SesionCatadoBll();
        public SesionCatadoService(IUnitOfWork unitOfWork, ISesionCatadoRepository sesionCatadoRepository)
            : base(unitOfWork, sesionCatadoRepository)
        {
            _unitOfWork = unitOfWork;
            _sesionCatadoRepository = sesionCatadoRepository;
           
        }

        public override bool Create(SesionCatado entity)
        {
            //Validaciones...
            Random rnd = new Random();
            entity.Id = Convert.ToString(rnd.Next(10000, 99999));
            if (sesionCatadoBll.ValidateCreate(entity).StartsWith("Ok"))
            {
                MuestraFactoryPrototype muestraPrototype = new MuestraFactoryPrototype();
                muestraPrototype.Estado = "Incompleto";
                muestraPrototype.Especie = entity.Protocolo;
                muestraPrototype.IdSesionCatado = entity.Id;

                for (int i = 1; i <= entity.CantidadMuestras; i++)
                {
                    Muestra muestraClone = muestraPrototype.Clone() as Muestra;
                    muestraClone.Id = Convert.ToString(rnd.Next(10000, 99999));
                    muestraClone.Identificador = i;

                    ArabicaFactoryPrototype arabicaPrototype = new ArabicaFactoryPrototype();
                    arabicaPrototype.Muestra = muestraClone;
                    //-----
                    Arabica arabica = arabicaPrototype.Clone() as Arabica;
                    arabica.Id = Convert.ToString(rnd.Next(1000000, 9999999));

                    entity.Muestras.Add(muestraClone);

                }
                _sesionCatadoRepository.Add(entity);
                _unitOfWork.Commit();

            }
            else
            {
                return false;
            }
           
            return true;
        }
    
        public bool Update(SesionCatado entity)
        {
            CataneiContext context = new CataneiContext();
            SesionCatado current = _sesionCatadoRepository.Find(entity.Id);
            if (sesionCatadoBll.ValidateUpdate(current,entity).StartsWith("Ok"))
            {
                try
                {
                    _sesionCatadoRepository.Edit(entity);
                    _unitOfWork.Commit();
                    if (current.Identificador != entity.Identificador)
                    {
                        MuestraService muestra = new MuestraService(new UnitOfWork(context), new MuestraRepository(context));
                        if (!muestra.UpdateMuestras(entity.Id, entity.Identificador)) //actualiza todas
                        {
                            return false;
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    return false;
                }
               
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool Delete(string idSesion, string idUser)
        {
           var entity= _sesionCatadoRepository.Find(idSesion);
            if (sesionCatadoBll.ValidateDelete(entity, idUser).StartsWith("Ok"))
            {
                try
                {
                    _sesionCatadoRepository.Delete(entity);
                    _unitOfWork.Commit();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
