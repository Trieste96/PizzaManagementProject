using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PizzaManagement
{
    public partial class HoaDonUI : Form
    {
        public HoaDonUI()
        {
            InitializeComponent();
        }
        public HoaDonUI(SqlDataReader Reader,int mahd)
        {
            InitializeComponent();
            textBox1.Text = mahd.ToString();
            int current = 0;
            while (Reader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[current].Cells[0].Value = current + 1;
                dataGridView1.Rows[current].Cells[1].Value = Reader[0].ToString();
                dataGridView1.Rows[current].Cells[2].Value = Reader[1].ToString();
                dataGridView1.Rows[current].Cells[3].Value = Reader[3].ToString();
                dataGridView1.Rows[current].Cells[4].Value = Reader[2].ToString();
                dataGridView1.Rows[current].Cells[5].Value = int.Parse(Reader[2].ToString()) * int.Parse(Reader[3].ToString());
                current++;
            }
        }
        private void HoaDonUI_Load(object sender, EventArgs e)
        {
            
        }
    }
}
