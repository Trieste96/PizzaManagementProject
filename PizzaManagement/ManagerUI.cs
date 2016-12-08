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
            PhieuKiemKho phieu_kk = new PhieuKiemKho();
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
    }
}
