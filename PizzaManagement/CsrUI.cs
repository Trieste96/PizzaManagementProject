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
using System.Text.RegularExpressions;

namespace PizzaManagement
{
    
    public partial class CsrUI : Form
    {
        private NhanVien user;
        public DTO.Info_SanPham_DTO dto = new DTO.Info_SanPham_DTO();
        BUS.CsrBUS csrbus = new BUS.CsrBUS();
        Int32 current;
        int[] a=new int[100];
        int n = 0;
        int mode;
        public CsrUI()
        {
            InitializeComponent();
            datetext.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            tongtientext.Text = "0";
            a[0] = 0;
        }

        public void getUserInfo(NhanVien guest)
        {
            user = guest;
        }

        private void CsrUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaDBDataSet2.HinhThucPhucVu' table. You can move, or remove it, as needed.
            this.hinhThucPhucVuTableAdapter.Fill(this.pizzaDBDataSet2.HinhThucPhucVu);
            // TODO: This line of code loads data into the 'pizzaDBDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.pizzaDBDataSet.SanPham);
            txtMaNV.Text = user.MaNV.ToString();
            txtHoTenNV.Text = user.HoTen;
            txtViTri.Text = user.TenLoaiNV;
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

        private void additem_Click(object sender, EventArgs e)
        {
            AddItemUI form = new AddItemUI();
            form.Show(this);

        }
        public void additemtotable(Int32 quantity)
        {
            int x = 0;
            for (int i = 0; i <= current; i++)
                if (dto.MaSP == a[i]) x = 1;
            if (x == 0)
            {
                a[n] = dto.MaSP;
                n++;
                currentupdate();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[current].Cells[0].Value = dataGridView1.RowCount - 1;
                dataGridView1.Rows[current].Cells[1].Value = dto.MaSP;
                dataGridView1.Rows[current].Cells[2].Value = dto.TenSP;
                dataGridView1.Rows[current].Cells[3].Value = quantity;
                dataGridView1.Rows[current].Cells[4].Value = dto.Gia;
                dataGridView1.Rows[current].Cells[5].Value = quantity * dto.Gia;
                updategiatrihoadon();
            }
            else MessageBox.Show("Không thể thêm vào 1 sản phẩm đã thêm trước đó, bạn có thể thay đổi số lượng ở phần tạo hóa đơn");
        }
        public void updateitem(Int32 quantity)
        {
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value = quantity;
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value = quantity * Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString());
            updategiatrihoadon();
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void updategiatrihoadon()
        {
            Int32 tongtien = 0;
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
                tongtien = tongtien + Int32.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            tongtientext.Text = tongtien.ToString();
            vattext.Text = ((tongtien * 10) / 100).ToString();
            int vat = int.Parse(vattext.Text);
            int ck = int.Parse(cktext.Text);
            thanhtoantext.Text = (tongtien + vat - ((tongtien + vat) * ck) / 100).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* foreach(DataGridViewRow item in this.dataGridView1.CurrentCell.ro)
             {
                 dataGridView1.Rows.RemoveAt(item.Index);
             }*/
            if (dataGridView1.RowCount > 1)
            {
                if (dataGridView1.CurrentRow.Index < dataGridView1.RowCount)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    sttupdate();
                    updategiatrihoadon();
                }
            }
        }
        public void currentupdate()
        {
            current = dataGridView1.RowCount - 1;
        }
        public void sttupdate()
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
                dataGridView1.Rows[i].Cells[0].Value = i+1 ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x=dataGridView1.CurrentRow.Index;
            string idPattern = @"^[0-9]+$";
            Regex re = new Regex(idPattern);
            if (re.IsMatch(soluongtext.Text) && int.Parse(soluongtext.Text.ToString()) > 0)
            {
                dataGridView1.Rows[x].Cells[3].Value = suasoluongtext.Text;
                suasoluongtext.Text = "1";
            }

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            
            DTO.HoaDonDTO dtohd = new DTO.HoaDonDTO();
            if
            dtohd.htpv = int.Parse(htpvcombo.SelectedValue.ToString());
            dtohd.manv = user.MaNV;
            dtohd.makh = int.Parse(makhtext.Text.ToString());
            dtohd.ngaygio = datetext.Text;
            csrbus.taohoadon(dtohd);
            for (int i=0;i<dataGridView1.RowCount-1;i++)
            {
                dtohd.masp = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                dtohd.soluong = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                csrbus.themchitiethoadon(dtohd);
            }
            switch (MessageBox.Show("Hóa đơn đã lưu thành công. Bạn có muốn tạo hóa đơn khác?", "Thành công", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes: {
                        clear(); break; }
                case DialogResult.No: { this.Dispose(); break; }
                case DialogResult.Cancel: break;
            }
        }
        private void makhtext_Leave(object sender, System.EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(makhtext.Text);
            Info_KhachHang_DTO dtokh = new Info_KhachHang_DTO();
            dtokh = csrbus.thongtinkhachhang(makh);
            tenkhtext.Text = dtokh.HoTen;
            loaikhtext.Text = dtokh.LoaiKH;
            cktext.Text = dtokh.ChietKhau.ToString();
            updategiatrihoadon();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int item = ItemTable.CurrentRow.Index;
            int x = 0;
            string idPattern = @"^[0-9]+$";
            Regex re = new Regex(idPattern);
            if (re.IsMatch(soluongtext.Text)&&int.Parse(soluongtext.Text.ToString())>0)
            {
                for (int i = 0; i <= current; i++)
                    if (int.Parse(ItemTable.Rows[item].Cells[0].Value.ToString()) == a[i]) x = 1;
                if (x == 0)
                {
                    a[n] = int.Parse(ItemTable.Rows[item].Cells[0].Value.ToString());
                    n++;
                    currentupdate();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[current].Cells[0].Value = dataGridView1.RowCount - 1;
                    dataGridView1.Rows[current].Cells[1].Value = ItemTable.Rows[item].Cells[0].Value;
                    dataGridView1.Rows[current].Cells[2].Value = ItemTable.Rows[item].Cells[1].Value;
                    dataGridView1.Rows[current].Cells[3].Value = soluongtext.Text;
                    dataGridView1.Rows[current].Cells[4].Value = ItemTable.Rows[item].Cells[2].Value; ;
                    dataGridView1.Rows[current].Cells[5].Value = int.Parse(dataGridView1.Rows[current].Cells[3].Value.ToString()) * int.Parse(dataGridView1.Rows[current].Cells[4].Value.ToString());
                    updategiatrihoadon();
                    soluongtext.Text = "1";
                }
                else MessageBox.Show("Không thể thêm vào 1 sản phẩm đã thêm trước đó, bạn có thể thay đổi số lượng ở phần tạo hóa đơn");
            }
            else MessageBox.Show("Số lượng nhập vào phải là số. Vui lòng nhập lại", "Nhập sai", MessageBoxButtons.OK);
        }
        public void clear()
        {
            makhtext.Text = "";
            tenkhtext.Text = "";
            loaikhtext.Text = "";
            datetext.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            tongtientext.Text = "0";
            cktext.Text = "0";
            vattext.Text = "0";
            thanhtoantext.Text = "0";
            dataGridView1.Rows.Clear();
            suasoluongtext.Text = "1";
            a = new int[100];
            Array.Clear(a, 0, 100);
            a[0] = 0;
            n = 0;
            htpvcombo.SelectedIndex = 0;
            currentupdate();
            ItemTable.ClearSelection();
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
    }

   
    }
