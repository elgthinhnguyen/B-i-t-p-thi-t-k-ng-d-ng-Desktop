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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }
        TinhToan Calculator = new TinhToan();
        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (rbTongAB.Checked)
            {
                Calculator.CongHaiSo(int.Parse(tbSoA.Text), int.Parse(tbSoB.Text), ref total);
            }
            else
            {
                total = Calculator.TongDaySo(int.Parse(tbSoN.Text));
            }
            lblKetQua.Text = total.ToString();
        }
    }
}
