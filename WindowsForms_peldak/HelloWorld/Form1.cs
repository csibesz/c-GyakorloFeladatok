﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btn_HelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbInput.Text,"Hello World Title",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}