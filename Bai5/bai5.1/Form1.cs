using System;
using System.Windows.Forms;

namespace bai5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double chuvi;
            chuvi = Math.Round((double.Parse(txtNhapR.Text) * Math.PI * 2),4);
            lblKetQua.Text ="Chu vi hình tròn: " + chuvi.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            double dientich;
            dientich = Math.Round((Math.Pow(double.Parse(txtNhapR.Text), 2) * Math.PI),4);
            lblKetQua.Text = "Diện tích hình tròn: " + dientich.ToString();
        }
    }
}
