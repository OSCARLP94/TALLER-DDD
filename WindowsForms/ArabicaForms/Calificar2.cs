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
            lbCalificacion.Text = arabica.Calificacion.ToString();
            var index = comboAcidez.FindStringExact(arabica.TotalAcidez.ToString());
            if (index != -1)
            {
                comboAcidez.SelectedIndex = index;
            }
            index = comboCuerpo.FindStringExact(arabica.TotalCuerpo.ToString());
            if (index != -1)
            {
                comboCuerpo.SelectedIndex = index;
            }
            index = comboFragancia.FindStringExact(arabica.TotalFragancia.ToString());
            if (index != -1)
            {
                comboFragancia.SelectedIndex = index;
            }
            index = comboSabor.FindStringExact(arabica.TotalSabor.ToString());
            if (index != -1)
            {
                comboSabor.SelectedIndex = index;
            }
            index = comboSaborBoca.FindStringExact(arabica.TotalSaborBoca.ToString());
            if (index != -1)
            {
                comboSaborBoca.SelectedIndex = index;
            }
            index = comboBalance.FindStringExact(arabica.TotalBalance.ToString());
            if (index != -1)
            {
                comboBalance.SelectedIndex = index;
            }
            index = comboGeneral.FindStringExact(arabica.TotalGeneral.ToString());
            if (index != -1)
            {
                comboGeneral.SelectedIndex = index;
            }

            switch (arabica.Tueste)
            {
                case 1:
                    rbTueste1.Checked = true;
                    break;
                case 2:
                    rbTueste2.Checked = true;
                    break;
                case 3:
                    rbTueste3.Checked = true;
                    break;
                case 4:
                    rbTueste4.Checked = true;
                    break;
                case 5:
                    rbTueste5.Checked = true;
                    break;
            }

            RadioButtonsFalse();
           
            if (arabica.Dulzor1)
            {
                checkDulzor1.Checked = true;
            }
            if (arabica.Dulzor2)
            {
                checkDulzor2.Checked = true;
            }
            if (arabica.Dulzor3)
            {
                checkDulzor3.Checked = true;
            }
            if (arabica.Dulzor4)
            {
                checkDulzor4.Checked = true;
            }
            if (arabica.Dulzor5)
            {
                checkDulzor5.Checked = true;
            }

            if (arabica.Uniformidad1)
            {
                checkUnifor5.Checked = true;
            }
            if (arabica.Uniformidad2)
            {
                checkUnifor2.Checked = true;
            }
            if (arabica.Uniformidad3)
            {
                checkUnifor3.Checked = true;
            }
            if (arabica.Uniformidad4)
            {
                checkUnifor4.Checked = true;
            }
            if (arabica.Uniformidad5)
            {
                checkUnifor5.Checked = true;
            }

            if (arabica.Taza1)
            {
                checkTaza1.Checked = true;
            }
            if (arabica.Taza2)
            {
                checkTaza2.Checked = true;
            }
            if (arabica.Taza3)
            {
                checkTaza3.Checked = true;
            }
            if (arabica.Taza4)
            {
                checkTaza4.Checked = true;
            }
            if (arabica.Taza5)
            {
                checkTaza5.Checked = true;
            }

            numericUpDown1.Value = arabica.Defectos;
            lbDulzor.Text = Convert.ToString(arabica.TotalDulzor);
            lbTaza.Text = Convert.ToString(arabica.TotalTaza);
            lbUniformidad.Text = Convert.ToString(arabica.TotalUniformidad);
        }

        private void RadioButtonsFalse()
        {
            checkTaza1.Checked = false;
            checkTaza2.Checked = false;
            checkTaza3.Checked = false;
            checkTaza4.Checked = false;
            checkTaza5.Checked = false;
            checkUnifor5.Checked = false;
            checkUnifor2.Checked = false;
            checkUnifor3.Checked = false;
            checkUnifor4.Checked = false;
            checkUnifor5.Checked = false;
            checkDulzor1.Checked = false;
            checkDulzor2.Checked = false;
            checkDulzor3.Checked = false;
            checkDulzor4.Checked = false;
            checkDulzor5.Checked = false;
        }

        private void checkUnifor1_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkUnifor2_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkUnifor3_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkUnifor4_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkUnifor5_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }

        private void checkDulzor1_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkDulzor2_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkDulzor3_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkDulzor4_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkDulzor5_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }

        private void checkTaza1_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkTaza2_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkTaza3_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkTaza4_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void checkTaza5_CheckedChanged(object sender, EventArgs e)
        {
            Calificacion();
        }
        private void Calificacion()
        {
            int i = 0;
            i = (checkDulzor1.Checked) ? i+1 : i;
            i = (checkDulzor2.Checked) ? i+1 : i;
            i = (checkDulzor3.Checked) ? i+1 : i;
            i = (checkDulzor4.Checked) ? i+1 : i;
            i = (checkDulzor5.Checked) ? i+1 : i;
            lbDulzor.Text = Convert.ToString((i * 2));

            i = 0;
            i = (checkUnifor1.Checked) ? i + 1 : i;
            i = (checkUnifor2.Checked) ? i + 1 : i;
            i = (checkUnifor3.Checked) ? i + 1 : i;
            i = (checkUnifor4.Checked) ? i + 1 : i;
            i = (checkUnifor5.Checked) ? i + 1 : i;
            lbUniformidad.Text = Convert.ToString((i * 2));

            i = 0;
            i = (checkTaza1.Checked) ? i + 1 : i;
            i = (checkTaza2.Checked) ? i + 1 : i;
            i = (checkTaza3.Checked) ? i + 1 : i;
            i = (checkTaza4.Checked) ? i + 1 : i;
            i = (checkTaza5.Checked) ? i + 1 : i;
            lbTaza.Text = Convert.ToString((i * 2));

        }
    }
}
