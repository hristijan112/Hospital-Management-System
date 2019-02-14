using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        public frmRegistracija(Form1 parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        HMSbazaEntities baza = new HMSbazaEntities();

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {

                Pacient pacient = new Pacient();

                pacient.ime = txtIme.Text;
                pacient.pol = txtPol.Text;
                pacient.adresa = txtAdresa.Text;
                pacient.alergii = txtAlergii.Text;
                pacient.primen = Convert.ToDateTime(txtPrimen.Text);
                pacient.idBolnica = Convert.ToInt32(txtIdBolnica.Text);

                baza.Pacient.Add(pacient);
                baza.SaveChanges();
               
                txtIme.Text = "";
                txtPol.Text = "";
                txtAdresa.Text = "";
                txtAlergii.Text = "";
                txtPrimen.Text = "";
                txtIdBolnica.Text = "";  
            }
            catch
            {
                txtIme.Text = "Neuspesno";
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baza.Pacient.Select(x => x).ToList();
        }
    }
}
