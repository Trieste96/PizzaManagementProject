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

            cm.Parameters["@MaNV"].Value = guest.ma_NV;
            //cm.Parameters["@MaLoaiNV"].Value = guest.MaLoaiNV;
            cm.Parameters["@MatKhau"].Value = guest.mat_khau;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            NhanVien user = new NhanVien();
            if(dt.Rows.Count == 0)
            {
                user.tinh_trang = 0;
            }
            else
            {
                user.ma_NV = guest.ma_NV;
                user.ho_ten = dt.Rows[0]["HoTenNV"].ToString();               
                user.ten_loai_nv = dt.Rows[0]["TenLoai"].ToString();
                user.ma_loai_NV = Convert.ToInt32(dt.Rows[0]["MaLoaiNV"]);
                user.tinh_trang = 1;
            }
            //DBConnection.CloseConnection();
            //cn.Close();
            return user;
        }
    }
}
