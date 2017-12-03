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

namespace WindowsForms.ArabicaForms
{
    public partial class Calificar2 : Form
    {
        CataneiContext context;
        ArabicaService service;
        Arabica arabica;
        string idMuestra;
        public Calificar2(string id)
        {
            idMuestra = id;
            context = new CataneiContext();
            service = new ArabicaService(new UnitOfWork(context), new ArabicaRepository(context));
            InitializeComponent();
        }

        private void Calificar2_Load(object sender, EventArgs e)
        {
            arabica = service.GetAll().SingleOrDefault(m=>m.IdMuestra== idMuestra);
        }
    }
}
