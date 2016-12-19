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
    public partial class ThemNV : Form
    {
        private NhanVienBUS nvBus;
        public ThemNV()
        {
            InitializeComponent();
            nvBus = new NhanVienBUS();
            DataTable dt1 = new DataTable();
            dt1 = nvBus.Load_tinhTrang();
            cbInfoTinhTrang.DataSource = dt1;
            cbInfoTinhTrang.DisplayMember = "TenTinhTrang";
            cbInfoTinhTrang.ValueMember = "MaTinhTrang";

            DataTable dt2 = new DataTable();
            dt2 = nvBus.Load_loaiNV();
            cbInfoLoaiNV.DataSource = dt2;
            cbInfoLoaiNV.DisplayMember = "TenLoai";
            cbInfoLoaiNV.ValueMember = "MaLoai";
        }

        private void ThemNV_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
== DialogResult.OK)
            {
                NhanVien nvDto = new NhanVien(0, txtInfoTenNV.Text, txtInfoCMND.Text, txtInfoDTNV.Text, txtInfoDiaChiNV.Text, txtInfoEmailNV.Text,
                    Convert.ToInt32(cbInfoLoaiNV.SelectedValue.ToString()), txtInfoMatKhauNV.Text, Convert.ToInt32(cbInfoTinhTrang.SelectedValue.ToString()));
                try
                {
                    nvBus.addNV(nvDto);
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
