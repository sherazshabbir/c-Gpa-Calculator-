using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpacalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m1, m2, m3, m4, m5, m6;
            int u1, u2, u3, u4, u5, u6;
            m1 = int.Parse(txts1.Text);
            m2 = int.Parse(txts2.Text);
            m3 = int.Parse(txts3.Text);
            m4 = int.Parse(txts4.Text);
            m5 = int.Parse(txts5.Text);
            m6 = int.Parse(txts6.Text);
            u1 = int.Parse(txtu1.Text);
            u2 = int.Parse(txtu2.Text);
            u3 = int.Parse(txtu3.Text);
            u4 = int.Parse(txtu4.Text);
            u5 = int.Parse(txtu5.Text);
            u6 = int.Parse(txtu6.Text);
            if (checkBox1.Checked)
            {
                m1 = 0;

            }
            if (checkBox2.Checked)
            {
                m2 = 0;
            }
            if (checkBox3.Checked)
            {
                m3 = 0;
            }
            if (checkBox4.Checked)
            {
                m4 = 0;
            }
            if (checkBox5.Checked)
            {
                m5 = 0;
            }
            if (checkBox6.Checked)
            {
                m6 = 0;
            }




            int cgp = point(m1) * u1 + point(m2) * u2 + point(m3) * u3 + point(m4) * u4 + point(m5) * u5 + point(m6) * u6;
            int tu = u1 + u2 + u3 + u4 + u5 + u6;
            int ggpa = cgp / tu;
            txttotal.Text= ggpa.ToString();

        }


        int point(int mark)
        {
            int p = 0;
            if (mark < 40)
            {
                p = 0;
            }
            else if (mark >= 40 && mark < 50)
            {
                p = 1;
            }

            else if (mark >= 50 && mark < 60)
            {
                p = 2;
            }

            else if (mark >= 60 && mark < 70)
            {
                p = 3;
            }

            else if (mark >= 70 && mark < 80)
            {
                p = 4;
            }
            else if (mark >= 80 && mark < 100)
            {
                p = 5;
            }
            return p;
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }
