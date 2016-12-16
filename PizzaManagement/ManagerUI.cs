using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace PizzaManagement
{

    public partial class ManagerUI : Form
    {
        //Thông tin của nngười đăng nhập vào hệ thống được lưu ở biến user này
        private NhanVien user;

        private SanPhamBUS spBus;
        private NguyenLieuBUS nlBus;
        public ManagerUI()
        {
            InitializeComponent();
            spBus = new SanPhamBUS();
            nlBus = new NguyenLieuBUS();
        }

        private void btnQuanLyDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void loadTreeView()
        {
            //Node lịch làm việc
            TreeNode timeTable = new TreeNode("Sắp xếp lịch làm việc", 1, 1);
            //Node tài chính
            TreeNode[] financeOptions =
            {
                new TreeNode("Tình hình tài chính", 21, 21)
            };
            TreeNode finance = new TreeNode("Quản lý tài chính", 2, 2, financeOptions);
            finance.ExpandAll();

            //Node kho hàng
            TreeNode[] storeOptions =
            {
                new TreeNode("Lập phiếu kiểm kho", 31, 31),
                new TreeNode("Lập phiếu nhập kho", 32, 32),
                new TreeNode("Tra cứu thông tin kho hàng", 33, 33)
            };
            TreeNode store = new TreeNode("Quản lý kho hàng", 3, 3, storeOptions);
            store.ExpandAll();

            //Node thông tin
            TreeNode[] infoOptions =
            {
                new TreeNode("Sản phẩm", 41, 41),
                new TreeNode("Nguyên liệu", 42, 42),
                new TreeNode("Nhân viên", 43, 43),
                new TreeNode("Khách hàng", 44, 44)
            };
            TreeNode info = new TreeNode("Quản lý thông tin", 4, 4, infoOptions);
            //Thêm node vào tree view
            treeFunctionList.Nodes.Add(timeTable);
            treeFunctionList.Nodes.Add(finance);
            treeFunctionList.Nodes.Add(store);
            treeFunctionList.Nodes.Add(info);

            tabControl.TabPages.Clear();
        }
        public void getUserInfo(NhanVien guest)
        {
            user = guest;
        }
        private void ManagerUI_Load(object sender, EventArgs e)
        {
            //Tạo sơ đồ dạng cây
            loadTreeView();

            //Cập nhật thông tin người đăng nhập
            txtUserID.Text = user.MaNV.ToString();
            txtUserName.Text = user.HoTen;
            txtUserPosition.Text = user.TenLoaiNV;

            //Thiết lập cho việc xem phiếu kiểm kho
            cbLoaiPhieuXem.SelectedIndex = 0;
            

            //Thiết lập cho việc tạo phiếu kiểm kho
            cbLoaiPhieuTao.SelectedIndex = 0;
        }


        private void treeFunctionList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tabControl.TabPages.Clear();
            //treeFunctionList.SelectedNode.SelectedImageIndex = 0 ? 1 : treeFunctionList.SelectedNode.SelectedImageIndex;
            switch (treeFunctionList.SelectedNode.SelectedImageIndex)
            {
                case 1:
                    tabControl.TabPages.Add(tabLichLam);
                    break;
                case 2:
                case 21:
                    tabControl.TabPages.Add(tabTinhHinhTaiChinh);
                    break;
                case 3:
                    tabControl.TabPages.Add(tabKiemKho);
                    tabControl.TabPages.Add(tabNhapKho);
                    tabControl.TabPages.Add(tabThongTinKho);
                    break;
                case 31:
                    tabControl.TabPages.Add(tabKiemKho);
                    tabControl.TabPages.Add(tabNhapKho);
                    tabControl.TabPages.Add(tabThongTinKho);
                    tabControl.SelectedTab = tabKiemKho;
                    break;
                case 32:
                    tabControl.TabPages.Add(tabKiemKho);
                    tabControl.TabPages.Add(tabNhapKho);
                    tabControl.TabPages.Add(tabThongTinKho);
                    tabControl.SelectedTab = tabNhapKho;
                    break;
                case 33:
                    tabControl.TabPages.Add(tabKiemKho);
                    tabControl.TabPages.Add(tabNhapKho);
                    tabControl.TabPages.Add(tabThongTinKho);
                    tabControl.SelectedTab = tabThongTinKho;
                    break;
                case 4:
                    tabControl.TabPages.Add(tabSanPham);
                    tabControl.TabPages.Add(tabNguyenLieu);
                    tabControl.TabPages.Add(tabNhanVien);
                    tabControl.TabPages.Add(tabKhachHang);
                    break;
                case 41:
                    tabControl.TabPages.Add(tabSanPham);
                    tabControl.TabPages.Add(tabNguyenLieu);
                    tabControl.TabPages.Add(tabNhanVien);
                    tabControl.TabPages.Add(tabKhachHang);
                    tabControl.SelectedTab = tabSanPham;
                    break;
                case 42:
                    tabControl.TabPages.Add(tabSanPham);
                    tabControl.TabPages.Add(tabNguyenLieu);
                    tabControl.TabPages.Add(tabNhanVien);
                    tabControl.TabPages.Add(tabKhachHang);
                    tabControl.SelectedTab = tabNguyenLieu;
                    break;
                case 43:
                    tabControl.TabPages.Add(tabSanPham);
                    tabControl.TabPages.Add(tabNguyenLieu);
                    tabControl.TabPages.Add(tabNhanVien);
                    tabControl.TabPages.Add(tabKhachHang);
                    tabControl.SelectedTab = tabNhanVien;
                    break;
                case 44:
                    tabControl.TabPages.Add(tabSanPham);
                    tabControl.TabPages.Add(tabNguyenLieu);
                    tabControl.TabPages.Add(tabNhanVien);
                    tabControl.TabPages.Add(tabKhachHang);
                    tabControl.SelectedTab = tabKhachHang;
                    break;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dtpNgayLapPhieu.Value = DateTime.Now;
        }

        private void btnXemPhieu_Click(object sender, EventArgs e)
        {
            DSphieuKiemKho phieu_kk = new DSphieuKiemKho();
            phieu_kk.loai_phieu = cbLoaiPhieuXem.GetItemText(cbLoaiPhieuXem.SelectedItem);

            StoreCheckBUS bus = new StoreCheckBUS();
            phieu_kk = bus.getStoreCheckReportList(phieu_kk);

            dtDSPhieu.DataSource = phieu_kk.danh_sach_phieu;
            
            dtDSPhieu.ForeColor = Color.Black;
            dtDSPhieu.Font = new Font("Arial", 9, FontStyle.Regular);
            dtDSPhieu.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            dtDSPhieu.Columns["Mã phiếu"].Width = 55;
            dtDSPhieu.Columns["Loại phiếu"].Width = 90;
            dtDSPhieu.Columns["Mã nhân viên"].Width = 55;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dtDSPhieu_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show(dtDSPhieu.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void dtDSPhieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           string ma_phieu = (dtDSPhieu.SelectedRows[0].Cells[0].Value.ToString());
            
        }
// ================= Nghia ==========================================================
        private void ManagerUI_Activated(object sender, EventArgs e)
        {
            load_info_SP();
            load_info_NL();
            load_info_NV();
        }
        private void load_info_SP()
        {
            DataTable dt = new DataTable();
            SanPhamBUS spBUS = new SanPhamBUS();
            dt = spBUS.Load_info_SP();
            dgv_info_SanPham.DataSource = dt;
            dgv_info_SanPham.Columns[0].HeaderText = "Mã SP";
            dgv_info_SanPham.Columns[1].HeaderText = "Tên SP";
            dgv_info_SanPham.Columns[2].HeaderText = "Giá bán";
            dgv_info_SanPham.Columns[3].HeaderText = "Loại SP";
            dgv_info_SanPham.Columns[4].HeaderText = "Mã loại SP";

            for (int i = 0; i < dgv_info_SanPham.ColumnCount; i++)
            {
                dgv_info_SanPham.AutoResizeColumn(i);
            }
            dgv_info_SanPham.ReadOnly = true;
            dgv_info_SanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void load_info_NL()
        {
            
            DataTable dt = new DataTable();
            NguyenLieuBUS nlBus = new NguyenLieuBUS();
            dt = nlBus.Load_info_NL();
            dgv_info_NguyenLieu.DataSource = dt;
            dgv_info_NguyenLieu.Columns[0].HeaderText = "Mã NL";
            dgv_info_NguyenLieu.Columns[1].HeaderText = "Tên NL";
            dgv_info_NguyenLieu.Columns[2].HeaderText = "Đơn vị";

            for(int i = 0; i < dgv_info_NguyenLieu.ColumnCount; i++)
            {
                dgv_info_NguyenLieu.AutoResizeColumn(i);
            }
            dgv_info_NguyenLieu.ReadOnly = true;
            dgv_info_NguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void load_info_NV()
        {
            DataTable dt = new DataTable();
            NhanVienBUS nvBus = new NhanVienBUS();
            dt = nvBus.Load_info_NV();
            dgv_info_NhanVien.DataSource = dt;
            dgv_info_NhanVien.Columns[0].HeaderText = "Mã NV";
            dgv_info_NhanVien.Columns[1].HeaderText = "Họ tên NV";
            dgv_info_NhanVien.Columns[2].HeaderText = "CMND";
            dgv_info_NhanVien.Columns[3].HeaderText = "số ĐT";
            dgv_info_NhanVien.Columns[4].HeaderText = "Địa chỉ";
            dgv_info_NhanVien.Columns[5].HeaderText = "Email";
            dgv_info_NhanVien.Columns[6].HeaderText = "Tên loại NV";
            dgv_info_NhanVien.Columns[7].HeaderText = "Lương/giờ";
            dgv_info_NhanVien.Columns[8].HeaderText = "Tình trạng";

            for(int i=0;i<dgv_info_NhanVien.ColumnCount;i++)
            {
                dgv_info_NhanVien.AutoResizeColumn(i);
            }
            dgv_info_NhanVien.ReadOnly = true;
            dgv_info_NhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btn_themSP_Click(object sender, EventArgs e)
        {
            PizzaManagement.ThemMoiSP f = new ThemMoiSP();
            f.Show();
        }

        private void btn_SuaSP_Click(object sender, EventArgs e)
        {
            int masp = Convert.ToInt32(dgv_info_SanPham.CurrentRow.Cells[0].FormattedValue.ToString());
            int check = Convert.ToInt32(dgv_info_SanPham.CurrentRow.Cells[4].FormattedValue.ToString()) - 1;
            string tensp = dgv_info_SanPham.CurrentRow.Cells[1].FormattedValue.ToString();
            int gia = Convert.ToInt32(dgv_info_SanPham.CurrentRow.Cells[2].FormattedValue.ToString());
            PizzaManagement.SuaSP f = new SuaSP(masp, check, tensp, gia);
            f.Show();
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            string maSP;
            string tenSP;
            maSP = dgv_info_SanPham.CurrentRow.Cells[0].FormattedValue.ToString();
            tenSP = dgv_info_SanPham.CurrentRow.Cells[1].FormattedValue.ToString();
            int a = dgv_info_SanPham.CurrentCell.RowIndex;
            DialogResult result = MessageBox.Show(String.Format("Bạn có chắc chắn muốn xoá sản phẩm {0} ra khỏi danh sách?", tenSP), "Xác nhận",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Info_SanPham_DTO spDto = new Info_SanPham_DTO(Convert.ToInt32(maSP), null, 0, 0);
                try
                {
                    spBus.deleteSP(spDto);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                };
                MessageBox.Show("Xoá thành công!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgv_info_SanPham.Rows[a-1].Selected = true;
                dgv_info_SanPham.FirstDisplayedScrollingRowIndex = a-1;
            }
        }

        private void stripMenu_suaSP_Click(object sender, EventArgs e)
        {
            btn_SuaSP_Click(null, null);
        }

        private void stripMenu_xoaSP_Click(object sender, EventArgs e)
        {
            btn_XoaSP_Click(null, null);
        }

        private void dgv_info_SanPham_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                dgv_info_SanPham.CurrentCell = dgv_info_SanPham.Rows[e.RowIndex].Cells[e.ColumnIndex];

                dgv_info_SanPham.Rows[e.RowIndex].Selected = true;
                dgv_info_SanPham.Focus();
            }
        }



        private void btn_themNL_Click(object sender, EventArgs e)
        {
            PizzaManagement.ThemMoiNL f2 = new ThemMoiNL();
            f2.Show();

        }

        private void btn_SuaNL_Click(object sender, EventArgs e)
        {
            int maNL = Convert.ToInt32(dgv_info_NguyenLieu.CurrentRow.Cells[0].FormattedValue.ToString());
            string tenNL = dgv_info_NguyenLieu.CurrentRow.Cells[1].FormattedValue.ToString();
            string donVi = dgv_info_NguyenLieu.CurrentRow.Cells[2].FormattedValue.ToString();
            PizzaManagement.SuaNL f2 = new SuaNL(maNL, tenNL, donVi);
            f2.Show();
        }

        private void btn_XoaNL_Click(object sender, EventArgs e)
        {
            string maNL;
            string tenNL;
            maNL = dgv_info_NguyenLieu.CurrentRow.Cells[0].FormattedValue.ToString();
            tenNL = dgv_info_NguyenLieu.CurrentRow.Cells[1].FormattedValue.ToString();
            int a = dgv_info_NguyenLieu.CurrentCell.RowIndex;
            DialogResult result = MessageBox.Show(String.Format("Bạn có chắc chắn muốn xoá nguyên liệu {0} ra khỏi danh sách?", tenNL), "Xác nhận",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Info_NguyenLieu_DTO nlDto = new Info_NguyenLieu_DTO(Int32.Parse(maNL), null, null);
                try
                {
                    nlBus.deleteNL(nlDto);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                };
                MessageBox.Show("Xoá thành công!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgv_info_NguyenLieu.Rows[a - 1].Selected = true;
                dgv_info_NguyenLieu.FirstDisplayedScrollingRowIndex = a - 1;
            }
        }

        private void StripMenu_SuaNL_Click(object sender, EventArgs e)
        {
            btn_SuaNL_Click(null, null);
        }

        private void StripMenu_XoaNL_Click(object sender, EventArgs e)
        {
            btn_XoaNL_Click(null, null);
        }

        private void dgv_info_NguyenLieu_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgv_info_NguyenLieu.CurrentCell = dgv_info_NguyenLieu.Rows[e.RowIndex].Cells[e.ColumnIndex];

                dgv_info_NguyenLieu.Rows[e.RowIndex].Selected = true;
                dgv_info_NguyenLieu.Focus();
            }
        }


        private void btn_themNV_Click(object sender, EventArgs e)
        {
            PizzaManagement.ThemNV f3 = new ThemNV();
            f3.Show();
        }

        private void btn_suaNV_Click(object sender, EventArgs e)
        {
            int maNV = Convert.ToInt32(dgv_info_NhanVien.CurrentRow.Cells[0].FormattedValue.ToString());
            string tenNV = dgv_info_NhanVien.CurrentRow.Cells[1].FormattedValue.ToString();
            string cmnd = dgv_info_NhanVien.CurrentRow.Cells[2].FormattedValue.ToString();
            string sdt = dgv_info_NhanVien.CurrentRow.Cells[3].FormattedValue.ToString();
            string diachi = dgv_info_NhanVien.CurrentRow.Cells[4].FormattedValue.ToString();
            string email = dgv_info_NhanVien.CurrentRow.Cells[5].FormattedValue.ToString();
            try
            {
                int check_loainv = Convert.ToInt32(dgv_info_NhanVien.CurrentRow.Cells[6].FormattedValue.ToString())-1;
                int check_tinhtrang = Convert.ToInt32(dgv_info_NhanVien.CurrentRow.Cells[8].FormattedValue.ToString())-1;
                PizzaManagement.SuaNV f3 = new SuaNV(maNV, tenNV, cmnd, sdt, diachi, email, check_loainv, check_tinhtrang);
                f3.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi ở đây");
            }
            

            
            
        }



        //private void getCurrentCellButton_Click(object sender, System.EventArgs e)
        //{
        //    string msg = String.Format("Row: {0}, Column: {1}",
        //        dataGridView1.CurrentCell.RowIndex,
        //        dataGridView1.CurrentCell.ColumnIndex);
        //    MessageBox.Show(msg, "Current Cell");
        //}


        // ========================Nghia =========================================================================
    }
}
