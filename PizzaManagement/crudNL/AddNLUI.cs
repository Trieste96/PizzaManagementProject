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
    public partial class ThemMoiNL : Form
    {
        private NguyenLieuBUS nlBus;
        public ThemMoiNL()
        {
            InitializeComponent();
            nlBus = new NguyenLieuBUS();
        }

        private void ThemMoiNL_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thêm nguyên liệu này?","Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Info_NguyenLieu_DTO nlDTO = new Info_NguyenLieu_DTO(0,txtInfoTenNL.Text,txtInfoDonVi.Text);
                try
                {
                    nlBus.addNL(nlDTO);
                }
                //catch (Exception)
                //{
                //    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                catch (FormatException)
                {
                    MessageBox.Show("Kiểm tra dữ liệu đầu vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Thêm nguyên liệu thành công", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
