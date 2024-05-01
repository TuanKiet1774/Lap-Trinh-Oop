using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog anh = new OpenFileDialog();
            if(anh.ShowDialog() == DialogResult.OK) pb_img.Image = new Bitmap(anh.FileName);
        }

        private void pb_img_Click(object sender, EventArgs e)
        {

        }
    }
}
