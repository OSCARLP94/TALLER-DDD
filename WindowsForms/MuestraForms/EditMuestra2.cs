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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.MuestraForms
{
    public partial class EditMuestra2 : Form
    {
        CataneiContext context;
        PersonService serviceProductor;
        CiudadService serviceCiudad;
        MuestraService serviceMuestra;
        List<Person> productores;
        List<Ciudad> ciudades;
        Muestra muestra;
        string idMuestra;

        public EditMuestra2(string id)
        {
            idMuestra = id;
            context = new CataneiContext();
            serviceProductor = new PersonService(new UnitOfWork(context), new PersonRepository(context));
            serviceCiudad = new CiudadService(new UnitOfWork(context), new CiudadRepository(context));
            serviceMuestra = new MuestraService(new UnitOfWork(context), new MuestraRepository(context));
            InitializeComponent();
        }

        private void EditMuestra2_Load(object sender, EventArgs e)
        {
            productores = serviceProductor.GetAll().Where(m=>m.Rol== "Asociado" || m.Rol== "Particular").ToList();
            foreach (var productor in productores)
            {               
                comboProductor.Items.Add(productor.Nombre +" "+ productor.Apellido);
            }

            ciudades = serviceCiudad.GetAll().ToList();
            foreach (var ciudad in ciudades)
            {
                 comboRegion.Items.Add(ciudad.Nombre);
            }

            muestra = serviceMuestra.GetAll().SingleOrDefault(m => m.Id == idMuestra);
            txtNombre.Text = muestra.Nombre;
            var index = comboAnio.FindStringExact(muestra.AnioCosecha);
            if(index != -1)
            {
                comboAnio.SelectedIndex = index;
            }
            index = comboRegion.FindStringExact(muestra.Region);
            if (index != -1)
            {
                comboAnio.SelectedIndex = index;
            }
            //index = comboProductor.FindStringExact(muestra.Region);
            //if (index != -1)
            //{
            //    comboAnio.SelectedIndex = index;
            //}

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            muestra.Nombre = txtNombre.Text;
            muestra.Descripcion = richTextBox1.Text;
            muestra.Humedad = Convert.ToInt16(numericUpDown1.Value);
            muestra.Region = (comboRegion.SelectedItem != null) ? comboRegion.SelectedItem.ToString(): null;
            muestra.AnioCosecha = (comboAnio.SelectedItem != null) ? comboAnio.SelectedItem.ToString() : null; 

            IformMuestra form = this.Owner as IformMuestra;
            if (form != null)
                form.Edit(muestra);
        }
    }
}
