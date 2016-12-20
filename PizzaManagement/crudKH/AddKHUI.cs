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
    public partial class ThemKH : Form
    {
        KhachHangBUS khBus = new KhachHangBUS();
        public ThemKH()
        {
            InitializeComponent();
            khBus = new KhachHangBUS();
            DataTable dt = new DataTable();
            dt = khBus.Load_loaiKH();
            cbInfoLoaiKH.DataSource = dt;
            cbInfoLoaiKH.DisplayMember = "TenLoai";
            cbInfoLoaiKH.ValueMember = "MaLoai";
        }

        private void ThemKH_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm khách hàng này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        == DialogResult.OK)
            {
                Info_KhachHang_DTO khDto = new Info_KhachHang_DTO(0,txtInfoTenKH.Text,txtInfoDiaChi.Text,txtInfoEmail.Text,
                    txtInfoSoDT.Text,Convert.ToInt32(cbInfoLoaiKH.SelectedValue.ToString()));
                try
                {
                    khBus.addKH(khDto);
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
