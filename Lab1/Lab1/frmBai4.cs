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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int so;
            for (int i = 0; i < 10; i++)
            {
                so=rand.Next(1, 100);
                lbSo.Items.Add(so);
            }
        }

        private void btnTIm_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(tbSoCanTim.Text);
            lblKetQua.Text = "Không tìm thấy";
            foreach(int i in lbSo.Items)
            {
                if (i ==soCanTim)
                {
                    lblKetQua.Text = "Tìm thấy";
                    break;
                }
                
            }

        }
    }
}
