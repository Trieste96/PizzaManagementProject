using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        public DataTable Load_info_NV()
        {
            DataTable dtNV = new DataTable();
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_loadNV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtNV);
            return dtNV;
        }

        public DataTable Load_tinhTrang()
        {
            DataTable dt1 = new DataTable();
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_loadTinhTrangNV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);
            return dt1;
        }

        public DataTable Load_loaiNV()
        {
            DataTable dt2 = new DataTable();
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_loadLoaiNV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt2);
            return dt2;
        }



        public void addNV(NhanVien nvDto)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_addNV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@HoTenNV", SqlDbType.NVarChar);
            cmd.Parameters.Add("@CMND", SqlDbType.NVarChar);
            cmd.Parameters.Add("@SoDT", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Email", SqlDbType.VarChar);
            cmd.Parameters.Add("@MaLoaiNV", SqlDbType.SmallInt);
            cmd.Parameters.Add("@MatKhau", SqlDbType.Char);
            cmd.Parameters.Add("@MaTinhTrang", SqlDbType.TinyInt);

            cmd.Parameters["@HoTenNV"].Value = nvDto.HoTen;
            cmd.Parameters["@CMND"].Value = nvDto.SoCMND;
            cmd.Parameters["@SoDT"].Value = nvDto.SoDT;
            cmd.Parameters["@DiaChi"].Value = nvDto.DiaChi;
            cmd.Parameters["@Email"].Value = nvDto.Email;
            cmd.Parameters["@MaLoaiNV"].Value = nvDto.MaLoaiNV;
            cmd.Parameters["@MatKhau"].Value = nvDto.MatKhau;
            cmd.Parameters["@MaTinhTrang"].Value = nvDto.TinhTrang;

            cmd.ExecuteNonQuery();

        }
        public void editNV(NhanVien nvDto)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_editNV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNV", SqlDbType.Int);
            cmd.Parameters.Add("@HoTenNV", SqlDbType.NVarChar);
            cmd.Parameters.Add("@CMND", SqlDbType.NVarChar);
            cmd.Parameters.Add("@SoDT", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Email", SqlDbType.VarChar);
            cmd.Parameters.Add("@MaLoaiNV", SqlDbType.SmallInt);
            cmd.Parameters.Add("@MaTinhTrang", SqlDbType.TinyInt);

            cmd.Parameters["@MaNV"].Value = nvDto.MaNV;
            cmd.Parameters["@HoTenNV"].Value = nvDto.HoTen;
            cmd.Parameters["@CMND"].Value = nvDto.SoCMND;
            cmd.Parameters["@SoDT"].Value = nvDto.SoDT;
            cmd.Parameters["@DiaChi"].Value = nvDto.DiaChi;
            cmd.Parameters["@Email"].Value = nvDto.Email;
            cmd.Parameters["@MaLoaiNV"].Value = nvDto.MaLoaiNV;
            cmd.Parameters["@MaTinhTrang"].Value = nvDto.TinhTrang;

            cmd.ExecuteNonQuery();

        }

        public void deleteNV(NhanVien nvDto)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_deleteNV", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNV", SqlDbType.Int);
            cmd.Parameters["@MaNV"].Value = nvDto.MaNV;

            cmd.ExecuteNonQuery();
        }
    }
}