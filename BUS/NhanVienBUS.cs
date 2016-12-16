using DAO;
using System;
using System.Data;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nvDao = new NhanVienDAO();
        public DataTable Load_info_NV()
        {
            DataTable dt = new DataTable();
            dt = nvDao.Load_info_NV();
            return dt;
        }

        public DataTable Load_tinhTrang()
        {
            DataTable dt1 = new DataTable();
            dt1 = nvDao.Load_tinhTrang();
            return dt1;
        }

        public DataTable Load_loaiNV()
        {
            DataTable dt2 = new DataTable();
            dt2 = nvDao.Load_loaiNV();
            return dt2;
        }

        public void addNV(NhanVien nvDto)
        {
            try
            {
                nvDao.addNV(nvDto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}