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
    public partial class ThemMoiSP : Form
    {
        private SanPhamBUS spBus;
        public ThemMoiSP()
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
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm sản phẩm này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.OK)
            {
                try
                {
                    Info_SanPham_DTO spDTO = new Info_SanPham_DTO(0, txtInfoTenSP.Text, Int32.Parse(txtInfoGia.Text), Convert.ToInt32(cbInfoLoaiSP.SelectedValue.ToString()));
                    spBus.addSP(spDTO);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch(FormatException)
                {
                    MessageBox.Show("Kiển tra dữ liệu nhập vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Thêm sản phẩm thành công", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void button1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        button1_Click(null, null);
        //    }
        //}

        private void txtInfoGia_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
