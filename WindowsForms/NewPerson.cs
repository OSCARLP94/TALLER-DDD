using Application.Abstracts;
using Application.Implements;
using Domain.Entities;
using Infraestructure.Data;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class NewPerson : Form
    {
        public NewPerson()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person entity = new Person();
            entity.Cedula = txtCedula.Text;
            entity.Nombre = txtNombre.Text;
            entity.Apellido = txtApellido.Text;
            entity.Rol = "Asociado";
            if (rbCatador.Checked)
            {
                entity.Rol = "Catador";
                entity.Nick = txtNick.Text;
                entity.Clave = txtClave.Text;
            }
            IformPerson form= this.Owner as IformPerson;
            if (form != null)
                form.Create(entity);
        }

     
        private void NewPerson_Load(object sender, EventArgs e)
        {
            
        }
    }
}
