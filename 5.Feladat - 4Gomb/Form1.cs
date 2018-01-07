using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Feladat___4Gomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 50;
            int left = 20;

            Button[] gombok = new Button[4];
            for (int i = 0; i < gombok.Length; i++)
            {
                gombok[i] = new Button();
                Controls.Add(gombok[i]);
                gombok[i].Text = (i + 1).ToString();
                gombok[i].Width = 30;
                gombok[i].Height = 30;
                gombok[i].Top = top;
                gombok[i].Left = left;
                gombok[i].Click += GombokClick;
                if(i % 2 == 0)
                {
                    left += 35;
                } else
                {
                    left = 20;
                    top += 35;
                }
            }
        }

        void GombokClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if(sender is Button)
            {
                MessageBox.Show((sender as Button).Text);
            }
        }
    }
}
