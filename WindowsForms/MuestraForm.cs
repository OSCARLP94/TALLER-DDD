using Application.Implements;
using Infraestructure.Data;
using Domain.Entities;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsForms.MuestraForms;
using WindowsForms.ArabicaForms;

namespace WindowsForms
{
    public partial class MuestraForm : Form, IformMuestra
    {
        CataneiContext context;
        MuestraService service;
        string idMuestra, idSesion;

        public MuestraForm(string id)
        {
            idSesion = id;
            context = new CataneiContext();
            service = new MuestraService(new UnitOfWork(context), new MuestraRepository(context));
            InitializeComponent();
        }

        private void MuestraForm_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = service.GetAll().Where(m=>m.IdSesionCatado== idSesion).ToList();
        }

        public void Edit(Muestra muestra)
        {
            service.Update(muestra);
            dataGridView.DataSource = service.GetAll().Where(m => m.IdSesionCatado == idSesion).ToList();
           
        }

        public void LoadDataGridView()
        {
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = service.GetAll().ToList();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            idMuestra= dataGridView.CurrentRow.Cells["Id"].FormattedValue.ToString();
            EditMuestra2 frm = new EditMuestra2(idMuestra);
            frm.Show(this);
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            idMuestra = dataGridView.CurrentRow.Cells["Id"].FormattedValue.ToString();
            Calificar2 frm = new Calificar2(idMuestra);
            frm.Show(this);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idMuestra = dataGridView.Rows[e.RowIndex].Cells[13].Value.ToString();
        }
    }
}
