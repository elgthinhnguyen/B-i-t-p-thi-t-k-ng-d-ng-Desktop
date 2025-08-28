using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_BaiTapWinForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void cbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tien = 0;
            
                switch (cbTenHang.SelectedItem)
                {
                    case "Chuột":
                        tien = 100000;
                        break;
                    case "Máy in":
                        tien = 2000000;
                        break;
                    case "Bàn phím":
                        tien = 150000;
                        break;
                }

            tbDonGia.Text = tien.ToString();

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            float total = 0;
            total = int.Parse(tbDonGia.Text) * int.Parse(tbSoLuong.Text);
            if (rbCK.Checked == true)
                total -= total * 5 / 100;
            lblTongTien.Text = total.ToString();
        }
    }
}
