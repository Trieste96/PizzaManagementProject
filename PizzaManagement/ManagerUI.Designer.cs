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
            this.btnXemChiTietPhieu = new System.Windows.Forms.Button();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.dtDSPhieu = new System.Windows.Forms.DataGridView();
            this.btnLuuThayDoi = new System.Windows.Forms.Button();
            this.treeFunctionList = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLichLam = new System.Windows.Forms.TabPage();
            this.tabTinhHinhTaiChinh = new System.Windows.Forms.TabPage();
            this.tabKiemKho = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.lblMaPhieuTitle = new System.Windows.Forms.Label();
            this.dtChiTietPhieuTK = new System.Windows.Forms.DataGridView();
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
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.btn_SuaSP = new System.Windows.Forms.Button();
            this.btn_themSP = new System.Windows.Forms.Button();
            this.dgv_info_SanPham = new System.Windows.Forms.DataGridView();
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
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSPhieu)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabKiemKho.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtChiTietPhieuTK)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info_SanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(this.btnXemChiTietPhieu);
            groupBox4.Controls.Add(this.btnXoaPhieu);
            groupBox4.Controls.Add(this.dtDSPhieu);
            groupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox4.ForeColor = System.Drawing.Color.Blue;
            groupBox4.Location = new System.Drawing.Point(23, 341);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(474, 296);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách các phiếu";
            groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnXemChiTietPhieu
            // 
            this.btnXemChiTietPhieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTietPhieu.ForeColor = System.Drawing.Color.Black;
            this.btnXemChiTietPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnXemChiTietPhieu.Image")));
            this.btnXemChiTietPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTietPhieu.Location = new System.Drawing.Point(22, 244);
            this.btnXemChiTietPhieu.Name = "btnXemChiTietPhieu";
            this.btnXemChiTietPhieu.Size = new System.Drawing.Size(201, 46);
            this.btnXemChiTietPhieu.TabIndex = 12;
            this.btnXemChiTietPhieu.Text = "Xem chi tiết phiếu";
            this.btnXemChiTietPhieu.UseVisualStyleBackColor = true;
            this.btnXemChiTietPhieu.Click += new System.EventHandler(this.btnXemChiTietPhieu_Click);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieu.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieu.Image")));
            this.btnXoaPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieu.Location = new System.Drawing.Point(246, 244);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(196, 46);
            this.btnXoaPhieu.TabIndex = 2;
            this.btnXoaPhieu.Text = "Xoá phiếu";
            this.btnXoaPhieu.UseVisualStyleBackColor = true;
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // dtDSPhieu
            // 
            this.dtDSPhieu.AllowUserToAddRows = false;
            this.dtDSPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtDSPhieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtDSPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSPhieu.Location = new System.Drawing.Point(6, 29);
            this.dtDSPhieu.MultiSelect = false;
            this.dtDSPhieu.Name = "dtDSPhieu";
            this.dtDSPhieu.ReadOnly = true;
            this.dtDSPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDSPhieu.Size = new System.Drawing.Size(462, 199);
            this.dtDSPhieu.TabIndex = 11;
            this.dtDSPhieu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDSPhieu_CellDoubleClick);
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThayDoi.ForeColor = System.Drawing.Color.Black;
            this.btnLuuThayDoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuThayDoi.Image")));
            this.btnLuuThayDoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuThayDoi.Location = new System.Drawing.Point(218, 529);
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(182, 46);
            this.btnLuuThayDoi.TabIndex = 1;
            this.btnLuuThayDoi.Text = "Lưu thay đổi";
            this.btnLuuThayDoi.UseVisualStyleBackColor = true;
            // 
            // treeFunctionList
            // 
            this.treeFunctionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeFunctionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFunctionList.Location = new System.Drawing.Point(2, 153);
            this.treeFunctionList.Name = "treeFunctionList";
            this.treeFunctionList.Size = new System.Drawing.Size(262, 647);
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
            this.tabControl.Size = new System.Drawing.Size(1072, 788);
            this.tabControl.TabIndex = 6;
            // 
            // tabLichLam
            // 
            this.tabLichLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLichLam.Location = new System.Drawing.Point(4, 38);
            this.tabLichLam.Name = "tabLichLam";
            this.tabLichLam.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichLam.Size = new System.Drawing.Size(1064, 746);
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
            this.tabTinhHinhTaiChinh.Size = new System.Drawing.Size(1064, 746);
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
            this.tabKiemKho.Size = new System.Drawing.Size(1064, 746);
            this.tabKiemKho.TabIndex = 2;
            this.tabKiemKho.Text = "Lập phiếu kiểm kho";
            this.tabKiemKho.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblMaPhieu);
            this.groupBox5.Controls.Add(this.lblMaPhieuTitle);
            this.groupBox5.Controls.Add(this.btnLuuThayDoi);
            this.groupBox5.Controls.Add(this.dtChiTietPhieuTK);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(517, 56);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(551, 581);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết phiếu nhập kho";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieu.ForeColor = System.Drawing.Color.Blue;
            this.lblMaPhieu.Location = new System.Drawing.Point(307, 18);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(34, 29);
            this.lblMaPhieu.TabIndex = 2;
            this.lblMaPhieu.Text = "...";
            // 
            // lblMaPhieuTitle
            // 
            this.lblMaPhieuTitle.AutoSize = true;
            this.lblMaPhieuTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuTitle.ForeColor = System.Drawing.Color.Black;
            this.lblMaPhieuTitle.Location = new System.Drawing.Point(182, 18);
            this.lblMaPhieuTitle.Name = "lblMaPhieuTitle";
            this.lblMaPhieuTitle.Size = new System.Drawing.Size(119, 29);
            this.lblMaPhieuTitle.TabIndex = 1;
            this.lblMaPhieuTitle.Text = "Mã phiếu";
            // 
            // dtChiTietPhieuTK
            // 
            this.dtChiTietPhieuTK.AllowUserToAddRows = false;
            this.dtChiTietPhieuTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtChiTietPhieuTK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtChiTietPhieuTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtChiTietPhieuTK.Location = new System.Drawing.Point(6, 47);
            this.dtChiTietPhieuTK.Name = "dtChiTietPhieuTK";
            this.dtChiTietPhieuTK.Size = new System.Drawing.Size(539, 466);
            this.dtChiTietPhieuTK.TabIndex = 0;
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
            this.groupBox3.Size = new System.Drawing.Size(474, 151);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tạo phiếu nhập";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ImageIndex = 8;
            this.btnCapNhat.ImageList = this.tabImageList;
            this.btnCapNhat.Location = new System.Drawing.Point(397, 27);
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
            this.btnTaoPhieuNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuNhap.ForeColor = System.Drawing.Color.Black;
            this.btnTaoPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoPhieuNhap.Image")));
            this.btnTaoPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPhieuNhap.Location = new System.Drawing.Point(147, 95);
            this.btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
            this.btnTaoPhieuNhap.Size = new System.Drawing.Size(237, 39);
            this.btnTaoPhieuNhap.TabIndex = 5;
            this.btnTaoPhieuNhap.Text = "Tạo phiếu nhập";
            this.btnTaoPhieuNhap.UseVisualStyleBackColor = true;
            this.btnTaoPhieuNhap.Click += new System.EventHandler(this.btnTaoPhieuNhap_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(62, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Loại phiếu nhập:";
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpNgayLapPhieu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(207, 29);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(184, 23);
            this.dtpNgayLapPhieu.TabIndex = 1;
            // 
            // cbLoaiPhieuTao
            // 
            this.cbLoaiPhieuTao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhieuTao.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhieuTao.FormattingEnabled = true;
            this.cbLoaiPhieuTao.Items.AddRange(new object[] {
            "Đầu ngày",
            "Cuối ngày"});
            this.cbLoaiPhieuTao.Location = new System.Drawing.Point(207, 61);
            this.cbLoaiPhieuTao.Name = "cbLoaiPhieuTao";
            this.cbLoaiPhieuTao.Size = new System.Drawing.Size(219, 24);
            this.cbLoaiPhieuTao.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(62, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
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
            this.groupBox2.Location = new System.Drawing.Point(23, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 116);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem phiếu nhập kho";
            // 
            // btnXemPhieu
            // 
            this.btnXemPhieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemPhieu.ForeColor = System.Drawing.Color.Black;
            this.btnXemPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnXemPhieu.Image")));
            this.btnXemPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemPhieu.Location = new System.Drawing.Point(147, 51);
            this.btnXemPhieu.Name = "btnXemPhieu";
            this.btnXemPhieu.Size = new System.Drawing.Size(237, 43);
            this.btnXemPhieu.TabIndex = 8;
            this.btnXemPhieu.Text = "Tải danh sách phiếu";
            this.btnXemPhieu.UseVisualStyleBackColor = true;
            this.btnXemPhieu.Click += new System.EventHandler(this.btnXemPhieu_Click);
            // 
            // cbLoaiPhieuXem
            // 
            this.cbLoaiPhieuXem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhieuXem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhieuXem.FormattingEnabled = true;
            this.cbLoaiPhieuXem.Items.AddRange(new object[] {
            "Tất cả",
            "Đầu ngày",
            "Cuối ngày"});
            this.cbLoaiPhieuXem.Location = new System.Drawing.Point(213, 22);
            this.cbLoaiPhieuXem.Name = "cbLoaiPhieuXem";
            this.cbLoaiPhieuXem.Size = new System.Drawing.Size(171, 23);
            this.cbLoaiPhieuXem.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(102, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
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
            this.tabThongTinKho.Size = new System.Drawing.Size(1064, 746);
            this.tabThongTinKho.TabIndex = 3;
            this.tabThongTinKho.Text = "Tra cứu thông tin kho";
            this.tabThongTinKho.UseVisualStyleBackColor = true;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.btn_XoaSP);
            this.tabSanPham.Controls.Add(this.btn_SuaSP);
            this.tabSanPham.Controls.Add(this.btn_themSP);
            this.tabSanPham.Controls.Add(this.dgv_info_SanPham);
            this.tabSanPham.ImageIndex = 4;
            this.tabSanPham.Location = new System.Drawing.Point(4, 38);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPham.Size = new System.Drawing.Size(1064, 746);
            this.tabSanPham.TabIndex = 4;
            this.tabSanPham.Text = "Sản phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.AutoSize = true;
            this.btn_XoaSP.Location = new System.Drawing.Point(445, 403);
            this.btn_XoaSP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(100, 39);
            this.btn_XoaSP.TabIndex = 3;
            this.btn_XoaSP.Text = "Xóa";
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            // 
            // btn_SuaSP
            // 
            this.btn_SuaSP.AutoSize = true;
            this.btn_SuaSP.Location = new System.Drawing.Point(260, 403);
            this.btn_SuaSP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SuaSP.Name = "btn_SuaSP";
            this.btn_SuaSP.Size = new System.Drawing.Size(112, 39);
            this.btn_SuaSP.TabIndex = 2;
            this.btn_SuaSP.Text = "Sửa";
            this.btn_SuaSP.UseVisualStyleBackColor = true;
            // 
            // btn_themSP
            // 
            this.btn_themSP.AutoSize = true;
            this.btn_themSP.Location = new System.Drawing.Point(88, 403);
            this.btn_themSP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_themSP.Name = "btn_themSP";
            this.btn_themSP.Size = new System.Drawing.Size(140, 39);
            this.btn_themSP.TabIndex = 1;
            this.btn_themSP.Text = "Thêm mới";
            this.btn_themSP.UseVisualStyleBackColor = true;
            this.btn_themSP.Click += new System.EventHandler(this.btn_themSP_Click);
            // 
            // dgv_info_SanPham
            // 
            this.dgv_info_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info_SanPham.Location = new System.Drawing.Point(0, 2);
            this.dgv_info_SanPham.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_info_SanPham.Name = "dgv_info_SanPham";
            this.dgv_info_SanPham.RowTemplate.Height = 24;
            this.dgv_info_SanPham.Size = new System.Drawing.Size(698, 364);
            this.dgv_info_SanPham.TabIndex = 0;
            // 
            // tabNguyenLieu
            // 
            this.tabNguyenLieu.ImageIndex = 5;
            this.tabNguyenLieu.Location = new System.Drawing.Point(4, 38);
            this.tabNguyenLieu.Name = "tabNguyenLieu";
            this.tabNguyenLieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabNguyenLieu.Size = new System.Drawing.Size(1064, 746);
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
            this.tabNhanVien.Size = new System.Drawing.Size(1064, 746);
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
            this.tabKhachHang.Size = new System.Drawing.Size(1064, 746);
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
            this.tabNhapKho.Size = new System.Drawing.Size(1064, 746);
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
            this.txtUserPosition.Enabled = false;
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
            this.txtUserName.Enabled = false;
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
            this.txtUserID.Enabled = false;
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
            this.ClientSize = new System.Drawing.Size(1354, 709);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.treeFunctionList);
            this.Name = "ManagerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng Pizza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ManagerUI_Activated);
            this.Load += new System.EventHandler(this.ManagerUI_Load);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDSPhieu)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabKiemKho.ResumeLayout(false);
            this.tabKiemKho.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtChiTietPhieuTK)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSanPham.ResumeLayout(false);
            this.tabSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info_SanPham)).EndInit();
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
        private System.Windows.Forms.DataGridView dtChiTietPhieuTK;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnLuuThayDoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgv_info_SanPham;
        private System.Windows.Forms.Button btn_XoaSP;
        private System.Windows.Forms.Button btn_SuaSP;
        private System.Windows.Forms.Button btn_themSP;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.Label lblMaPhieuTitle;
        private System.Windows.Forms.Button btnXemChiTietPhieu;
    }
}

