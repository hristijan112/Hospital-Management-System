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
    public partial class frmOperacii : Form
    {
        public frmOperacii()
        {
            InitializeComponent();
        }

        public frmOperacii(Form1 parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        HMSbazaEntities baza = new HMSbazaEntities();

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Operacii operacija = new Operacii();

                operacija.idPacient = Convert.ToInt32(txtIdPacient.Text);
                operacija.idPersonal = Convert.ToInt32(txtIdDoktor.Text);
                operacija.tipNaOperacija = txtTipOperacija.Text;
                operacija.vreme = Convert.ToDateTime(txtVreme.Text);

                baza.Operacii.Add(operacija);
                baza.SaveChanges();

                txtIdPacient.Text = "";
                txtIdDoktor.Text = "";
                txtTipOperacija.Text = "";
                txtVreme.Text = "";
            }
            catch
            {
                txtIdPacient.Text = "Neuspesno";
            }
        }

        private void frmOperacii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSbazaDataSet.Operacii' table. You can move, or remove it, as needed.
            this.operaciiTableAdapter.Fill(this.hMSbazaDataSet.Operacii);
            //dataGridView1.DataSource = baza.Operacii.Select(x => x).ToList();
        }
    }
}
