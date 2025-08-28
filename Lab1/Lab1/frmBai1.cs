using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }

        private void rbXanh_CheckedChanged(object sender, EventArgs e)
        {
            tbDonGia.Text = "22000";
        }

        private void rbDo_CheckedChanged(object sender, EventArgs e)
        {
            tbDonGia.Text = "21000";
        }

        private void rbTrang_CheckedChanged(object sender, EventArgs e)
        {
            tbDonGia.Text = "20000";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int Total = int.Parse(tbDonGia.Text) * int.Parse(tbSoLuong.Text);
            
            lblTongtien.Text = Convert.ToString(Total);
        }
    }
}
