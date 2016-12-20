using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private int MaNV, MaKH, HtPV, MaSP, SoLuong, TongTien;
        private String NgayGio;
        public HoaDonDTO()
        {

        }
        public HoaDonDTO(int manv, int makh, int htpv, int masp, int soluong, string ngaygio)
        {
            MaNV = manv;
            MaKH = makh;
            HtPV = htpv;
            MaSP = masp;
            SoLuong = soluong;
            NgayGio = ngaygio;
        }
        public int manv
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        public int makh
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        public int htpv
        {
            get { return HtPV; }
            set { HtPV = value; }
        }
        public int masp
        {
            get { return MaSP; }
            set { MaSP = value; }
        }
        public int soluong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }
        public string ngaygio
        {
            get { return NgayGio; }
            set { NgayGio = value; }
        }
        public int tongtien
        {
            get { return TongTien; }
            set { TongTien = value; }
        }
    }
}
