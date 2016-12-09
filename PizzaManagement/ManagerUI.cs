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
        public ManagerUI()
        {
            InitializeComponent();
            spBus = new SanPhamBUS();
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
            txtUserID.Text = user.ma_NV.ToString();
            txtUserName.Text = user.ho_ten;
            txtUserPosition.Text = user.ten_loai_nv;

            //Thiết lập cho việc xem phiếu kiểm kho
            cbLoaiPhieuXem.SelectedIndex = 0;
            

            //Thiết lập cho việc tạo phiếu kiểm kho
            cbLoaiPhieuTao.SelectedIndex = 0;
        }


        private void treeFunctionList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tabControl.TabPages.Clear();  
            try
            {
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
            catch (NullReferenceException)
            {
                //doing shit
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dtpNgayLapPhieu.Value = DateTime.Now;
        }

        private void btnXemPhieu_Click(object sender, EventArgs e)
        {
            DSphieuKiemKho ds_pkk = new DSphieuKiemKho();
            ds_pkk.loai_phieu = cbLoaiPhieuXem.GetItemText(cbLoaiPhieuXem.SelectedItem);

            StoreCheckBUS bus = new StoreCheckBUS();
            ds_pkk = bus.getStoreCheckReportList(ds_pkk);

            dtDSPhieu.DataSource = ds_pkk.danh_sach_phieu;
            
            dtDSPhieu.ForeColor = Color.Black;
            dtDSPhieu.Font = new Font("Arial", 9, FontStyle.Regular);
            dtDSPhieu.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            //Mặc định chọn dòng đầu

            try
            {
                dtDSPhieu.Rows[0].Selected = true;

                //Hiện chi tiết phiếu đầu tiên
                dtDSPhieu_CellDoubleClick(null, null);
            }
            catch (ArgumentOutOfRangeException)
            {
                //do nothing
            }

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
            try
            {
                int ma_phieu = Convert.ToInt32(dtDSPhieu.SelectedRows[0].Cells[0].Value.ToString());
                PhieuKiemKho pkk = new PhieuKiemKho();
                pkk.ma_phieu = ma_phieu;

                StoreCheckBUS bus = new StoreCheckBUS();
                pkk = bus.getCheckReportDetail(pkk);

                dtChiTietPhieuTK.DataSource = pkk.chi_tiet_phieu;
                dtChiTietPhieuTK.ForeColor = Color.Black;
                dtChiTietPhieuTK.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dtChiTietPhieuTK.Font = new Font("Arial", 12, FontStyle.Regular);
                lblMaPhieu.Text = dtDSPhieu.SelectedRows[0].Cells[0].Value.ToString();

                dtChiTietPhieuTK.Columns[0].ReadOnly = true;
                dtChiTietPhieuTK.Columns[1].ReadOnly = true;
            }
            catch (ArgumentOutOfRangeException)
            {

                //doing shit
            }
        }

        private void ManagerUI_Activated(object sender, EventArgs e)
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

        private void btn_themSP_Click(object sender, EventArgs e)
        {
            PizzaManagement.ThemMoiSP f = new ThemMoiSP();
            f.Show();
        }

        private void tabKiemKho_Click(object sender, EventArgs e)
        {
            btnXemPhieu_Click(null, null);
        }

        private void tabKiemKho_ControlAdded(object sender, ControlEventArgs e)
        {
            btnXemPhieu_Click(null, null);
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            PhieuKiemKho phieu_moi = new PhieuKiemKho();
            phieu_moi.ma_nv = user.ma_NV;
            phieu_moi.ngay_gio = dtpNgayLapPhieu.Value;
            phieu_moi.ma_loai_phieu = cbLoaiPhieuTao.SelectedIndex + 1;

            StoreCheckBUS bus = new StoreCheckBUS();
            int id_new_row = bus.createNewStoreReport(phieu_moi);
            if(id_new_row !=0 )
            {
                MessageBox.Show(String.Format("Phiếu {0} đã được tạo", id_new_row.ToString()), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
                btnXemPhieu_Click(null, null);
                dtDSPhieu_CellDoubleClick(null, null);
            }
            else
            {
                MessageBox.Show(String.Format("Đã tồn tại phiếu cùng loại vào cùng ngày {0}!", phieu_moi.ngay_gio.ToString("dd-MM-yyyy")), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnXemPhieu_Click(null, null);
            }
            
        }

        private void btnXemChiTietPhieu_Click(object sender, EventArgs e)
        {
            dtDSPhieu_CellDoubleClick(null, null);
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                int ma_phieu = Convert.ToInt32(dtDSPhieu.SelectedRows[0].Cells[0].Value);
                DialogResult confirm = MessageBox.Show(String.Format("Bạn có muốn xoá phiếu {0} không?", ma_phieu), "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK)
                {
                    PhieuKiemKho pkk = new PhieuKiemKho();
                    pkk.ma_phieu = ma_phieu;
                    StoreCheckBUS bus = new StoreCheckBUS();
                    if (bus.deleteReport(pkk) > 0)
                    {
                        MessageBox.Show(String.Format("Xoá phiếu {0} thành công!", ma_phieu), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btnXemPhieu_Click(null, null);
                        btnXemChiTietPhieu_Click(null, null);
                    }
                    else
                        MessageBox.Show(String.Format("Xoá phiếu {0} không thành công!", ma_phieu), "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                //do nothing
            }
        }
    }
}
