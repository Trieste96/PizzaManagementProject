﻿using BUS;
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
    public partial class EditSPUI : Form
    {
        private SanPhamBUS spBus;
        public EditSPUI(int _masp,int _check, string _tensp, int _gia)
        {
            InitializeComponent();
            spBus = new SanPhamBUS();
            DataTable dt = new DataTable();
            dt = spBus.Load_loaiSP();
            cbInfoLoaiSP.DataSource = dt;
            cbInfoLoaiSP.SelectedIndex = _check;
            cbInfoLoaiSP.DisplayMember = "TenLoai";
            cbInfoLoaiSP.ValueMember = "MaLoai";
            txtInfoTenSP.Text = _tensp;
            txtInfoGia.Text = Convert.ToString(_gia);
            txtInfoMaSP.Text = Convert.ToString(_masp);
        }


        private void SuaSP_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa sản phẩm này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.OK)
            {
                Info_SanPham_DTO spDTO = new Info_SanPham_DTO(Int32.Parse(txtInfoMaSP.Text), txtInfoTenSP.Text, Int32.Parse(txtInfoGia.Text), Convert.ToInt32(cbInfoLoaiSP.SelectedValue.ToString()));
                try
                {
                    spBus.editSP(spDTO);
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
            this.Close();
        }
    }
}
