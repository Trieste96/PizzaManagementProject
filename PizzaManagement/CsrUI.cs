﻿using System;
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
    public partial class CsrUI : Form
    {
        private NhanVien user;
        public CsrUI()
        {
            InitializeComponent();
        }

        public void getUserInfo(NhanVien guest)
        {
            user = guest;
        }

        private void CsrUI_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = user.ma_NV.ToString();
            txtHoTenNV.Text = user.ho_ten;
            txtViTri.Text = user.ten_loai_nv;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void additem_Click(object sender, EventArgs e)
        {
            //AddItemUI form = new AddItemUI();
            //form.Show();
        }
    }
}
