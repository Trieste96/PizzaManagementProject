using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Info_NguyenLieu_DTO
    {
        private int maNL;
        private string tenNL;
        private string donVi;

        public int MaNL
        {
            get { return maNL; }
            set { maNL = value; }
        }

        public string TenNL
        {
            get { return tenNL; }
            set { tenNL = value; }
        }
        public string DonVi
        {
            get { return donVi; }
            set { donVi = value; }
        }

        public Info_NguyenLieu_DTO(int _maNL, string _tenNL, string _donVi)
        {
            maNL = _maNL;
            tenNL = _tenNL;
            donVi = _donVi;
        }
    }
}
