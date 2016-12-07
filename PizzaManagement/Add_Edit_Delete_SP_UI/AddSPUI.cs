using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace PizzaManagement
{
    public partial class AddSPUI : Form
    {
        private SanPhamBUS spBus;
        public AddSPUI()
        {
            InitializeComponent();
            spBus = new SanPhamBUS();
            DataTable dt = new DataTable();
            dt = spBus.Load_loaiSP();
            cbInfoLoaiSP.DataSource = dt;
            cbInfoLoaiSP.DisplayMember = "TenLoai";
            cbInfoLoaiSP.ValueMember = "MaLoai";
        }

        private void ThemMoiSP_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm sản phẩm này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.OK)
            {
                Info_SanPham_DTO spDTO = new Info_SanPham_DTO(0, txtInfoTenSP.Text, Int32.Parse(txtInfoGia.Text), Convert.ToInt32(cbInfoLoaiSP.SelectedValue.ToString()));
                try
                {
                    spBus.addSP(spDTO);
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

        private void ThemMoiSP_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
