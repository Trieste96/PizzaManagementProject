using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class PositionListBUS
    {
        public DataTable loadPositionList()
        {
            PositionListDAO dao = new PositionListDAO();
            try
            {
                return dao.loadPositionList();
            }
            catch
            {
                throw;
            }
            return dao.loadPositionList(); ;
        }
    }
}
