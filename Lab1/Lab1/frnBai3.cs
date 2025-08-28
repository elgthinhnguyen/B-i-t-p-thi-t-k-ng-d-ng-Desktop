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
    public partial class frnBai3 : Form
    {
        public frnBai3()
        {
            InitializeComponent();
        }
            Dictionary<string, string> words = new Dictionary<string, string>();
        private void btnThemTu_Click(object sender, EventArgs e)
        {
            var tuMoi = tbTuMoi.Text;
            var Nghia = tbNghia.Text;
            words.Add(tuMoi, Nghia);
            lbTuMoi.Items.Add(tuMoi);

        }

        private void lbTuMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNghiaHienThi.Text = words[lbTuMoi.SelectedItems[0].ToString()];
        }
    }
}
