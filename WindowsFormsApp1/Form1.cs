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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmRegistracija forma = new frmRegistracija(this);
            forma.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frmOperacii forma = new frmOperacii(this);
            forma.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            frmPersonal forma = new frmPersonal(this);
            forma.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            frmItniSlucai forma = new frmItniSlucai(this);
            forma.Show();
        }
    }
}
