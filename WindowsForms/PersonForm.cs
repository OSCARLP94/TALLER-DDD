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

namespace WindowsForms
{
    public partial class PersonForm : Form, IformPerson
    {
        CataneiContext context;
        PersonService service;
        public PersonForm()
        {
          context= new CataneiContext(); 
            service = new PersonService(new UnitOfWork(context), new PersonRepository(context));
            InitializeComponent();
        }

        private void Person_Load(object sender, EventArgs e)
        {        
            LoadDataGridView();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewPerson frm = new NewPerson();
            frm.Show(this);
        }

        public void Create(Person person)
        {
            service.Create(person);
            dataGridView.DataSource = service.GetAll().ToList();
        }

        public void LoadDataGridView()
        {
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = service.GetAll().ToList();
        }
    }
}
