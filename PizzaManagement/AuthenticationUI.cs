﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace PizzaManagement
{
    public partial class AuthenticationUI : Form
    {
        public NhanVien user;
        public bool switchToMangerUI = false;
        public AuthenticationUI()
        {
            InitializeComponent();
        }
        private void AuthenticationUI_Load(object sender, EventArgs e)
        {
            PositionListBUS bus = new PositionListBUS();
            DataTable dt;
            try
            {
                dt = bus.loadPositionList();
                cbQuyen.DataSource = dt;
                cbQuyen.DisplayMember = "TenLoai";
                cbQuyen.ValueMember = "MaLoai";
                cbQuyen.SelectedValue = 1;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối với CSDL!", "Mất kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            } 
         }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra tính hợp lệ của id
            string idPattern = @"^[0-9]+$";
            Regex re = new Regex(idPattern);

            if ( !re.IsMatch(txtMaNV.Text) )
            {
                MessageBox.Show("ID không hợp lệ, vui lòng nhập lại", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string passwd = txtMatKhau.Text;
                NhanVien guest = new NhanVien();
                guest.MaNV = Convert.ToInt32(txtMaNV.Text);
                guest.MatKhau = passwd;
                guest.MaLoaiNV = Convert.ToInt32(cbQuyen.SelectedValue);

                AuthenticationBUS bus = new AuthenticationBUS();
                guest = bus.verifyAccount(guest);
                if (guest.TinhTrang == 0)
                {
                    MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin đăng nhập", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    user = guest;
                    switchToMangerUI = true;
                    this.Close();
                }
            }
        }
    }
}
