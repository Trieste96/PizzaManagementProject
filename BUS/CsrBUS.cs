using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CsrBUS
    {
        DAO.CsrDAO csrdao = new DAO.CsrDAO();
        public void taohoadon(DTO.HoaDonDTO dto)
        {

            try
            {
                csrdao.taohoadon(dto);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void themchitiethoadon(DTO.HoaDonDTO dto)
        {
            try
            {
                csrdao.themchitiethoadon(dto);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DTO.Info_KhachHang_DTO thongtinkhachhang(int makh)
        {
            DAO.CsrDAO csr = new DAO.CsrDAO();
            return csr.timthongtinkhachhang(makh);
        }
    }
}
