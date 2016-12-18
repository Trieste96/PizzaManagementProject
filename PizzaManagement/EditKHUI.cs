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
    public partial class SuaKH : Form
    {
        private KhachHangBUS khBus;
        public SuaKH(int _makh, string _tenkh,string _diachi,string _email,string _sdt,int _maloaikh)
        {
            InitializeComponent();
            khBus = new KhachHangBUS();
            DataTable dt = new DataTable();
            dt = khBus.Load_loaiKH();
            cbInfoLoaiKH.DataSource = dt;
            cbInfoLoaiKH.SelectedIndex = _maloaikh;
            cbInfoLoaiKH.DisplayMember = "TenLoai";
            cbInfoLoaiKH.ValueMember = "MaLoai";
            txtInfoMaKH.Text = Convert.ToString(_makh);
            txtInfoTenKH.Text = _tenkh;
            txtInfoDiaChi.Text = _diachi;
            txtInfoEmail.Text = _email;
            txtInfoSoDT.Text = _sdt;
        }

        private void EditKHUI_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa khách hàng này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.OK)
            {
                Info_KhachHang_DTO khDto = new Info_KhachHang_DTO(Convert.ToInt32(txtInfoMaKH.Text),txtInfoTenKH.Text,txtInfoDiaChi.Text,txtInfoEmail.Text,txtInfoSoDT.Text,
                   Convert.ToInt32(cbInfoLoaiKH.SelectedValue.ToString()));
                try
                {
                    khBus.editKH(khDto);
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
