using DAO;
using System;
using System.Data;
using DTO;

namespace BUS
{
    public class SanPhamBUS
    {
        public DataTable Load_info_SP()
        {
            SanPhamDAO spDao = new SanPhamDAO();
            DataTable dt = new DataTable();
            dt = spDao.Load_info_SP();
            return dt;
        }

        public DataTable Load_loaiSP()
        {
            SanPhamDAO spDao = new SanPhamDAO();
            DataTable dt = new DataTable();
            dt = spDao.Load_loaiSP();
            return dt;
        }

        public void addSP(Info_SanPham_DTO spDTO)
        {
            SanPhamDAO spDao = new SanPhamDAO();
            try
            {
                spDao.addSP(spDTO);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void editSP(Info_SanPham_DTO spDTO)
        {
            SanPhamDAO spDao = new SanPhamDAO();
            try
            {
                spDao.editSP(spDTO);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deleteSP(Info_SanPham_DTO spDto)
        {
            SanPhamDAO spDao = new SanPhamDAO();
            try
            {
                spDao.deleteSP(spDto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}