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
    public partial class AddItemUI : Form
    {
        public DTO.Info_SanPham_DTO dto = new DTO.Info_SanPham_DTO();
        public AddItemUI()
        {
            InitializeComponent();
        }

        private void AddItemUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaDBDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.pizzaDBDataSet.SanPham);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 Current = ItemTable.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DTO.Info_SanPham_DTO dto;
            System.Diagnostics.Debug.WriteLine(ItemTable.CurrentCell.Value.ToString());
        }

        private void ItemTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 Current = ItemTable.Rows.GetRowCount(DataGridViewElementStates.Selected);
            System.Diagnostics.Debug.WriteLine("123123123");
        }

        private void ItemTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 Current = e.RowIndex;
           
            dto.MaSP = Convert.ToInt32(ItemTable.Rows[Current].Cells[0].Value.ToString());
            dto.TenSP = ItemTable.Rows[Current].Cells[1].Value.ToString();
            dto.Gia = Convert.ToInt32(ItemTable.Rows[Current].Cells[2].Value.ToString());
            dto.MaLoaiSP = Convert.ToInt32(ItemTable.Rows[Current].Cells[3].Value.ToString());
            CsrUI csr = (CsrUI)this.Owner;
            csr.dto = this.dto;
            Quantity form = new Quantity();
            form.Show(csr);
            this.Dispose();
        }
    }
}
