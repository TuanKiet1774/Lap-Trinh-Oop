using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5._5
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int h; //height
        int w; //weight
        Pen p = new Pen(Color.Blue, 2);
        double Dientich = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x; //Cao = X ban đầu - x hiện tại
            w = e.Y - y;
            Graphics g = this.CreateGraphics();
            Rectangle shape = new Rectangle(x, y, h, w);
            if(rbRectangle.Checked)
            {
                p.Color = Color.Green;
                g.DrawRectangle(p, shape);
            }    
            else
            {
                p.Color= Color.Yellow;
                g.DrawEllipse(p, shape);
                //Dientich = h * w * Math.PI / 4;
            }    
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}
