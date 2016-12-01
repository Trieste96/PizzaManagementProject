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
            this.treeFunctionList = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLichLam = new System.Windows.Forms.TabPage();
            this.tabTinhHinhTaiChinh = new System.Windows.Forms.TabPage();
            this.tabKiemKho = new System.Windows.Forms.TabPage();
            this.tabThongTinKho = new System.Windows.Forms.TabPage();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabNguyenLieu = new System.Windows.Forms.TabPage();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.tabNhapKho = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPosition = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeFunctionList
            // 
            this.treeFunctionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFunctionList.Location = new System.Drawing.Point(2, 226);
            this.treeFunctionList.Name = "treeFunctionList";
            this.treeFunctionList.Size = new System.Drawing.Size(281, 320);
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
            this.tabControl.Location = new System.Drawing.Point(303, 69);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(738, 477);
            this.tabControl.TabIndex = 6;
            // 
            // tabLichLam
            // 
            this.tabLichLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLichLam.Location = new System.Drawing.Point(4, 34);
            this.tabLichLam.Name = "tabLichLam";
            this.tabLichLam.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichLam.Size = new System.Drawing.Size(730, 439);
            this.tabLichLam.TabIndex = 0;
            this.tabLichLam.Text = "Sắp xếp lịch làm";
            this.tabLichLam.UseVisualStyleBackColor = true;
            // 
            // tabTinhHinhTaiChinh
            // 
            this.tabTinhHinhTaiChinh.Location = new System.Drawing.Point(4, 34);
            this.tabTinhHinhTaiChinh.Name = "tabTinhHinhTaiChinh";
            this.tabTinhHinhTaiChinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabTinhHinhTaiChinh.Size = new System.Drawing.Size(497, 323);
            this.tabTinhHinhTaiChinh.TabIndex = 1;
            this.tabTinhHinhTaiChinh.Text = "Tra cứu tình hình tài chính";
            this.tabTinhHinhTaiChinh.UseVisualStyleBackColor = true;
            // 
            // tabKiemKho
            // 
            this.tabKiemKho.Location = new System.Drawing.Point(4, 34);
            this.tabKiemKho.Name = "tabKiemKho";
            this.tabKiemKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabKiemKho.Size = new System.Drawing.Size(497, 323);
            this.tabKiemKho.TabIndex = 2;
            this.tabKiemKho.Text = "Lập phiếu kiểm kho";
            this.tabKiemKho.UseVisualStyleBackColor = true;
            // 
            // tabThongTinKho
            // 
            this.tabThongTinKho.Location = new System.Drawing.Point(4, 34);
            this.tabThongTinKho.Name = "tabThongTinKho";
            this.tabThongTinKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongTinKho.Size = new System.Drawing.Size(497, 323);
            this.tabThongTinKho.TabIndex = 3;
            this.tabThongTinKho.Text = "Tra cứu thông tin kho";
            this.tabThongTinKho.UseVisualStyleBackColor = true;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.button1);
            this.tabSanPham.Location = new System.Drawing.Point(4, 34);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPham.Size = new System.Drawing.Size(497, 323);
            this.tabSanPham.TabIndex = 4;
            this.tabSanPham.Text = "Sản phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabNguyenLieu
            // 
            this.tabNguyenLieu.Location = new System.Drawing.Point(4, 34);
            this.tabNguyenLieu.Name = "tabNguyenLieu";
            this.tabNguyenLieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabNguyenLieu.Size = new System.Drawing.Size(497, 323);
            this.tabNguyenLieu.TabIndex = 5;
            this.tabNguyenLieu.Text = "Nguyên liệu";
            this.tabNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Location = new System.Drawing.Point(4, 34);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(497, 323);
            this.tabNhanVien.TabIndex = 6;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Location = new System.Drawing.Point(4, 34);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachHang.Size = new System.Drawing.Size(497, 323);
            this.tabKhachHang.TabIndex = 7;
            this.tabKhachHang.Text = "Khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabNhapKho
            // 
            this.tabNhapKho.Location = new System.Drawing.Point(4, 34);
            this.tabNhapKho.Name = "tabNhapKho";
            this.tabNhapKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhapKho.Size = new System.Drawing.Size(497, 323);
            this.tabNhapKho.TabIndex = 8;
            this.tabNhapKho.Text = "Lập phiếu nhập kho";
            this.tabNhapKho.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(303, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(347, 46);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Giao diện quản lý";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserPosition);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(2, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên người dùng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vị trí:";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.Location = new System.Drawing.Point(115, 28);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(160, 26);
            this.txtUserID.TabIndex = 3;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(115, 64);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(160, 26);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserPosition
            // 
            this.txtUserPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPosition.ForeColor = System.Drawing.Color.Black;
            this.txtUserPosition.Location = new System.Drawing.Point(115, 97);
            this.txtUserPosition.Name = "txtUserPosition";
            this.txtUserPosition.ReadOnly = true;
            this.txtUserPosition.Size = new System.Drawing.Size(160, 26);
            this.txtUserPosition.TabIndex = 5;
            this.txtUserPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.treeFunctionList);
            this.Controls.Add(this.lblTitle);
            this.Name = "ManagerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng Pizza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerUI_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserPosition;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

