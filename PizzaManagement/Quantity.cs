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

namespace PizzaManagement
{
    public partial class Quantity : Form
    {
        Int32 mode = 0;
        public Quantity()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void setmode(Int32 i)
        {
            mode = i;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string idPattern = @"^[0-9]+$";
            Regex re = new Regex(idPattern);
            if (re.IsMatch(textBox1.Text))
            {
                if (mode == 0)
                {
                    CsrUI csr = (CsrUI)this.Owner;
                    csr.additemtotable(Int32.Parse(textBox1.Text));
                    this.Dispose();
                }
                else if (mode == 1)
                {
                    CsrUI csr = (CsrUI)this.Owner;
                    csr.updateitem(Int32.Parse(textBox1.Text));
                    this.Dispose();
                }
            }
            else MessageBox.Show("Số lượng nhập vào phải là số. Vui lòng nhập lại", "Nhập sai", MessageBoxButtons.OK);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
