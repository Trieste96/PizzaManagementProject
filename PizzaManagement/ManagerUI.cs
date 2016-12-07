using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaManagement
{
    public partial class ManagerUI : Form
    {
        private SanPhamBUS spBus;
        public ManagerUI()
        {
            InitializeComponent();
            spBus = new SanPhamBUS();
            //load_info_SP();
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
        private void ManagerUI_Load(object sender, EventArgs e)
        {
            loadTreeView();
            ImageList list = new ImageList();
        }


        private void treeFunctionList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tabControl.TabPages.Clear();
             
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

        private void treeFunctionList_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

// ------------ NGHIA ---------------------------
                private void ManagerUI_Activated(object sender, EventArgs e)
        {
            load_info_SP();
        }
        private void load_info_SP()
        {
            DataTable dt = new DataTable();
            SanPhamBUS spBUS = new SanPhamBUS();
            dt = spBUS.Load_info_SP();
            table_info_SP.DataSource = dt;
            table_info_SP.Columns[0].HeaderText = "Mã SP";
            table_info_SP.Columns[1].HeaderText = "Tên SP";
            table_info_SP.Columns[2].HeaderText = "Giá bán";
            table_info_SP.Columns[3].HeaderText = "Loại SP";
            table_info_SP.Columns[4].HeaderText = "Mã loại SP";

            for (int i = 0; i < table_info_SP.ColumnCount; i++)
            {
                table_info_SP.AutoResizeColumn(i);
            }
            table_info_SP.ReadOnly = true;
            //table_info_SP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void btn_info_addSP_Click(object sender, EventArgs e)
        {
            AddSPUI f = new AddSPUI();
            f.Show();
        }

        private void btn_info_editSP_Click(object sender, EventArgs e)
        {
            int masp = Convert.ToInt32(table_info_SP.CurrentRow.Cells[0].FormattedValue.ToString());
            int check = Convert.ToInt32(table_info_SP.CurrentRow.Cells[4].FormattedValue.ToString()) - 1;
            string tensp = table_info_SP.CurrentRow.Cells[1].FormattedValue.ToString();
            int gia = Convert.ToInt32(table_info_SP.CurrentRow.Cells[2].FormattedValue.ToString());
            PizzaManagement.EditSPUI f2 = new EditSPUI(masp, check, tensp, gia);
            f2.Show();
        }

        private void btn_info_deleteSP_Click(object sender, EventArgs e)
        {
            string maSP;
            string tenSP;
            maSP = table_info_SP.CurrentRow.Cells[0].FormattedValue.ToString();
            tenSP = table_info_SP.CurrentRow.Cells[1].FormattedValue.ToString();
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
            }
        }

        private void table_info_SP_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                table_info_SP.CurrentCell = table_info_SP.Rows[e.RowIndex].Cells[e.ColumnIndex];
                table_info_SP.Rows[e.RowIndex].Selected = true;
                table_info_SP.Focus();
            }
        }

        private void sửaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_info_editSP_Click(null, null);
        }

        private void xóaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_info_deleteSP_Click(null, null);
        }
        // -------------------------------------------------------------------------------------------------
    }
}
