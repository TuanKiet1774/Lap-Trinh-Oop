using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5._4
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

        private void lblThanhToan_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtQuangDuong_TextChanged(object sender, EventArgs e)
        {
            double km = double.Parse(txtQuangDuong.Text);
            double money = 0;

            if (rbtn7.Checked)
            {
                if (km <= 1) money = km * 17000;
                else if (km <= 5) money = 1 * 17000 + (km - 1) * 15000;
                else if (km <= 100) money = 1 * 17000 + 4 * 15000 + (km - 5) * 12000;
                else money = 1 * 17000 + 4 * 15000 + 95 * 12000 + (km - 100) * 11000;

            }
            if (rbtn4.Checked)
            {
                if (km <= 1) money = km * 15000;
                else if (km <= 5) money = 1 * 15000 + (km - 1) * 13500;
                else if (km <= 100) money = 1 * 15000 + 4 * 13500 + (km - 5) * 11000;
                else money = 1 * 15000 + 4 * 13500 + 95 * 11000 + (km - 100) * 10000;
            }

            double MoneyGiam = 0;

            if (GiamGia.Checked)
            {
                MoneyGiam = money * 0.95;
                txtThanhToan.Text = MoneyGiam.ToString() + "";
            }
            else txtThanhToan.Text = money.ToString() + "";


        }
        // rbtn7 rbtn4 chọn loại xe và hiển thị giá tiền
        private void rbtn7_CheckedChanged(object sender, EventArgs e)
        {
            double km = double.Parse(txtQuangDuong.Text);
            double money = 0;

            if (rbtn7.Checked)
            {
                if (km <= 1) money = km * 17000;
                else if (km <= 5) money = 1 * 17000 + (km - 1) * 15000;
                else if (km <= 100) money = 1 * 17000 + 4 * 15000 + (km - 5) * 12000;
                else money = 1 * 17000 + 4 * 15000 + 95 * 12000 + (km - 100) * 11000;

            }

            double MoneyGiam = 0;

            if (GiamGia.Checked)
            {
                MoneyGiam = money * 0.95;
                txtThanhToan.Text = MoneyGiam.ToString() + "";
            }
            else txtThanhToan.Text = money.ToString() + "";
        }

        private void rbtn4_CheckedChanged(object sender, EventArgs e)
        {
            double km = double.Parse(txtQuangDuong.Text);
            double money = 0;

            if (rbtn4.Checked)
            {
                if (km <= 1) money = km * 15000;
                else if (km <= 5) money = 1 * 15000 + (km - 1) * 13500;
                else if (km <= 100) money = 1 * 15000 + 4 * 13500 + (km - 5) * 11000;
                else money = 1 * 15000 + 4 * 13500 + 95 * 11000 + (km - 100) * 10000;
            }

            double MoneyGiam = 0;

            if (GiamGia.Checked)
            {
                MoneyGiam = money * 0.95;
                txtThanhToan.Text = MoneyGiam.ToString() + "";
            }
            else txtThanhToan.Text = money.ToString() + "";
        }

        private void GiamGia_CheckedChanged(object sender, EventArgs e)
        {
            txtQuangDuong_TextChanged(sender, e); //Khi Giảm Giá kích hoạt
        }
    }
}
