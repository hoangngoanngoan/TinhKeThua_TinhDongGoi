using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhKeThua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SinhVien> dsSV = new List<SinhVien>();
        private void btnNSV_Click(object sender, EventArgs e)
        {
            string gioiTinh;
            if (rdoGioiTinhSVNam.Checked == true) gioiTinh = "Nam";
            else gioiTinh = "Nữ";
            SinhVien sv = new SinhVien(txtHoTenSV.Text,gioiTinh,dtNgaySinhSV.Value,txtMSSV.Text,cmbNganhHoc.Text,Double.Parse(txtDTB.Text));
            dsSV.Add(sv);
            dgvSV.DataSource = null;
            dgvSV.DataSource = dsSV;
        }

        private void btnXSV_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dsSV.Count; i++)
            {
                if (dsSV[i].MSSV == txtMSSV.Text)
                {
                    dsSV.Remove(dsSV[i]);
                    i--;    
                }
            }
        }

        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHoTenSV.Text = dgvSV[2,dgvSV.CurrentRow.Index].Value.ToString();
        }
    }
}
