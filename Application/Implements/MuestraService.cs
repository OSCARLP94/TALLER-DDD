using Application.Abstracts;
using Application.Base;
using Domain.Abstracts;
using Domain.Entities;
using Infraestructure.Data;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data;
using System;
using System.Linq;

namespace Application.Implements
{
    public class MuestraService : EntityService<Muestra>, IMuestraService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMuestraRepository _muestraRepository;
     
        public MuestraService(IUnitOfWork unitOfWork, IMuestraRepository muestraRepository)
            : base(unitOfWork, muestraRepository)
        {
            _unitOfWork = unitOfWork;
            _muestraRepository = muestraRepository;
        }

        public string CreateForSesion(Muestra entity, string identificador, int valor)
        {
           
            string respuesta;
            CataneiContext context = new CataneiContext();
            try
            {
                _muestraRepository.Add(entity);
                _unitOfWork.Commit();
                //instanciamos arabica
                ArabicaService arabica = new ArabicaService(new UnitOfWork(context), new ArabicaRepository(context));
                respuesta = arabica.Create(entity.Id);

                if (respuesta.StartsWith("Error"))
                {
                     return respuesta;
                }
                
            }
            catch (Exception ex)
            {
                return "Error. " + ex.ToString();
            }

            return "Ok";
        }

        public bool Update(Muestra entity)
        {
            Muestra current = _muestraRepository.Find(entity.Id);
            try
            {
                current.Nombre = entity.Nombre;
                current.Descripcion = entity.Descripcion;
                current.Humedad = entity.Humedad;
                current.Region = entity.Region;
                current.AnioCosecha = entity.AnioCosecha;
                _muestraRepository.Edit(current);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool UpdateMuestras(string idSesion, string identificador)
        {
            //obtener las muestras de la sesion
            var muestras = _muestraRepository.GetAll().ToList().Where(p => p.IdSesionCatado == idSesion).OrderBy(p => p.Identificador);
            int i = 1;
            //foreach (var entity in muestras)
            //{
            //    if (identificador != "Letras") //Generar digitos
            //    {
            //        entity.Identificador = i.ToString();
            //    }
            //    else //Generar letras
            //    {
            //        entity.Identificador = Convert.ToChar(64 + i).ToString();
            //    }

            //    //guardamos el cambio
            //    try
            //    {
            //        _muestraRepository.Edit(entity);
            //        _unitOfWork.Commit();
            //    }
            //    catch (Exception ex)
            //    {
            //        return false;
            //    }
            //    i++;
            //}
            return true;
        }

    }


}
