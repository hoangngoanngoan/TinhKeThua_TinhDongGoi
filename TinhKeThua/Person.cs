using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhKeThua
{
    internal class Person
    {
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public Person() { }
        public Person(string hoTen, string gioiTinh, DateTime ngaySinh)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }
    }
}
