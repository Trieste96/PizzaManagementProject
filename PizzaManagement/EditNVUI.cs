using BUS;
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
    public partial class SuaNV : Form
    {
        private NhanVienBUS nvBus;
        public SuaNV(int _manv,string _tennv,string _cmnd,string _dt,string _diachi,string _email,int _chkloainv,int _chktinhtrang)
        {
            InitializeComponent();
            nvBus = new NhanVienBUS();
            DataTable dt1 = new DataTable();
            dt1 = nvBus.Load_tinhTrang();
            cbInfoTinhTrang.DataSource = dt1;
            cbInfoTinhTrang.SelectedIndex = _chktinhtrang;
            cbInfoTinhTrang.DisplayMember = "TenTinhTrang";
            cbInfoTinhTrang.ValueMember = "MaTinhTrang";

            DataTable dt2 = new DataTable();
            dt2 = nvBus.Load_loaiNV();
            cbInfoLoaiNV.DataSource = dt2;
            cbInfoLoaiNV.SelectedIndex = _chktinhtrang;
            cbInfoLoaiNV.DisplayMember = "TenLoai";
            cbInfoLoaiNV.ValueMember = "MaLoai";
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SuaNV_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

    }
}
