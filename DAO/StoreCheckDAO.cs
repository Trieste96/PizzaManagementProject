using System.Data.SqlClient;
using System.Data;
using DTO;
using System;

namespace DAO
{
    public class StoreCheckDAO
    {
        SqlConnection conn = DBConnection.GetConnection();
        SqlCommand cmd;
        public DSphieuKiemKho getSpecificReportList(DSphieuKiemKho phieu_kk)
        {
            cmd = new SqlCommand("sp_getSpecificReportList", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@TenLoaiPhieu", SqlDbType.NVarChar, 50);
            cmd.Parameters["@TenLoaiPhieu"].Value = phieu_kk.loai_phieu;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            phieu_kk.danh_sach_phieu = new DataTable();
            da.Fill(phieu_kk.danh_sach_phieu);
            
            return phieu_kk;
        }

        public DSphieuKiemKho getReportList(DSphieuKiemKho ds)
        {
            cmd = new SqlCommand("sp_getReportList", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@phieu_1", ds.phieu_1);
            cmd.Parameters.AddWithValue("@phieu_2", ds.phieu_2);
            cmd.Parameters.AddWithValue("@phieu_3", ds.phieu_3);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds.danh_sach_phieu = new DataTable();
            da.Fill(ds.danh_sach_phieu);

            return ds;
        }

        public DSphieuKiemKho getAllReportList(DSphieuKiemKho ds_pkk)
        {           
            cmd = new SqlCommand("sp_getAllReportList", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds_pkk.danh_sach_phieu = new DataTable();
            da.Fill(ds_pkk.danh_sach_phieu);

            return ds_pkk;
        }
        public PhieuThongKe getCheckReportDetail(PhieuThongKe pkk)
        {
            cmd = new SqlCommand("sp_getCheckReportDetail", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhieu", pkk.ma_phieu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            pkk.chi_tiet_phieu = new DataTable();
            da.Fill(pkk.chi_tiet_phieu);

            return pkk;
        }
        public int createImportReport(PhieuThongKe phieu_moi)
        {
            //Thêm một dòng vào bảng PhieuThongKe
            if (conn.State == ConnectionState.Closed)
                conn.Open();
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
        public int createStoreCheckReport(PhieuThongKe phieu_moi)
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
                //Tương tự tạo phiếu nhập kho
                return createImportReport(phieu_moi);
            }               
        }
        public int deleteReport(PhieuThongKe pkk)
        {
            if(conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand("sp_deleteReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieuTK", pkk.ma_phieu.ToString());
            return cmd.ExecuteNonQuery();
        }
        public void changeReportDetail(PhieuThongKe pkk)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("sp_changeReportDetail", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaPhieuTK", SqlDbType.Int).Value = pkk.ma_phieu.ToString();
                cmd.Parameters.Add("@MaNL", SqlDbType.Int);
                cmd.Parameters.Add("@SoLuong", SqlDbType.Float);
                cmd.Prepare();
                foreach (DataRow row in pkk.chi_tiet_phieu.Rows)
                {
                    object[] item_array = row.ItemArray;
                    cmd.Parameters["@MaNL"].Value = item_array.GetValue(0);
                    cmd.Parameters["@SoLuong"].Value = item_array.GetValue(2);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (FormatException)
            {
                throw;
            }
        }
        public BangTinhHinhTK storeStatistics(BangTinhHinhTK bang)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd = new SqlCommand("sp_storeStatistics", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NgayBD", bang.ngay_BD.ToString("yyyy-MM-dd 00:00:00"));
            cmd.Parameters.AddWithValue("@NgayKT", bang.ngay_KT.ToString("yyyy-MM-dd 23:59:59"));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(bang.chi_tiet);
            return bang;
        }
    }
}
