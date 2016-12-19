using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        public DataTable Load_info_KH()
        {
            DataTable dtKH = new DataTable();
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_loadKH", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtKH);
            return dtKH;
        }

        public DataTable Load_loaiKH()
        {
            DataTable dt = new DataTable();
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_loadLoaiKH", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //DBConnection.CloseConnection();
            return dt;
        }



        public void addKH(Info_KhachHang_DTO khDto)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_addKH", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Email", SqlDbType.VarChar);
            cmd.Parameters.Add("@SoDT", SqlDbType.VarChar);
            cmd.Parameters.Add("@MaLoaiKH", SqlDbType.SmallInt);

            cmd.Parameters["@HoTen"].Value = khDto.HoTen;
            cmd.Parameters["@DiaChi"].Value = khDto.DiaChi;
            cmd.Parameters["@Email"].Value = khDto.Email;
            cmd.Parameters["@SoDT"].Value = khDto.Sdt;
            cmd.Parameters["@MaLoaiKH"].Value = khDto.MaLoaiKH;

            cmd.ExecuteNonQuery();
        }



        public void editKH(Info_KhachHang_DTO khDto)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_editKH", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaKH", SqlDbType.Int);
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Email", SqlDbType.VarChar);
            cmd.Parameters.Add("@SoDT", SqlDbType.VarChar);
            cmd.Parameters.Add("@MaLoaiKH", SqlDbType.SmallInt);

            cmd.Parameters["@MaKH"].Value = khDto.MaKH;
            cmd.Parameters["@HoTen"].Value = khDto.HoTen;
            cmd.Parameters["@DiaChi"].Value = khDto.DiaChi;
            cmd.Parameters["@Email"].Value = khDto.Email;
            cmd.Parameters["@SoDT"].Value = khDto.Sdt;
            cmd.Parameters["@MaLoaiKH"].Value = khDto.MaLoaiKH;

            cmd.ExecuteNonQuery();
        }
        public void deleteKH(Info_KhachHang_DTO khDto)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_deleteKH", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaKH", SqlDbType.Int);
            cmd.Parameters["@MaKH"].Value = khDto.MaKH;

            cmd.ExecuteNonQuery();
        }
    }
}