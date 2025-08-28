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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = lbMatHang.SelectedItem;
            lbDaMua.Items.Add(item);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            var item = lbDaMua.SelectedItem;
            lbDaMua.Items.Remove(item);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach(var hang in lbDaMua.Items)
            {
                switch(hang)
                {
                    case "Chuột":
                        total+= 100000;
                        break;
                    case "Bàn phím":
                        total += 150000;
                        break;
                    case "Máy in":
                        total += 2000000;
                        break;
                    case "USB Kingmax":
                        total += 200000;
                        break;
                }
            }
            lblTongTien.Text = total.ToString()+ " đồng";
        }
    }
}
