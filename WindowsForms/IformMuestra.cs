using Domain.Entities;
using System;
using System.Collections.Generic;

namespace WindowsForms
{
    public interface IformMuestra
    {
        void LoadDataGridView(); //cargar los datos 
        void Edit(Muestra muestra);
    }
}
