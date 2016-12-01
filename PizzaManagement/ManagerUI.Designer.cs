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
            this.lblTitle = new System.Windows.Forms.Label();
            this.treeFunctionList = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLichLam = new System.Windows.Forms.TabPage();
            this.tabTinhHinhTaiChinh = new System.Windows.Forms.TabPage();
            this.tabLapPhieuTK = new System.Windows.Forms.TabPage();
            this.tabThongTinKho = new System.Windows.Forms.TabPage();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.btn_add_info_SanPham = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabNguyenLieu = new System.Windows.Forms.TabPage();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(248, 25);
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
            this.treeFunctionList.Location = new System.Drawing.Point(3, 113);
            this.treeFunctionList.Margin = new System.Windows.Forms.Padding(4);
            this.treeFunctionList.Name = "treeFunctionList";
            this.treeFunctionList.Size = new System.Drawing.Size(348, 558);
            this.treeFunctionList.TabIndex = 5;
            this.treeFunctionList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFunctionList_AfterSelect);
            this.treeFunctionList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFunctionList_NodeMouseDoubleClick);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabLichLam);
            this.tabControl.Controls.Add(this.tabTinhHinhTaiChinh);
            this.tabControl.Controls.Add(this.tabLapPhieuTK);
            this.tabControl.Controls.Add(this.tabThongTinKho);
            this.tabControl.Controls.Add(this.tabSanPham);
            this.tabControl.Controls.Add(this.tabNguyenLieu);
            this.tabControl.Controls.Add(this.tabNhanVien);
            this.tabControl.Controls.Add(this.tabKhachHang);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl.Location = new System.Drawing.Point(404, 113);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(673, 559);
            this.tabControl.TabIndex = 6;
            // 
            // tabLichLam
            // 
            this.tabLichLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLichLam.Location = new System.Drawing.Point(4, 38);
            this.tabLichLam.Margin = new System.Windows.Forms.Padding(4);
            this.tabLichLam.Name = "tabLichLam";
            this.tabLichLam.Padding = new System.Windows.Forms.Padding(4);
            this.tabLichLam.Size = new System.Drawing.Size(665, 517);
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
            this.tabTinhHinhTaiChinh.Size = new System.Drawing.Size(665, 517);
            this.tabTinhHinhTaiChinh.TabIndex = 1;
            this.tabTinhHinhTaiChinh.Text = "Tra cứu tình hình tài chính";
            this.tabTinhHinhTaiChinh.UseVisualStyleBackColor = true;
            // 
            // tabLapPhieuTK
            // 
            this.tabLapPhieuTK.Location = new System.Drawing.Point(4, 38);
            this.tabLapPhieuTK.Margin = new System.Windows.Forms.Padding(4);
            this.tabLapPhieuTK.Name = "tabLapPhieuTK";
            this.tabLapPhieuTK.Padding = new System.Windows.Forms.Padding(4);
            this.tabLapPhieuTK.Size = new System.Drawing.Size(665, 517);
            this.tabLapPhieuTK.TabIndex = 2;
            this.tabLapPhieuTK.Text = "Lập phiếu thống kê";
            this.tabLapPhieuTK.UseVisualStyleBackColor = true;
            // 
            // tabThongTinKho
            // 
            this.tabThongTinKho.Location = new System.Drawing.Point(4, 38);
            this.tabThongTinKho.Margin = new System.Windows.Forms.Padding(4);
            this.tabThongTinKho.Name = "tabThongTinKho";
            this.tabThongTinKho.Padding = new System.Windows.Forms.Padding(4);
            this.tabThongTinKho.Size = new System.Drawing.Size(665, 517);
            this.tabThongTinKho.TabIndex = 3;
            this.tabThongTinKho.Text = "Tra cứu thông tin kho";
            this.tabThongTinKho.UseVisualStyleBackColor = true;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.btn_add_info_SanPham);
            this.tabSanPham.Controls.Add(this.dataGridView1);
            this.tabSanPham.Location = new System.Drawing.Point(4, 38);
            this.tabSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(4);
            this.tabSanPham.Size = new System.Drawing.Size(665, 517);
            this.tabSanPham.TabIndex = 4;
            this.tabSanPham.Text = "Sản phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // btn_add_info_SanPham
            // 
            this.btn_add_info_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_info_SanPham.Location = new System.Drawing.Point(40, 459);
            this.btn_add_info_SanPham.Name = "btn_add_info_SanPham";
            this.btn_add_info_SanPham.Size = new System.Drawing.Size(159, 40);
            this.btn_add_info_SanPham.TabIndex = 1;
            this.btn_add_info_SanPham.Text = "Thêm mới";
            this.btn_add_info_SanPham.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 441);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabNguyenLieu
            // 
            this.tabNguyenLieu.Location = new System.Drawing.Point(4, 38);
            this.tabNguyenLieu.Margin = new System.Windows.Forms.Padding(4);
            this.tabNguyenLieu.Name = "tabNguyenLieu";
            this.tabNguyenLieu.Padding = new System.Windows.Forms.Padding(4);
            this.tabNguyenLieu.Size = new System.Drawing.Size(665, 517);
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
            this.tabNhanVien.Size = new System.Drawing.Size(665, 517);
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
            this.tabKhachHang.Size = new System.Drawing.Size(665, 517);
            this.tabKhachHang.TabIndex = 7;
            this.tabKhachHang.Text = "Khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // ManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 702);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.treeFunctionList);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện quản lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerUI_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TreeView treeFunctionList;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLichLam;
        private System.Windows.Forms.TabPage tabTinhHinhTaiChinh;
        private System.Windows.Forms.TabPage tabLapPhieuTK;
        private System.Windows.Forms.TabPage tabThongTinKho;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.TabPage tabNguyenLieu;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add_info_SanPham;
    }
}

