using Application.Implements;
using Domain.Entities;
using Infraestructure.Data;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class NewSesion : Form
    {
        CataneiContext context;
        CiudadService service;
        List<Ciudad> ciudades;
        public NewSesion()
        {
            context = new CataneiContext();
            service = new CiudadService(new UnitOfWork(context), new CiudadRepository(context));
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NewSesion_Load(object sender, EventArgs e)
        {
            ciudades= service.GetAll().ToList();

            foreach (var ciudad in ciudades)
            {
                if (ciudad.Laboratorio)
                {
                    comboLabs.Items.Add(ciudad.Nombre);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboLabs.SelectedItem.ToString()!="")
            {
                SesionCatado entity = new SesionCatado();
                entity.FechaInicio = dateFecha.Value;

                var lab = ciudades.SingleOrDefault(m => m.Nombre == comboLabs.SelectedItem.ToString());
                entity.IdCiudad = lab.Id;
                entity.Protocolo = "Arabica";
                entity.CantidadMuestras = Convert.ToInt16(numMuestras.Value);
                entity.Descripcion = richDescripcion.Text;
                entity.Estado = "Incompleto";
                entity.IdPerson = "201"; //Por decir algo

                entity.Identificador= (rbDigito.Checked) ? "Digitos" : "Letras";
                IformSesion form = this.Owner as IformSesion;
                if (form != null)
                    form.Create(entity);
            }
        }
    }
}
