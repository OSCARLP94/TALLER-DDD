using Application.Abstracts;
using Domain.Entities;
using System;

namespace WindowsForms
{
    public interface IformPerson
    {
        void LoadDataGridView(); //cargar los datos 
        void Create(Person person);
    }
}
