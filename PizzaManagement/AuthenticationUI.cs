using System;
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
        public bool switchToManagerUI = false;
        public bool switchToCsrUI = false;
        public AuthenticationUI()
        {
            InitializeComponent();
        }
        private void AuthenticationUI_Load(object sender, EventArgs e)
        {
            switchToManagerUI = false;
            switchToCsrUI = false;
            this.AcceptButton = btnDangNhap;
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
                guest.ma_NV = Convert.ToInt32(txtMaNV.Text);
                guest.mat_khau = passwd;
                //guest.MaLoaiNV = Convert.ToInt32(cbQuyen.SelectedValue);
                
                AuthenticationBUS bus = new AuthenticationBUS();
                guest = bus.verifyAccount(guest);
                if (guest.tinh_trang == 0)
                {
                    MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin đăng nhập", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    user = guest;
                    if (user.ten_loai_nv == "Quản lý")
                    {
                        switchToManagerUI = true;
                    }
                    else if(user.ten_loai_nv == "CSR")
                    {
                        switchToCsrUI = true;
                    }
                    
                    MessageBox.Show("Đăng nhập thành công! Nhấn OK", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Dispose();
                }
            }
        }

    }
}
