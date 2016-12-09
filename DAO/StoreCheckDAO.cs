using System.Data.SqlClient;
using System.Data;
using DTO;
using System;

namespace DAO
{
    public class StoreCheckDAO
    {
        SqlConnection conn = DBConnection.GetConnection();
        public DSphieuKiemKho getSpecificReportList(DSphieuKiemKho phieu_kk)
        {
            SqlCommand cmd = new SqlCommand("sp_getSpecificReportList", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@TenLoaiPhieu", SqlDbType.NVarChar, 50);
            cmd.Parameters["@TenLoaiPhieu"].Value = phieu_kk.loai_phieu;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            phieu_kk.danh_sach_phieu = new DataTable();
            da.Fill(phieu_kk.danh_sach_phieu);
            
            return phieu_kk;
        }

        public DSphieuKiemKho getAllReportList(DSphieuKiemKho ds_pkk)
        {           
            SqlCommand cmd = new SqlCommand("sp_getAllReportList", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds_pkk.danh_sach_phieu = new DataTable();
            da.Fill(ds_pkk.danh_sach_phieu);

            return ds_pkk;
        }

        public PhieuKiemKho getCheckReportDetail(PhieuKiemKho pkk)
        {
            SqlCommand cmd = new SqlCommand("sp_getCheckReportDetail", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieu", pkk.ma_phieu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            pkk.chi_tiet_phieu = new DataTable();
            da.Fill(pkk.chi_tiet_phieu);

            return pkk;
        }
        public int createNewStoreReport(PhieuKiemKho phieu_moi)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            //Kiểm tra đã có phiếu cùng loại, cùng ngày trong CSDL chưa
            SqlCommand cmd = new SqlCommand("select * from PhieuThongKe where LoaiPhieu = @LoaiPhieu and convert(date, NgayGio) = @Ngay", conn);
            cmd.Parameters.AddWithValue("@LoaiPhieu", phieu_moi.ma_loai_phieu.ToString());
            cmd.Parameters.AddWithValue("@Ngay", phieu_moi.ngay_gio.ToString("yyy-MM-dd"));
            if (cmd.ExecuteReader().HasRows == true)
            {
                conn.Close();
                return 0;   //Trả về 0 nếu tìm thấy phiếu cùng loại cùng ngày
            }
            else
            {
                conn.Close();
                conn.Open();
            }

            //Thêm một dòng vào bảng PhieuThongKe, trả về mã phiếu đó.
            cmd = new SqlCommand("sp_createNewStoreReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNV", phieu_moi.ma_nv.ToString());
            cmd.Parameters.AddWithValue("@NgayGio", phieu_moi.ngay_gio.ToString("yyyy-MM-dd hh:mm:ss"));
            cmd.Parameters.AddWithValue("@LoaiPhieu", phieu_moi.ma_loai_phieu.ToString());

            DataTable id_table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(id_table);
            int id_phieu_moi = Convert.ToInt32(id_table.Rows[0].ItemArray.GetValue(0).ToString());

            //Lấy  DS mã nguyên liệu
            cmd = new SqlCommand("select MaNL from NguyenLieu", conn);
            cmd.CommandType = CommandType.Text;

            DataTable ds_ma_NL = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds_ma_NL);

            //Tạo chi tiết phiếu thống kê gồm tất cả những nguyên liệu kể trên vói số lượng ban đầu là 0
            cmd = new SqlCommand("sp_insertNewStoreReportDetail", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieuTK", id_phieu_moi.ToString());
            cmd.Parameters.Add("@MaNL", SqlDbType.Int);
            cmd.Prepare();
            foreach (DataRow row in ds_ma_NL.Select())
            {
                int ma_nl = Convert.ToInt32(row.ItemArray.GetValue(0).ToString());
                cmd.Parameters["@MaNL"].Value = ma_nl;
                cmd.ExecuteNonQuery(); 
            }
            conn.Close();
            return id_phieu_moi;
        }
        public int deleteReport(PhieuKiemKho pkk)
        {
            if(conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("sp_deleteReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieuTK", pkk.ma_phieu.ToString());
            return cmd.ExecuteNonQuery();
        }

    }
}
