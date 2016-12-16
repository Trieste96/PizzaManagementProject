using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class NguyenLieuDAO
    {
        public DataTable Load_info_NL()
        {
            try
            {
                DataTable dtNL = new DataTable();
                SqlConnection cn = DBConnection.GetConnection();
                SqlCommand cmd = new SqlCommand("sp_INFO_loadNL", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtNL);
                return dtNL;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi này.");
                throw;
            }
            
            
        }

        public void addNL(Info_NguyenLieu_DTO nlDTO)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_addNL", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@TenNL", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar);

            cmd.Parameters["@TenNL"].Value = nlDTO.TenNL;
            cmd.Parameters["@DonVi"].Value = nlDTO.DonVi;

            cmd.ExecuteNonQuery();
        }

        public void editNL(Info_NguyenLieu_DTO nlDto)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_editNL", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNL", SqlDbType.Int);
            cmd.Parameters.Add("@TenNL", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar);

            cmd.Parameters["@MaNL"].Value = nlDto.MaNL;
            cmd.Parameters["@TenNL"].Value = nlDto.TenNL;
            cmd.Parameters["@DonVi"].Value = nlDto.DonVi;

            cmd.ExecuteNonQuery();
        }

        public void deleteNL(Info_NguyenLieu_DTO nlDto)
        {
            SqlConnection cn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_INFO_deleteNL", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaNL", SqlDbType.Int);

            cmd.Parameters["@MaNL"].Value = nlDto.MaNL;

            cmd.ExecuteNonQuery();
        }
    }
}