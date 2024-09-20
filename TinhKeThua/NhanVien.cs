using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhKeThua
{
    internal class NhanVien:Person
    {
        private string mSNV;
        private string chucVu;
        private int luong;

        public string MSNV { get => mSNV; set => mSNV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int Luong { get => luong; set => luong = value; }

        public NhanVien() { }
        public NhanVien(string hoTen, string gioiTinh, DateTime ngaySinh,string mSNV, string chucVu, int luong):base(hoTen, gioiTinh, ngaySinh)
        {
            MSNV = mSNV;
            ChucVu = chucVu;
            Luong = luong;
        }
    }
}
