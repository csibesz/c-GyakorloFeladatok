using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalc
{
    public partial class Form1 : Form
    {
        public Queue<object> sor;
        public bool elozoMuvelet = false;

        public Form1()
        {
            InitializeComponent();
            sor = new Queue<object>();
        }

        private void btn_Szambevitel_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tbDisplayResult.AppendText(btn.Text);
            elozoMuvelet = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDisplayResult.ResetText();
        }

        private void btn_Muvelet_Click(object sender, EventArgs e)
        {
            

            Button btn = (Button)sender;
            if (!elozoMuvelet)
            {
                sor.Enqueue(double.Parse(tbDisplayResult.Text));
                tbDisplayResult.ResetText();
                switch (btn.Text)
                {
                    case "+":
                        sor.Enqueue('+');
                        break;
                    case "-":
                        sor.Enqueue('-');
                        break;
                    case "*":
                        sor.Enqueue('*');
                        break;
                    case "/":
                        sor.Enqueue('/');
                        break;
                }
            }
            elozoMuvelet = true;
        }

        private void btn_Egyen_Click(object sender, EventArgs e)
        {
            double eredmeny = 0;
            object sorElem;

            sor.Enqueue(double.Parse(tbDisplayResult.Text));

            sorElem = sor.Dequeue();
            eredmeny = (double)sorElem;

            for (int i = 0; i < sor.Count; i++)
            {
                sorElem = sor.Dequeue();
                if (sorElem is char)
                {
                    switch ((char)sorElem)
                    {
                        case '+':
                            sorElem = sor.Dequeue();
                            eredmeny += (double)sorElem;
                            break;
                        case '-':
                            sorElem = sor.Dequeue();
                            eredmeny -= (double)sorElem;
                            break;
                        case '*':
                            sorElem = sor.Dequeue();
                            eredmeny *= (double)sorElem;
                            break;
                        case '/':
                            sorElem = sor.Dequeue();
                            eredmeny /= (double)sorElem;
                            break;
                    }
                }
            }
            tbDisplayResult.Text = eredmeny.ToString();
        }
    }
}
