using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhKeThua
{
    internal class SinhVien:Person
    {
        private string mSSV;
        private string nganhHoc;
        private double diemTB;

        public string MSSV { get => mSSV; set => mSSV = value; }
        public string NganhHoc { get => nganhHoc; set => nganhHoc = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }
        public SinhVien() { }
        public SinhVien(string hoTen, string gioiTinh, DateTime ngaySinh,string mSSV, string nganhHoc, double diemTB):base(hoTen,gioiTinh,ngaySinh)
        {
            MSSV = mSSV;
            NganhHoc = nganhHoc;
            DiemTB = diemTB;
        }
    }
}
