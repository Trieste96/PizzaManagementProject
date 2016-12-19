using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Info_SanPham_DTO
    {
        private int maSP;
        private string tenSP;
        private int gia;
        private int maLoaiSP;

        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public int MaLoaiSP
        {
            get { return maLoaiSP; }
            set { maLoaiSP = value; }
        }
        public Info_SanPham_DTO(int _masp, string _tensp, int _gia, int _maloaisp)
        {
            maSP = _masp;
            tenSP = _tensp;
            gia = _gia;
            maLoaiSP = _maloaisp;
        }
        public Info_SanPham_DTO()
            {

            }
    }
}
