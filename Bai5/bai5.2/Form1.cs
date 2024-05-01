using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            double delta;
            double x1, x2;

            if (a != 0)
            {
                if (b != 0)
                {
                    delta = b * b - 4 * a * c;
                    if (delta == 0) lblNghiem.Text = "Phương trình có nghiệm kép: x = " + ((-b) / 2 * a);
                    else if (delta > 0)
                    {
                        x1 = (float)(-b + Math.Sqrt(delta)) / 2 * a;
                        x2 = (float)(-b - Math.Sqrt(delta)) / 2 * a;
                        lblNghiem.Text = " Phương trình có 2 nghiệm: X1 = " + x1 + "X2 = " + x2;
                    }
                    else lblNghiem.Text = "Phuong trinh vo nghiem";
                }
                else
                if ((a * c) < 0)
                {
                    x1 = (Math.Sqrt(-c / a));
                    x2 = -(Math.Sqrt(-c / a));
                    lblNghiem.Text = " Phương trình có 2 nghiệm: X1 = " + x1 + "X2 = " + x2;
                }
            }
            else if (b == 0)
            {
                if (c == 0) lblNghiem.Text = "Phuong trinh co vo so nghiem.";
                else lblNghiem.Text = "Phuong trinh vo nghiem";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
