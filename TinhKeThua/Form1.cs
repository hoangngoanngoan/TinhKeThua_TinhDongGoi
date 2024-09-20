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
            string nganhHoc = cmbNganhHoc.Enabled.ToString();
            string gioiTinh;
            if (rdoGioiTinhSVNam.Checked == true) gioiTinh = "Nam";
            else gioiTinh = "Nữ";
            SinhVien sv = new SinhVien(txtHoTenSV.Text,gioiTinh,dtNgaySinhSV.Value,txtMSSV.Text,nganhHoc,Double.Parse(txtDTB.Text));
            dsSV.Add(sv);
            dgvSV.DataSource = null;
            dgvSV.DataSource = dsSV;
        }
    }
}
