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
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MuestraForm : Form
    {
        CataneiContext context;
        MuestraService service;
        public MuestraForm()
        {
            context = new CataneiContext();
            service = new MuestraService(new UnitOfWork(context), new MuestraRepository(context));
            InitializeComponent();
        }

        private void MuestraForm_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = service.GetAll().ToList();
        }
    }
}
