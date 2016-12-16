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
    public partial class SuaNL : Form
    {
        private NguyenLieuBUS nlBus;
        public SuaNL(int _manl,string _tennl, string _donvi)
        {
            InitializeComponent();
            nlBus = new NguyenLieuBUS();
            txtMaNL.Text = Convert.ToString(_manl);
            txtInfoTenNL.Text = _tennl;
            txtInfoDonVi.Text = _donvi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa nguyên liệu này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.OK)
            {
                Info_NguyenLieu_DTO nlDto = new Info_NguyenLieu_DTO(Int32.Parse(txtMaNL.Text),txtInfoTenNL.Text,txtInfoDonVi.Text);
                try
                {
                    nlBus.editNL(nlDto);
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

        private void SuaNL_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }
    }
}
