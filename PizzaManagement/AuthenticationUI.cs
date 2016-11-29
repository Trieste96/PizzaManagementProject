using System;
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
    public partial class AuthenticationUI : Form
    {
        public AuthenticationUI()
        {
            InitializeComponent();
        }

        private void AuthenticationUI_Load(object sender, EventArgs e)
        {
            cbQuyen.Items.Add("Quản lý nhà hàng");
            cbQuyen.Items.Add("CSR");
            cbQuyen.Items.Add("Khác");
            cbQuyen.SelectedIndex = 0;
         }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string id = txtMaNV.Text;
            string passwd = txtMatKhau.Text;
            NhanVien user = new NhanVien();
            user.MaNV = id;
            user.MatKhau = passwd;
            switch(cbQuyen.SelectedIndex)
            {
                //TH người đăng nhập là: 
                //Quản lý
                case 0: user.MaNV = 8;
                    break;
                //CSR
                case 1: user.MaNV = 5;
                    break;
                //Khác
                case 2; user.MaNV = 0;
                    break;
            }

            AuthenticationBUS bus = new AuthenticationBUS();
            bus.verifyAccount(user);
    }
}
