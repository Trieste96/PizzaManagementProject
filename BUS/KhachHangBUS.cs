using DAO;
using System;
using System.Data;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khDao = new KhachHangDAO();
        public DataTable Load_info_KH()
        {
            DataTable dt = new DataTable();
            dt = khDao.Load_info_KH();
            return dt;
        }

        public DataTable Load_loaiKH()
        {
            DataTable dt = new DataTable();
            dt = khDao.Load_loaiKH();
            return dt;
        }

        public void addKH(Info_KhachHang_DTO khDto)
        {
            try
            {
                khDao.addKH(khDto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void editKH(Info_KhachHang_DTO khDto)
        {
            try
            {
                khDao.editKH(khDto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deleteKH(Info_KhachHang_DTO khDto)
        {
            try
            {
                khDao.deleteKH(khDto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}