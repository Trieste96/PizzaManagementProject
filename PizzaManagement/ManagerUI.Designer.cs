namespace PizzaManagement
{
    partial class ManagerUI
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.treeFunctionList = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLichLam = new System.Windows.Forms.TabPage();
            this.tabTinhHinhTaiChinh = new System.Windows.Forms.TabPage();
            this.tabKiemKho = new System.Windows.Forms.TabPage();
            this.tabThongTinKho = new System.Windows.Forms.TabPage();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.btn_info_deleteSP = new System.Windows.Forms.Button();
            this.btn_info_editSP = new System.Windows.Forms.Button();
            this.btn_info_addSP = new System.Windows.Forms.Button();
            this.table_info_SP = new System.Windows.Forms.DataGridView();
            this.tabNguyenLieu = new System.Windows.Forms.TabPage();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.tabNhapKho = new System.Windows.Forms.TabPage();
            this.cMS_menu_rightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_info_SP)).BeginInit();
            this.cMS_menu_rightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(536, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(576, 58);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Quản lý nhà hàng Pizza";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // treeFunctionList
            // 
            this.treeFunctionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFunctionList.Location = new System.Drawing.Point(3, 228);
            this.treeFunctionList.Margin = new System.Windows.Forms.Padding(4);
            this.treeFunctionList.Name = "treeFunctionList";
            this.treeFunctionList.Size = new System.Drawing.Size(348, 443);
            this.treeFunctionList.TabIndex = 5;
            this.treeFunctionList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFunctionList_NodeMouseDoubleClick);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabLichLam);
            this.tabControl.Controls.Add(this.tabTinhHinhTaiChinh);
            this.tabControl.Controls.Add(this.tabKiemKho);
            this.tabControl.Controls.Add(this.tabThongTinKho);
            this.tabControl.Controls.Add(this.tabSanPham);
            this.tabControl.Controls.Add(this.tabNguyenLieu);
            this.tabControl.Controls.Add(this.tabNhanVien);
            this.tabControl.Controls.Add(this.tabKhachHang);
            this.tabControl.Controls.Add(this.tabNhapKho);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl.Location = new System.Drawing.Point(404, 228);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1248, 577);
            this.tabControl.TabIndex = 6;
            // 
            // tabLichLam
            // 
            this.tabLichLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLichLam.Location = new System.Drawing.Point(4, 38);
            this.tabLichLam.Margin = new System.Windows.Forms.Padding(4);
            this.tabLichLam.Name = "tabLichLam";
            this.tabLichLam.Padding = new System.Windows.Forms.Padding(4);
            this.tabLichLam.Size = new System.Drawing.Size(1240, 535);
            this.tabLichLam.TabIndex = 0;
            this.tabLichLam.Text = "Sắp xếp lịch làm";
            this.tabLichLam.UseVisualStyleBackColor = true;
            // 
            // tabTinhHinhTaiChinh
            // 
            this.tabTinhHinhTaiChinh.Location = new System.Drawing.Point(4, 38);
            this.tabTinhHinhTaiChinh.Margin = new System.Windows.Forms.Padding(4);
            this.tabTinhHinhTaiChinh.Name = "tabTinhHinhTaiChinh";
            this.tabTinhHinhTaiChinh.Padding = new System.Windows.Forms.Padding(4);
            this.tabTinhHinhTaiChinh.Size = new System.Drawing.Size(1240, 535);
            this.tabTinhHinhTaiChinh.TabIndex = 1;
            this.tabTinhHinhTaiChinh.Text = "Tra cứu tình hình tài chính";
            this.tabTinhHinhTaiChinh.UseVisualStyleBackColor = true;
            // 
            // tabKiemKho
            // 
            this.tabKiemKho.Location = new System.Drawing.Point(4, 38);
            this.tabKiemKho.Margin = new System.Windows.Forms.Padding(4);
            this.tabKiemKho.Name = "tabKiemKho";
            this.tabKiemKho.Padding = new System.Windows.Forms.Padding(4);
            this.tabKiemKho.Size = new System.Drawing.Size(1240, 535);
            this.tabKiemKho.TabIndex = 2;
            this.tabKiemKho.Text = "Lập phiếu kiểm kho";
            this.tabKiemKho.UseVisualStyleBackColor = true;
            // 
            // tabThongTinKho
            // 
            this.tabThongTinKho.Location = new System.Drawing.Point(4, 38);
            this.tabThongTinKho.Margin = new System.Windows.Forms.Padding(4);
            this.tabThongTinKho.Name = "tabThongTinKho";
            this.tabThongTinKho.Padding = new System.Windows.Forms.Padding(4);
            this.tabThongTinKho.Size = new System.Drawing.Size(1240, 535);
            this.tabThongTinKho.TabIndex = 3;
            this.tabThongTinKho.Text = "Tra cứu thông tin kho";
            this.tabThongTinKho.UseVisualStyleBackColor = true;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.btn_info_deleteSP);
            this.tabSanPham.Controls.Add(this.btn_info_editSP);
            this.tabSanPham.Controls.Add(this.btn_info_addSP);
            this.tabSanPham.Controls.Add(this.table_info_SP);
            this.tabSanPham.Location = new System.Drawing.Point(4, 38);
            this.tabSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(4);
            this.tabSanPham.Size = new System.Drawing.Size(1240, 535);
            this.tabSanPham.TabIndex = 4;
            this.tabSanPham.Text = "Sản phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // btn_info_deleteSP
            // 
            this.btn_info_deleteSP.AutoSize = true;
            this.btn_info_deleteSP.Location = new System.Drawing.Point(547, 480);
            this.btn_info_deleteSP.Name = "btn_info_deleteSP";
            this.btn_info_deleteSP.Size = new System.Drawing.Size(145, 39);
            this.btn_info_deleteSP.TabIndex = 3;
            this.btn_info_deleteSP.Text = "Xóa";
            this.btn_info_deleteSP.UseVisualStyleBackColor = true;
            this.btn_info_deleteSP.Click += new System.EventHandler(this.btn_info_deleteSP_Click);
            // 
            // btn_info_editSP
            // 
            this.btn_info_editSP.AutoSize = true;
            this.btn_info_editSP.Location = new System.Drawing.Point(298, 480);
            this.btn_info_editSP.Name = "btn_info_editSP";
            this.btn_info_editSP.Size = new System.Drawing.Size(145, 39);
            this.btn_info_editSP.TabIndex = 2;
            this.btn_info_editSP.Text = "Sửa";
            this.btn_info_editSP.UseVisualStyleBackColor = true;
            this.btn_info_editSP.Click += new System.EventHandler(this.btn_info_editSP_Click);
            // 
            // btn_info_addSP
            // 
            this.btn_info_addSP.AutoSize = true;
            this.btn_info_addSP.Location = new System.Drawing.Point(62, 480);
            this.btn_info_addSP.Name = "btn_info_addSP";
            this.btn_info_addSP.Size = new System.Drawing.Size(145, 39);
            this.btn_info_addSP.TabIndex = 1;
            this.btn_info_addSP.Text = "Thêm mới";
            this.btn_info_addSP.UseVisualStyleBackColor = true;
            this.btn_info_addSP.Click += new System.EventHandler(this.btn_info_addSP_Click);
            // 
            // table_info_SP
            // 
            this.table_info_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_info_SP.ContextMenuStrip = this.cMS_menu_rightClick;
            this.table_info_SP.Location = new System.Drawing.Point(-4, 3);
            this.table_info_SP.Name = "table_info_SP";
            this.table_info_SP.RowTemplate.Height = 24;
            this.table_info_SP.Size = new System.Drawing.Size(1007, 462);
            this.table_info_SP.TabIndex = 0;
            this.table_info_SP.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.table_info_SP_CellMouseDown);
            // 
            // tabNguyenLieu
            // 
            this.tabNguyenLieu.Location = new System.Drawing.Point(4, 38);
            this.tabNguyenLieu.Margin = new System.Windows.Forms.Padding(4);
            this.tabNguyenLieu.Name = "tabNguyenLieu";
            this.tabNguyenLieu.Padding = new System.Windows.Forms.Padding(4);
            this.tabNguyenLieu.Size = new System.Drawing.Size(1240, 535);
            this.tabNguyenLieu.TabIndex = 5;
            this.tabNguyenLieu.Text = "Nguyên liệu";
            this.tabNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Location = new System.Drawing.Point(4, 38);
            this.tabNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.tabNhanVien.Size = new System.Drawing.Size(1240, 535);
            this.tabNhanVien.TabIndex = 6;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Location = new System.Drawing.Point(4, 38);
            this.tabKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(4);
            this.tabKhachHang.Size = new System.Drawing.Size(1240, 535);
            this.tabKhachHang.TabIndex = 7;
            this.tabKhachHang.Text = "Khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabNhapKho
            // 
            this.tabNhapKho.Location = new System.Drawing.Point(4, 38);
            this.tabNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.tabNhapKho.Name = "tabNhapKho";
            this.tabNhapKho.Padding = new System.Windows.Forms.Padding(4);
            this.tabNhapKho.Size = new System.Drawing.Size(1240, 535);
            this.tabNhapKho.TabIndex = 8;
            this.tabNhapKho.Text = "Lập phiếu nhập kho";
            this.tabNhapKho.UseVisualStyleBackColor = true;
            // 
            // cMS_menu_rightClick
            // 
            this.cMS_menu_rightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMS_menu_rightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaSảnPhẩmToolStripMenuItem,
            this.xóaSảnPhẩmToolStripMenuItem});
            this.cMS_menu_rightClick.Name = "cMS_menu_rightClick";
            this.cMS_menu_rightClick.Size = new System.Drawing.Size(182, 84);
            // 
            // sửaSảnPhẩmToolStripMenuItem
            // 
            this.sửaSảnPhẩmToolStripMenuItem.Name = "sửaSảnPhẩmToolStripMenuItem";
            this.sửaSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sửaSảnPhẩmToolStripMenuItem.Text = "Sửa sản phẩm";
            this.sửaSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sửaSảnPhẩmToolStripMenuItem_Click);
            // 
            // xóaSảnPhẩmToolStripMenuItem
            // 
            this.xóaSảnPhẩmToolStripMenuItem.Name = "xóaSảnPhẩmToolStripMenuItem";
            this.xóaSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.xóaSảnPhẩmToolStripMenuItem.Text = "Xóa sản phẩm";
            this.xóaSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.xóaSảnPhẩmToolStripMenuItem_Click);
            // 
            // ManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 835);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.treeFunctionList);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện quản lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ManagerUI_Activated);
            this.Load += new System.EventHandler(this.ManagerUI_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            this.tabSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_info_SP)).EndInit();
            this.cMS_menu_rightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TreeView treeFunctionList;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLichLam;
        private System.Windows.Forms.TabPage tabTinhHinhTaiChinh;
        private System.Windows.Forms.TabPage tabKiemKho;
        private System.Windows.Forms.TabPage tabThongTinKho;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.TabPage tabNguyenLieu;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.TabPage tabNhapKho;
        private System.Windows.Forms.DataGridView table_info_SP;
        private System.Windows.Forms.Button btn_info_addSP;
        private System.Windows.Forms.Button btn_info_deleteSP;
        private System.Windows.Forms.Button btn_info_editSP;
        private System.Windows.Forms.ContextMenuStrip cMS_menu_rightClick;
        private System.Windows.Forms.ToolStripMenuItem sửaSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSảnPhẩmToolStripMenuItem;
    }
}

