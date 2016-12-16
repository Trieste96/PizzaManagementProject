using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public string SoCMND { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int MaLoaiNV { get; set; }
        public string TenLoaiNV { get; set; }
        public string MatKhau { get; set; }
        public int TinhTrang { get; set; }

        public NhanVien(int _maNV,string _hoTen,string _soCMND,string _soDT,string _diaChi,string _email,int _maLoaiNV,string _matKhau,int _tinhTrang)
        {
            MaNV = _maNV;
            HoTen = _hoTen;
            SoCMND = _soCMND;
            SoDT = _soDT;
            DiaChi = _diaChi;
            Email = _email;
            MaLoaiNV = _maLoaiNV;
            MatKhau = _matKhau;
            TinhTrang = _tinhTrang;
        }
        public NhanVien()
        {

        }
    }
}
