using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class PositionListDAO
    {
        public DataTable loadPositionList()
        {
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("sp_loadPositionList", DBConnection.GetConnection());
            }
            catch(SqlException)
            {
                throw;
            }
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        
        
    }
}
