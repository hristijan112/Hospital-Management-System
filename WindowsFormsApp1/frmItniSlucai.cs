﻿using System;
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
    }
}