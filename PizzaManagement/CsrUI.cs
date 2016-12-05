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
            txtMaNV.Text = user.MaNV.ToString();
            txtHoTenNV.Text = user.HoTen;
            txtViTri.Text = user.TenLoaiNV;
        }
    }
}
