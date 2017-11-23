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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            PersonForm frm = new PersonForm();
            frm.Show();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            SesionCatadoForm frm = new SesionCatadoForm();
            frm.Show();
        }
    }
}
