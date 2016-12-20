using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DoanhThuDAO
    {
        public SqlDataReader tracuu(string bd,string kt)
        {
            SqlConnection cn = new SqlConnection();
            cn = DBConnection.GetConnection();
            SqlCommand cm = new SqlCommand("tracuutctheothoigian",cn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@datebd", SqlDbType.DateTime);
            cm.Parameters.Add("@datekt", SqlDbType.DateTime);

            cm.Parameters["@datebd"].Value = bd;
            cm.Parameters["@datekt"].Value = kt;
            SqlDataReader rd = cm.ExecuteReader();
            return rd;
            
        }
        public SqlDataReader tracuuall()
        {
            SqlConnection cn = new SqlConnection();
            cn = DBConnection.GetConnection();
            SqlCommand cm = new SqlCommand("tracuutcall", cn);
            SqlDataReader rd = cm.ExecuteReader();
            return rd;
        }
        public void huyhoadon(int mahd)
        {
            SqlConnection cn = new SqlConnection();
            cn = DBConnection.GetConnection();
            SqlCommand cm = new SqlCommand("huyhoadon", cn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@mahd", SqlDbType.Int);

            cm.Parameters["@mahd"].Value = mahd;
            cm.ExecuteNonQuery();
        }
        public SqlDataReader thongtinhoadon(int mahd)
        {

            SqlConnection cn = new SqlConnection();
            cn = DBConnection.GetConnection();
            SqlCommand cm = new SqlCommand("thongtinhoadon", cn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@mahd", SqlDbType.Int);
            cm.Parameters["@mahd"].Value = mahd;
            SqlDataReader rd = cm.ExecuteReader();
            return rd;
        }
    }
}
