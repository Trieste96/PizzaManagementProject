using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class AuthenticationDAO
    {
        public NhanVien verifyAccount(NhanVien guest)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cm = new SqlCommand("sp_authenticate", cn);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@MaNV", SqlDbType.Int);
            //cm.Parameters.Add("@MaLoaiNV", SqlDbType.SmallInt);
            cm.Parameters.Add("@MatKhau", SqlDbType.Char, 32);

            cm.Parameters["@MaNV"].Value = guest.MaNV;
            //cm.Parameters["@MaLoaiNV"].Value = guest.MaLoaiNV;
            cm.Parameters["@MatKhau"].Value = guest.MatKhau;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            NhanVien user = new NhanVien();
            if(dt.Rows.Count == 0)
            {
                user.TinhTrang = 0;
            }
            else
            {
                user.MaNV = guest.MaNV;
                user.HoTen = dt.Rows[0]["HoTenNV"].ToString();               
                user.TenLoaiNV = dt.Rows[0]["TenLoai"].ToString();
                user.MaLoaiNV = Convert.ToInt32(dt.Rows[0]["MaLoaiNV"]);
                user.TinhTrang = 1;
            }
            return user;
        }
    }
}
