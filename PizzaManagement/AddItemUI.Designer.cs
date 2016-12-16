namespace PizzaManagement
{
    partial class AddItemUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pizzaDBDataSet = new PizzaManagement.PizzaDBDataSet();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter = new PizzaManagement.PizzaDBDataSetTableAdapters.SanPhamTableAdapter();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.maLoaiSPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sanPhamBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // pizzaDBDataSet
            // 
            this.pizzaDBDataSet.DataSetName = "PizzaDBDataSet";
            this.pizzaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.pizzaDBDataSet;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // maLoaiSPDataGridViewTextBoxColumn
            // 
            this.maLoaiSPDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiSP";
            this.maLoaiSPDataGridViewTextBoxColumn.HeaderText = "Mã Loại Sản Phẩm";
            this.maLoaiSPDataGridViewTextBoxColumn.Name = "maLoaiSPDataGridViewTextBoxColumn";
            // 
            // AddItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 270);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddItemUI";
            this.Text = "Thêm món";
            this.Load += new System.EventHandler(this.AddItemUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PizzaDBDataSet pizzaDBDataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private PizzaDBDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSPDataGridViewTextBoxColumn;
    }
}