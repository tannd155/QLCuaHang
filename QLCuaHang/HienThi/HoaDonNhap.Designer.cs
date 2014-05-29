namespace QLCuaHang.HienThi
{
    partial class HoaDonNhap
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSuaCTHDN = new System.Windows.Forms.Button();
            this.btnXoaCTHDN = new System.Windows.Forms.Button();
            this.btnThemCTHDN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvCTHDN = new System.Windows.Forms.DataGridView();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaMH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoaHDN = new System.Windows.Forms.Button();
            this.btnThemHDN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuaHDN = new System.Windows.Forms.Button();
            this.dtvHDN = new System.Windows.Forms.DataGridView();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaNCC = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCTHDN)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(551, 44);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 40);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSuaCTHDN
            // 
            this.btnSuaCTHDN.Location = new System.Drawing.Point(470, 44);
            this.btnSuaCTHDN.Name = "btnSuaCTHDN";
            this.btnSuaCTHDN.Size = new System.Drawing.Size(75, 40);
            this.btnSuaCTHDN.TabIndex = 12;
            this.btnSuaCTHDN.Text = "Sửa";
            this.btnSuaCTHDN.UseVisualStyleBackColor = true;
            this.btnSuaCTHDN.Click += new System.EventHandler(this.btnSuaCTHDN_Click);
            // 
            // btnXoaCTHDN
            // 
            this.btnXoaCTHDN.Location = new System.Drawing.Point(389, 44);
            this.btnXoaCTHDN.Name = "btnXoaCTHDN";
            this.btnXoaCTHDN.Size = new System.Drawing.Size(75, 40);
            this.btnXoaCTHDN.TabIndex = 11;
            this.btnXoaCTHDN.Text = "Xóa";
            this.btnXoaCTHDN.UseVisualStyleBackColor = true;
            // 
            // btnThemCTHDN
            // 
            this.btnThemCTHDN.Location = new System.Drawing.Point(308, 44);
            this.btnThemCTHDN.Name = "btnThemCTHDN";
            this.btnThemCTHDN.Size = new System.Drawing.Size(75, 40);
            this.btnThemCTHDN.TabIndex = 10;
            this.btnThemCTHDN.Text = "Thêm";
            this.btnThemCTHDN.UseVisualStyleBackColor = true;
            this.btnThemCTHDN.Click += new System.EventHandler(this.btnThemCTHDN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông Tin Hóa Đơn Nhập Hàng";
            // 
            // dtvCTHDN
            // 
            this.dtvCTHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCTHDN.Location = new System.Drawing.Point(20, 110);
            this.dtvCTHDN.Name = "dtvCTHDN";
            this.dtvCTHDN.Size = new System.Drawing.Size(490, 150);
            this.dtvCTHDN.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(111, 81);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(160, 20);
            this.txtDonGia.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn Giá";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(111, 55);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(160, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số Lượng";
            // 
            // cbbMaMH
            // 
            this.cbbMaMH.FormattingEnabled = true;
            this.cbbMaMH.Location = new System.Drawing.Point(111, 28);
            this.cbbMaMH.Name = "cbbMaMH";
            this.cbbMaMH.Size = new System.Drawing.Size(160, 21);
            this.cbbMaMH.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Mặt Hàng";
            // 
            // btnXoaHDN
            // 
            this.btnXoaHDN.Location = new System.Drawing.Point(132, 129);
            this.btnXoaHDN.Name = "btnXoaHDN";
            this.btnXoaHDN.Size = new System.Drawing.Size(75, 40);
            this.btnXoaHDN.TabIndex = 14;
            this.btnXoaHDN.Text = "Xóa";
            this.btnXoaHDN.UseVisualStyleBackColor = true;
            // 
            // btnThemHDN
            // 
            this.btnThemHDN.Location = new System.Drawing.Point(51, 129);
            this.btnThemHDN.Name = "btnThemHDN";
            this.btnThemHDN.Size = new System.Drawing.Size(75, 40);
            this.btnThemHDN.TabIndex = 13;
            this.btnThemHDN.Text = "Thêm";
            this.btnThemHDN.UseVisualStyleBackColor = true;
            this.btnThemHDN.Click += new System.EventHandler(this.btnThemHDN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSuaCTHDN);
            this.groupBox2.Controls.Add(this.btnXoaCTHDN);
            this.groupBox2.Controls.Add(this.btnThemCTHDN);
            this.groupBox2.Controls.Add(this.dtvCTHDN);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbbMaMH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(22, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 266);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin CT Hóa Đơn";
            // 
            // btnSuaHDN
            // 
            this.btnSuaHDN.Location = new System.Drawing.Point(217, 129);
            this.btnSuaHDN.Name = "btnSuaHDN";
            this.btnSuaHDN.Size = new System.Drawing.Size(75, 40);
            this.btnSuaHDN.TabIndex = 15;
            this.btnSuaHDN.Text = "Sửa";
            this.btnSuaHDN.UseVisualStyleBackColor = true;
            this.btnSuaHDN.Click += new System.EventHandler(this.btnSuaHDN_Click);
            // 
            // dtvHDN
            // 
            this.dtvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvHDN.Location = new System.Drawing.Point(359, 19);
            this.dtvHDN.Name = "dtvHDN";
            this.dtvHDN.Size = new System.Drawing.Size(287, 150);
            this.dtvHDN.TabIndex = 6;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(132, 78);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(160, 20);
            this.dtpNgayNhap.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Nhà Cung Cấp";
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.Location = new System.Drawing.Point(132, 46);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.Size = new System.Drawing.Size(160, 21);
            this.cbbMaNCC.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuaHDN);
            this.groupBox1.Controls.Add(this.btnXoaHDN);
            this.groupBox1.Controls.Add(this.btnThemHDN);
            this.groupBox1.Controls.Add(this.dtvHDN);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbMaNCC);
            this.groupBox1.Controls.Add(this.txtMaHDN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(132, 19);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(160, 20);
            this.txtMaHDN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoaDonNhap";
            this.Text = "HoaDonNhap";
            ((System.ComponentModel.ISupportInitialize)(this.dtvCTHDN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSuaCTHDN;
        private System.Windows.Forms.Button btnXoaCTHDN;
        private System.Windows.Forms.Button btnThemCTHDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvCTHDN;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoaHDN;
        private System.Windows.Forms.Button btnThemHDN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSuaHDN;
        private System.Windows.Forms.DataGridView dtvHDN;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label label2;
    }
}