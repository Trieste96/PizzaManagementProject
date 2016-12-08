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
            System.Windows.Forms.GroupBox groupBox4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerUI));
            this.treeFunctionList = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLichLam = new System.Windows.Forms.TabPage();
            this.tabTinhHinhTaiChinh = new System.Windows.Forms.TabPage();
            this.tabKiemKho = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dtDSPhieu = new System.Windows.Forms.DataGridView();
            this.btnLuuThayDoi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.tabImageList = new System.Windows.Forms.ImageList(this.components);
            this.btnTaoPhieuNhap = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiPhieuTao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXemPhieu = new System.Windows.Forms.Button();
            this.cbLoaiPhieuXem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabThongTinKho = new System.Windows.Forms.TabPage();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabNguyenLieu = new System.Windows.Forms.TabPage();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.tabNhapKho = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserPosition = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabKiemKho.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSPhieu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeFunctionList
            // 
            this.treeFunctionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeFunctionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFunctionList.Location = new System.Drawing.Point(2, 153);
            this.treeFunctionList.Name = "treeFunctionList";
            this.treeFunctionList.Size = new System.Drawing.Size(262, 534);
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
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImageList = this.tabImageList;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabControl.Location = new System.Drawing.Point(270, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1077, 675);
            this.tabControl.TabIndex = 6;
            // 
            // tabLichLam
            // 
            this.tabLichLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLichLam.Location = new System.Drawing.Point(4, 38);
            this.tabLichLam.Name = "tabLichLam";
            this.tabLichLam.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichLam.Size = new System.Drawing.Size(1069, 633);
            this.tabLichLam.TabIndex = 0;
            this.tabLichLam.Text = "Sắp xếp lịch làm";
            this.tabLichLam.UseVisualStyleBackColor = true;
            // 
            // tabTinhHinhTaiChinh
            // 
            this.tabTinhHinhTaiChinh.ImageIndex = 3;
            this.tabTinhHinhTaiChinh.Location = new System.Drawing.Point(4, 38);
            this.tabTinhHinhTaiChinh.Name = "tabTinhHinhTaiChinh";
            this.tabTinhHinhTaiChinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabTinhHinhTaiChinh.Size = new System.Drawing.Size(1069, 633);
            this.tabTinhHinhTaiChinh.TabIndex = 1;
            this.tabTinhHinhTaiChinh.Text = "Tra cứu tình hình tài chính";
            this.tabTinhHinhTaiChinh.UseVisualStyleBackColor = true;
            // 
            // tabKiemKho
            // 
            this.tabKiemKho.Controls.Add(this.groupBox5);
            this.tabKiemKho.Controls.Add(groupBox4);
            this.tabKiemKho.Controls.Add(this.groupBox3);
            this.tabKiemKho.Controls.Add(this.groupBox2);
            this.tabKiemKho.Controls.Add(this.label4);
            this.tabKiemKho.ImageIndex = 0;
            this.tabKiemKho.Location = new System.Drawing.Point(4, 38);
            this.tabKiemKho.Name = "tabKiemKho";
            this.tabKiemKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabKiemKho.Size = new System.Drawing.Size(1069, 633);
            this.tabKiemKho.TabIndex = 2;
            this.tabKiemKho.Text = "Lập phiếu kiểm kho";
            this.tabKiemKho.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(452, 62);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(600, 565);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết phiếu nhập kho";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 525);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(this.button2);
            groupBox4.Controls.Add(this.dtDSPhieu);
            groupBox4.Controls.Add(this.btnLuuThayDoi);
            groupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox4.ForeColor = System.Drawing.Color.Blue;
            groupBox4.Location = new System.Drawing.Point(23, 341);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(423, 286);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách các phiếu";
            groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(204, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xoá phiếu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtDSPhieu
            // 
            this.dtDSPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSPhieu.Location = new System.Drawing.Point(6, 29);
            this.dtDSPhieu.MultiSelect = false;
            this.dtDSPhieu.Name = "dtDSPhieu";
            this.dtDSPhieu.ReadOnly = true;
            this.dtDSPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDSPhieu.Size = new System.Drawing.Size(395, 199);
            this.dtDSPhieu.TabIndex = 11;
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.ForeColor = System.Drawing.Color.Black;
            this.btnLuuThayDoi.Location = new System.Drawing.Point(6, 234);
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(192, 46);
            this.btnLuuThayDoi.TabIndex = 1;
            this.btnLuuThayDoi.Text = "Lưu thay đổi";
            this.btnLuuThayDoi.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.btnTaoPhieuNhap);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtpNgayLapPhieu);
            this.groupBox3.Controls.Add(this.cbLoaiPhieuTao);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(23, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 151);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tạo phiếu nhập";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ImageIndex = 8;
            this.btnCapNhat.ImageList = this.tabImageList;
            this.btnCapNhat.Location = new System.Drawing.Point(355, 27);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(29, 31);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // tabImageList
            // 
            this.tabImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabImageList.ImageStream")));
            this.tabImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabImageList.Images.SetKeyName(0, "store.jpeg");
            this.tabImageList.Images.SetKeyName(1, "storeImport.png");
            this.tabImageList.Images.SetKeyName(2, "storeReport.png");
            this.tabImageList.Images.SetKeyName(3, "financial-icon-lg.gif");
            this.tabImageList.Images.SetKeyName(4, "food icon.jpg");
            this.tabImageList.Images.SetKeyName(5, "ingredient-icon-300.png");
            this.tabImageList.Images.SetKeyName(6, "EmployeeIcon.png");
            this.tabImageList.Images.SetKeyName(7, "customerIcon.png");
            this.tabImageList.Images.SetKeyName(8, "Refresh.png");
            // 
            // btnTaoPhieuNhap
            // 
            this.btnTaoPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuNhap.ForeColor = System.Drawing.Color.Black;
            this.btnTaoPhieuNhap.Location = new System.Drawing.Point(54, 95);
            this.btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
            this.btnTaoPhieuNhap.Size = new System.Drawing.Size(279, 39);
            this.btnTaoPhieuNhap.TabIndex = 5;
            this.btnTaoPhieuNhap.Text = "Tạo phiếu nhập";
            this.btnTaoPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Loại phiếu nhập:";
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpNgayLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(165, 29);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(184, 26);
            this.dtpNgayLapPhieu.TabIndex = 1;
            // 
            // cbLoaiPhieuTao
            // 
            this.cbLoaiPhieuTao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhieuTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhieuTao.FormattingEnabled = true;
            this.cbLoaiPhieuTao.Items.AddRange(new object[] {
            "Đầu ngày",
            "Cuối ngày"});
            this.cbLoaiPhieuTao.Location = new System.Drawing.Point(165, 61);
            this.cbLoaiPhieuTao.Name = "cbLoaiPhieuTao";
            this.cbLoaiPhieuTao.Size = new System.Drawing.Size(219, 28);
            this.cbLoaiPhieuTao.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thời điểm lập phiếu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXemPhieu);
            this.groupBox2.Controls.Add(this.cbLoaiPhieuXem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(23, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 116);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem phiếu nhập kho";
            // 
            // btnXemPhieu
            // 
            this.btnXemPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemPhieu.ForeColor = System.Drawing.Color.Black;
            this.btnXemPhieu.Location = new System.Drawing.Point(54, 56);
            this.btnXemPhieu.Name = "btnXemPhieu";
            this.btnXemPhieu.Size = new System.Drawing.Size(279, 43);
            this.btnXemPhieu.TabIndex = 8;
            this.btnXemPhieu.Text = "Tải danh sách phiếu";
            this.btnXemPhieu.UseVisualStyleBackColor = true;
            this.btnXemPhieu.Click += new System.EventHandler(this.btnXemPhieu_Click);
            // 
            // cbLoaiPhieuXem
            // 
            this.cbLoaiPhieuXem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhieuXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhieuXem.FormattingEnabled = true;
            this.cbLoaiPhieuXem.Items.AddRange(new object[] {
            "Tất cả",
            "Đầu ngày",
            "Cuối ngày"});
            this.cbLoaiPhieuXem.Location = new System.Drawing.Point(162, 26);
            this.cbLoaiPhieuXem.Name = "cbLoaiPhieuXem";
            this.cbLoaiPhieuXem.Size = new System.Drawing.Size(171, 28);
            this.cbLoaiPhieuXem.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(50, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Loại phiếu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(318, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lập phiếu kiểm kho";
            // 
            // tabThongTinKho
            // 
            this.tabThongTinKho.ForeColor = System.Drawing.Color.Black;
            this.tabThongTinKho.ImageIndex = 2;
            this.tabThongTinKho.Location = new System.Drawing.Point(4, 38);
            this.tabThongTinKho.Name = "tabThongTinKho";
            this.tabThongTinKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongTinKho.Size = new System.Drawing.Size(1069, 633);
            this.tabThongTinKho.TabIndex = 3;
            this.tabThongTinKho.Text = "Tra cứu thông tin kho";
            this.tabThongTinKho.UseVisualStyleBackColor = true;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.button1);
            this.tabSanPham.ImageIndex = 4;
            this.tabSanPham.Location = new System.Drawing.Point(4, 38);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPham.Size = new System.Drawing.Size(1069, 633);
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
            this.tabNguyenLieu.ImageIndex = 5;
            this.tabNguyenLieu.Location = new System.Drawing.Point(4, 38);
            this.tabNguyenLieu.Name = "tabNguyenLieu";
            this.tabNguyenLieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabNguyenLieu.Size = new System.Drawing.Size(1069, 633);
            this.tabNguyenLieu.TabIndex = 5;
            this.tabNguyenLieu.Text = "Nguyên liệu";
            this.tabNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.ImageIndex = 6;
            this.tabNhanVien.Location = new System.Drawing.Point(4, 38);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(1069, 633);
            this.tabNhanVien.TabIndex = 6;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.ImageIndex = 7;
            this.tabKhachHang.Location = new System.Drawing.Point(4, 38);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachHang.Size = new System.Drawing.Size(1069, 633);
            this.tabKhachHang.TabIndex = 7;
            this.tabKhachHang.Text = "Khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabNhapKho
            // 
            this.tabNhapKho.ImageIndex = 1;
            this.tabNhapKho.Location = new System.Drawing.Point(4, 38);
            this.tabNhapKho.Name = "tabNhapKho";
            this.tabNhapKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhapKho.Size = new System.Drawing.Size(1069, 633);
            this.tabNhapKho.TabIndex = 8;
            this.tabNhapKho.Text = "Lập phiếu nhập kho";
            this.tabNhapKho.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 135);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txtUserPosition
            // 
            this.txtUserPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPosition.ForeColor = System.Drawing.Color.Black;
            this.txtUserPosition.Location = new System.Drawing.Point(94, 94);
            this.txtUserPosition.Name = "txtUserPosition";
            this.txtUserPosition.ReadOnly = true;
            this.txtUserPosition.Size = new System.Drawing.Size(160, 21);
            this.txtUserPosition.TabIndex = 5;
            this.txtUserPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(94, 61);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(160, 21);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.Location = new System.Drawing.Point(94, 25);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(160, 21);
            this.txtUserID.TabIndex = 3;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vị trí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // ManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.treeFunctionList);
            this.Name = "ManagerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng Pizza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerUI_Load);
            this.tabControl.ResumeLayout(false);
            this.tabKiemKho.ResumeLayout(false);
            this.tabKiemKho.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDSPhieu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSanPham.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserPosition;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList tabImageList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiPhieuTao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXemPhieu;
        private System.Windows.Forms.ComboBox cbLoaiPhieuXem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTaoPhieuNhap;
        private System.Windows.Forms.DataGridView dtDSPhieu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLuuThayDoi;
        private System.Windows.Forms.Button btnCapNhat;
    }
}

