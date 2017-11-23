using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public interface IformSesion
    {
        void LoadDataGridView(); //cargar los datos 
        void Create(SesionCatado sesionCatado);
    }
}
