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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerUI));
            this.btnLichLam = new System.Windows.Forms.Button();
            this.btnQuanLyDoanhThu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLichLam
            // 
            this.btnLichLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichLam.Image = ((System.Drawing.Image)(resources.GetObject("btnLichLam.Image")));
            this.btnLichLam.Location = new System.Drawing.Point(147, 91);
            this.btnLichLam.Name = "btnLichLam";
            this.btnLichLam.Size = new System.Drawing.Size(207, 154);
            this.btnLichLam.TabIndex = 0;
            this.btnLichLam.Text = "Quản lý lịch làm việc cho nhân viên";
            this.btnLichLam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLichLam.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyDoanhThu
            // 
            this.btnQuanLyDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyDoanhThu.Image")));
            this.btnQuanLyDoanhThu.Location = new System.Drawing.Point(21, 274);
            this.btnQuanLyDoanhThu.Name = "btnQuanLyDoanhThu";
            this.btnQuanLyDoanhThu.Size = new System.Drawing.Size(177, 139);
            this.btnQuanLyDoanhThu.TabIndex = 1;
            this.btnQuanLyDoanhThu.Text = "Quản lý doanh thu";
            this.btnQuanLyDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuanLyDoanhThu.UseVisualStyleBackColor = true;
            this.btnQuanLyDoanhThu.Click += new System.EventHandler(this.btnQuanLyDoanhThu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quản lý kho nguyên liệu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Quản lý thông tin các đối tượng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(27, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(464, 46);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Quản lý nhà hàng Pizza";
            // 
            // ManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 621);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuanLyDoanhThu);
            this.Controls.Add(this.btnLichLam);
            this.Name = "ManagerUI";
            this.Text = "Giao diện quản lý";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLichLam;
        private System.Windows.Forms.Button btnQuanLyDoanhThu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTitle;
    }
}

