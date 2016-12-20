using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class DoanhThuBUS
    {
        public SqlDataReader tracuu(string bd,string kt)
        {
            DAO.DoanhThuDAO dao = new DAO.DoanhThuDAO();
            return dao.tracuu(bd,kt);
        }
        public SqlDataReader tracuuall()
        {
            DAO.DoanhThuDAO dao = new DAO.DoanhThuDAO();
            return dao.tracuuall();
        }
        public void huyhoadon(int mahd)
        {
            DAO.DoanhThuDAO dao = new DAO.DoanhThuDAO();
            dao.huyhoadon(mahd);
        }
        public SqlDataReader thongtinhoadon(int mahd)
        {
            DAO.DoanhThuDAO dao = new DAO.DoanhThuDAO();
            return dao.thongtinhoadon(mahd);
        }
    }
}
