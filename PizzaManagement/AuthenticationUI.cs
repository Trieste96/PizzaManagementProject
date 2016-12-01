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
            Match m = re.Match(txtMatKhau.Text);
            if(m.Success)
            {
                MessageBox.Show("ID không hợp lệ, vui lòng nhập lại", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(txtMaNV.Text);
                string passwd = txtMatKhau.Text;
                NhanVien user = new NhanVien();
                user.MaNV = id;
                user.MatKhau = passwd;
                user.TenLoaiNV = cbQuyen.SelectedText;

                AuthenticationBUS bus = new AuthenticationBUS();
                user = bus.verifyAccount(user);
                if (user.TinhTrang == 0)
                {
                    MessageBox.Show("Không đúng");
                }
                else
                {
                    MessageBox.Show(String.Format("Mã NV:{0}\nHọ tên:{1}\nLoại NV:{2}", user.MaNV, user.HoTen, user.TenLoaiNV));
                }
            }          
        }
    }
}
