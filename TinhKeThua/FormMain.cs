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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        List<SinhVien> dsSV = new List<SinhVien>();
        private void btnNSV_Click(object sender, EventArgs e)
        {
            string gioiTinh;
            if (rdoGioiTinhSVNam.Checked == true) gioiTinh = "Nam";
            else gioiTinh = "Nữ";
            SinhVien sv = new SinhVien(txtHoTenSV.Text, gioiTinh, dtNgaySinhSV.Value, txtMSSV.Text, cmbNganhHoc.Text, Double.Parse(txtDTB.Text));
            dsSV.Add(sv);
            dgvSV.DataSource = null;
            dgvSV.DataSource = dsSV;
            txtHoTenSV.Text = null;
            txtMSSV.Text = null;
            txtDTB.Text = null;
            rdoGioiTinhSVNam.Checked = true;
            cmbNganhHoc.Text = null;
            dtNgaySinhSV.Value = DateTime.Now;
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
            dgvSV.DataSource = null;
            dgvSV.DataSource = dsSV;
            txtHoTenSV.Text = null;
            txtMSSV.Text = null;
            txtDTB.Text = null;
            rdoGioiTinhSVNam.Checked = true;
            cmbNganhHoc.Text = null;
            dtNgaySinhSV.Value = DateTime.Now;
        }

        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSSV.Text = dgvSV[0, dgvSV.CurrentRow.Index].Value.ToString();
            cmbNganhHoc.Text = dgvSV[1, dgvSV.CurrentRow.Index].Value.ToString();
            txtDTB.Text = dgvSV[2, dgvSV.CurrentRow.Index].Value.ToString();
            
            txtHoTenSV.Text = dgvSV[0, dgvSV.CurrentRow.Index].Value.ToString();
            if (dgvSV[2, dgvSV.CurrentRow.Index].Value.ToString() == "Nam") rdoGioiTinhSVNam.Checked = true;
            else rdoGioiTinhSVNu.Checked = true;
            //dtNgaySinhSV.Value = dgvSV[3,dgvSV.CurrentRow.Index].Value.ToString();            
            
        }
    }
}
