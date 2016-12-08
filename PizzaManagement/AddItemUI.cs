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
        public AddItemUI()
        {
            InitializeComponent();
        }

        private void AddItemUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaDBDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.pizzaDBDataSet.SanPham);

        }
    }
}
