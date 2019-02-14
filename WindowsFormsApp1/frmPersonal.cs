using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        public frmPersonal(Form1 parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        HMSbazaEntities baza = new HMSbazaEntities();

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            (from viewP in baza.Personal
             select viewP).Load();

            personalBindingSource.DataSource = baza.Personal.Local;
            
            
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Validate();
            personalBindingSource.EndEdit();
            baza.SaveChanges();

        }
    }
}
