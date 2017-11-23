using Application.Abstracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public interface IformPerson
    {
        void LoadDataGridView(); //cargar los datos 
        void Create(Person person);
    }
}
