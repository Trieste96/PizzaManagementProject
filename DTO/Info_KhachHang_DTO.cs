using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Info_KhachHang_DTO
    {
        private int maKH;
        private string hoTen;
        private string diaChi;
        private string email;
        private string sdt;
        private int maloaiKH;

        public int MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public int MaLoaiKH
        {
            get { return maloaiKH; }
            set { maloaiKH = value; }
        }
        public Info_KhachHang_DTO(int _mahk,string _hoten,string _diachi,string _email,string _sdt,int _maloaikh)
        {
            maKH = _mahk;
            hoTen = _hoten;
            diaChi = _diachi;
            email = _email;
            sdt = _sdt;
            maloaiKH = _maloaikh;
        }
    }
}
