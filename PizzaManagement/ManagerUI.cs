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

namespace PizzaManagement
{
    public partial class ManagerUI : Form
    {
        //Thông tin của nngười đăng nhập vào hệ thống được lưu ở biến user này
        private NhanVien user;
        
        public ManagerUI()
        {
            InitializeComponent();
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
            loadTreeView();
            txtUserID.Text = user.MaNV.ToString();
            txtUserName.Text = user.HoTen;
            txtUserPosition.Text = user.TenLoaiNV;

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

        private void treeFunctionList_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnXemPhieu_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtpNgayLapPhieu.Value = DateTime.Now;
        }
    }
}
