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
            MessageBox.Show(cbQuyen.SelectedIndex.ToString());
        }
    }
}
