using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class CsrDAO
    {
        
        public void taohoadon(DTO.HoaDonDTO dto)
        {
           /*qlConnection cn;
            cn = DBConnection.GetConnection();
            SqlCommand cm = new SqlCommand("taohoadon", cn);*/
            SqlConnection cn = new SqlConnection();
            cn = DBConnection.GetConnection();
            //cn.Open();
            SqlCommand cm = new SqlCommand("taohoadon", cn);
            cm.CommandType = System.Data.CommandType.StoredProcedure;
            cm.Parameters.Add("@makh", SqlDbType.Int);
            cm.Parameters.Add("@manv", SqlDbType.Int);
            cm.Parameters.Add("@time", SqlDbType.DateTime);
            cm.Parameters.Add("@hinhthuc", SqlDbType.SmallInt);

            cm.Parameters["@makh"].Value = dto.makh;
            cm.Parameters["@manv"].Value = dto.manv;
            cm.Parameters["@time"].Value = dto.ngaygio;
            cm.Parameters["@hinhthuc"].Value = dto.htpv;
            cm.ExecuteNonQuery();
            //cn.Close();
        }
        public void themchitiethoadon(DTO.HoaDonDTO dto)
        {
            SqlConnection cn = new SqlConnection();
            cn = DBConnection.GetConnection();
            //cn.Open();
            SqlCommand cm = new SqlCommand("chitiethoadon",cn);
            cm.CommandType = System.Data.CommandType.StoredProcedure;
            cm.Parameters.Add("@time", SqlDbType.DateTime);
            cm.Parameters.Add("@masp", SqlDbType.Int);
            cm.Parameters.Add("@soluong", SqlDbType.SmallInt);

            cm.Parameters["@time"].Value = dto.ngaygio;
            cm.Parameters["@masp"].Value = dto.masp;
            cm.Parameters["@soluong"].Value = dto.soluong;
            cm.ExecuteNonQuery();
            //cn.Close();
        }
        public DTO.Info_KhachHang_DTO timthongtinkhachhang(int makh)
        {
            DTO.Info_KhachHang_DTO dto = new DTO.Info_KhachHang_DTO();
            SqlConnection cn = new SqlConnection();
            cn = DBConnection.GetConnection();
            //cn.Open();
            SqlCommand cm = new SqlCommand("thongtinkhachhang", cn);
            cm.CommandType = System.Data.CommandType.StoredProcedure;
            cm.Parameters.Add("@makh", SqlDbType.Int);

            cm.Parameters["@makh"].Value = makh;
            using (SqlDataReader dr = cm.ExecuteReader())
            {
                while (dr.Read())
                {
                    dto.HoTen = dr[0].ToString();
                    dto.MaLoaiKH = int.Parse(dr[1].ToString());
                    dto.LoaiKH = dr[2].ToString();
                    dto.ChietKhau = int.Parse(dr[3].ToString());
                }
            }
            return dto;
            //cn.Close();
        }
    }
}
