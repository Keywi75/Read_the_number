using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Ex1: Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void phep_cong_Click(object sender, EventArgs e)
        {
            long sum = 0;
            int so1 = Int32.Parse(nhap_so_1.Text.Trim()); 
            int so2 = Int32.Parse(nhap_so_2.Text.Trim());
            sum = so1 + so2;
            nhap_so_3.Text = sum.ToString();
        }

        private void phep_tru_Click(object sender, EventArgs e)
        {
            long sum = 0;
            int so1 = Int32.Parse(nhap_so_1.Text.Trim());
            int so2 = Int32.Parse(nhap_so_2.Text.Trim());
            sum = so1 - so2;
            nhap_so_3.Text = sum.ToString();
        }

        private void phep_nhan_Click(object sender, EventArgs e)
        {
            long sum = 0;
            int so1 = Int32.Parse(nhap_so_1.Text.Trim());
            int so2 = Int32.Parse(nhap_so_2.Text.Trim());
            sum = so1 * so2;
            nhap_so_3.Text = sum.ToString();
        }

        private void phep_chia_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int so1 = Int32.Parse(nhap_so_1.Text.Trim());
            int so2 = Int32.Parse(nhap_so_2.Text.Trim());
            sum = (sum +1) * so1 / so2;
            nhap_so_3.Text = sum.ToString("0.##");
        }

        private void nhap_so_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            nhap_so_1.Clear();
            nhap_so_2.Clear();
            nhap_so_3.Clear();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
