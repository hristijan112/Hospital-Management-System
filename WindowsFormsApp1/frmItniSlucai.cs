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
    public partial class frmItniSlucai : Form
    {
        public frmItniSlucai()
        {
            InitializeComponent();
        }

        public frmItniSlucai(Form1 parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        HMSbazaEntities baza = new HMSbazaEntities();

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ItniSlucai itniSlucai = new ItniSlucai();

                itniSlucai.idPersonal = Convert.ToInt32(txtIdPersonal.Text);
                itniSlucai.operacionaSala = txtOperacionaSala.Text;
                itniSlucai.tip = txtTipOperacija.Text;
                itniSlucai.vreme = Convert.ToDateTime(txtDatumVreme.Text);

                baza.ItniSlucai.Add(itniSlucai);
                baza.SaveChanges();

                txtIdPersonal.Text = "";
                txtOperacionaSala.Text = "";
                txtTipOperacija.Text = "";
                txtDatumVreme.Text = "";
            }
            catch
            {
                txtIdPersonal.Text = "Neuspesno";
            }
        }

        private void frmItniSlucai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSbazaDataSet.ItniSlucai' table. You can move, or remove it, as needed.
            this.itniSlucaiTableAdapter.Fill(this.hMSbazaDataSet.ItniSlucai);

        }
    }
}
