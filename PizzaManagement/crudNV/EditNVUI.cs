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
    public partial class SuaNV : Form
    {
        private NhanVienBUS nvBus;
        public SuaNV(int _manv,string _tennv,string _cmnd,string _dt,string _diachi,string _email,int _chkloainv,int _chktinhtrang)
        {
            InitializeComponent();
            nvBus = new NhanVienBUS();
            DataTable dt1 = new DataTable();
            dt1 = nvBus.Load_tinhTrang();
            cbInfoTinhTrang.DataSource = dt1;
            cbInfoTinhTrang.SelectedIndex = _chktinhtrang;
            cbInfoTinhTrang.DisplayMember = "TenTinhTrang";
            cbInfoTinhTrang.ValueMember = "MaTinhTrang";

            DataTable dt2 = new DataTable();
            dt2 = nvBus.Load_loaiNV();
            cbInfoLoaiNV.DataSource = dt2;
            cbInfoLoaiNV.SelectedIndex = _chkloainv;
            cbInfoLoaiNV.DisplayMember = "TenLoai";
            cbInfoLoaiNV.ValueMember = "MaLoai";

            txtInfoMaNV.Text = Convert.ToString(_manv);
            txtInfoTenNV.Text = _tennv;
            txtInfoCMND.Text = _cmnd;
            txtInfoDTNV.Text = _dt;
            txtInfoDiaChiNV.Text = _diachi;
            txtInfoEmailNV.Text = _email;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.OK)
            {
                NhanVien nvDto = new NhanVien(Convert.ToInt32(txtInfoMaNV.Text),txtInfoTenNV.Text,txtInfoCMND.Text,txtInfoDTNV.Text,txtInfoDiaChiNV.Text,txtInfoEmailNV.Text,
                    Convert.ToInt32(cbInfoLoaiNV.SelectedValue.ToString()),null, Convert.ToInt32(cbInfoTinhTrang.SelectedValue.ToString()));
                try
                {
                    nvBus.editNV(nvDto);
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

        private void SuaNV_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

    }
}
