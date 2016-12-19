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
            this.ItemTable = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaDBDataSet = new PizzaManagement.PizzaDBDataSet();
            this.sanPhamTableAdapter = new PizzaManagement.PizzaDBDataSetTableAdapters.SanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemTable
            // 
            this.ItemTable.AutoGenerateColumns = false;
            this.ItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.maLoaiSPDataGridViewTextBoxColumn});
            this.ItemTable.DataSource = this.sanPhamBindingSource;
            this.ItemTable.Location = new System.Drawing.Point(12, 12);
            this.ItemTable.Name = "ItemTable";
            this.ItemTable.ReadOnly = true;
            this.ItemTable.Size = new System.Drawing.Size(650, 246);
            this.ItemTable.TabIndex = 0;
            this.ItemTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemTable_CellClick);
            this.ItemTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.ItemTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemTable_CellContentDoubleClick);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLoaiSPDataGridViewTextBoxColumn
            // 
            this.maLoaiSPDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiSP";
            this.maLoaiSPDataGridViewTextBoxColumn.HeaderText = "MaLoaiSP";
            this.maLoaiSPDataGridViewTextBoxColumn.Name = "maLoaiSPDataGridViewTextBoxColumn";
            this.maLoaiSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.pizzaDBDataSet;
            // 
            // pizzaDBDataSet
            // 
            this.pizzaDBDataSet.DataSetName = "PizzaDBDataSet";
            this.pizzaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // AddItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 270);
            this.Controls.Add(this.ItemTable);
            this.Name = "AddItemUI";
            this.Text = "Chọn sản phẩm";
            this.Load += new System.EventHandler(this.AddItemUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemTable;
        private PizzaDBDataSet pizzaDBDataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private PizzaDBDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSPDataGridViewTextBoxColumn;
    }
}