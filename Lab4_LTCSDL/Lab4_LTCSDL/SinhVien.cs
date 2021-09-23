using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_LTCSDL
{
    public class SinhVien
    {
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public string Mail { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public SinhVien()
        {

        }
        public SinhVien(string ma, string ten, string mail, string dc, string hinh, DateTime ngay, bool gt, string lop, string sdt)
        {
            this.Ma = ma;
            this.HoTen = ten;
            this.Mail = mail;
            this.DiaChi = dc;
            this.Hinh = hinh;
            this.NgaySinh = ngay;
            this.GioiTinh = gt;
            this.Lop = lop;
            this.SDT = sdt; 
        }
    }
}
