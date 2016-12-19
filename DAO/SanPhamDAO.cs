using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Windows.Forms;

namespace DAO
{
    public class SanPhamDAO
    {
        public DataTable Load_info_SP()
        {
            DataTable dtSP = new DataTable();
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_loadSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtSP);
            //DBConnection.CloseConnection();
            return dtSP;
        }

        public DataTable Load_loaiSP()
        {
            DataTable dt = new DataTable();
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_loadLoaiSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //DBConnection.CloseConnection();
            return dt;
        }

        public void addSP(Info_SanPham_DTO spDTO)
        {
            SqlConnection cn;
            cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_addSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Gia", SqlDbType.Int);
            cmd.Parameters.Add("@MaLoaiSP", SqlDbType.SmallInt);

            cmd.Parameters["@TenSP"].Value = spDTO.TenSP;
            cmd.Parameters["@Gia"].Value = spDTO.Gia;
            cmd.Parameters["@MaLoaiSP"].Value = spDTO.MaLoaiSP;

            cmd.ExecuteNonQuery();
            //DBConnection.CloseConnection();
        }

        public void editSP(Info_SanPham_DTO spDTO)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_editSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaSP", SqlDbType.Int);
            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Gia", SqlDbType.Int);
            cmd.Parameters.Add("@MaLoaiSP", SqlDbType.SmallInt);

            cmd.Parameters["@MaSP"].Value = spDTO.MaSP;
            cmd.Parameters["@TenSP"].Value = spDTO.TenSP;
            cmd.Parameters["@Gia"].Value = spDTO.Gia;
            cmd.Parameters["@MaLoaiSP"].Value = spDTO.MaLoaiSP;

            cmd.ExecuteNonQuery();
            //DBConnection.CloseConnection();
        }

        public void deleteSP(Info_SanPham_DTO spDto)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_deleteSP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSP", SqlDbType.Int);

            cmd.Parameters["@MaSP"].Value = spDto.MaSP;

            cmd.ExecuteNonQuery();
            //DBConnection.CloseConnection();;
        }
    }
}