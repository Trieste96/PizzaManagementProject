using DAO;
using System;
using System.Data;
using DTO;

namespace BUS
{
    public class NguyenLieuBUS
    {
        public DataTable Load_info_NL()
        {
            NguyenLieuDAO nlDao = new NguyenLieuDAO();
            DataTable dt = new DataTable();
            dt = nlDao.Load_info_NL();
            return dt;

        }

        public void addNL(Info_NguyenLieu_DTO nlDTO)
        {
            NguyenLieuDAO nlDao = new NguyenLieuDAO();
            try
            {
                nlDao.addNL(nlDTO);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void deleteNL(Info_NguyenLieu_DTO nlDto)
        {
            NguyenLieuDAO nlDao = new NguyenLieuDAO();
            try
            {
                nlDao.deleteNL(nlDto);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void editNL(Info_NguyenLieu_DTO nlDto)
        {
            NguyenLieuDAO nlDao = new NguyenLieuDAO();
            try
            {
                nlDao.editNL(nlDto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}