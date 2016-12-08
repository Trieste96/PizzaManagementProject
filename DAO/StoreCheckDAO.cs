using System.Data.SqlClient;
using System.Data;
using DTO;
using System;

namespace DAO
{
    public class StoreCheckDAO
    {
        public PhieuKiemKho getSpecificReportList(PhieuKiemKho phieu_kk)
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_getSpecificReportList", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@TenLoaiPhieu", SqlDbType.NVarChar, 50);
            cmd.Parameters["@TenLoaiPhieu"].Value = phieu_kk.loai_phieu;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            phieu_kk.danh_sach_phieu = new DataTable();
            da.Fill(phieu_kk.danh_sach_phieu);
            
            return phieu_kk;
        }

        public PhieuKiemKho getAllReportList(PhieuKiemKho phieu_kk)
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("sp_getAllReportList", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            phieu_kk.danh_sach_phieu = new DataTable();
            da.Fill(phieu_kk.danh_sach_phieu);

            return phieu_kk;
        }
    }
}
