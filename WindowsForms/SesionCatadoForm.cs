using Application.Implements;
using Domain.Entities;
using Infraestructure.Data;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class SesionCatadoForm : Form, IformSesion
    {
        CataneiContext context;
        SesionCatadoService service;
        string idSesion;
        public SesionCatadoForm()
        {
            context = new CataneiContext();
            service = new SesionCatadoService(new UnitOfWork(context), new SesionCatadoRepository(context));
            InitializeComponent();
        }

        public void Create(SesionCatado sesionCatado)
        {
            service.Create(sesionCatado);
            dataGridView1.DataSource = service.GetAll().ToList();
        }

        public void LoadDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = service.GetAll().ToList();
        }

        private void SesionCatadoForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewSesion frm = new NewSesion();
            frm.Show(this);
        }

        private void btnMuestra_Click(object sender, EventArgs e)
        {
            MuestraForm frm = new MuestraForm();
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSesion!="")
            {
                service.Delete(idSesion, "201"); //Por decir algo
                LoadDataGridView();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idSesion = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }
    }
}
