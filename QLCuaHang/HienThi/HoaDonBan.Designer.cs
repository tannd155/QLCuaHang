namespace QLCuaHang.HienThi
{
    partial class HoaDonBan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaHDB = new System.Windows.Forms.Button();
            this.btnXoaHDB = new System.Windows.Forms.Button();
            this.btnThemHDB = new System.Windows.Forms.Button();
            this.dtvHDB = new System.Windows.Forms.DataGridView();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSuaCTHDB = new System.Windows.Forms.Button();
            this.btnXoaCTHDB = new System.Windows.Forms.Button();
            this.btnThemCTHDB = new System.Windows.Forms.Button();
            this.dtvCTHDB = new System.Windows.Forms.DataGridView();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaMH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHDB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCTHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuaHDB);
            this.groupBox1.Controls.Add(this.btnXoaHDB);
            this.groupBox1.Controls.Add(this.btnThemHDB);
            this.groupBox1.Controls.Add(this.dtvHDB);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbMaKH);
            this.groupBox1.Controls.Add(this.txtMaHDB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // btnSuaHDB
            // 
            this.btnSuaHDB.Location = new System.Drawing.Point(217, 129);
            this.btnSuaHDB.Name = "btnSuaHDB";
            this.btnSuaHDB.Size = new System.Drawing.Size(75, 40);
            this.btnSuaHDB.TabIndex = 15;
            this.btnSuaHDB.Text = "Sửa";
            this.btnSuaHDB.UseVisualStyleBackColor = true;
            this.btnSuaHDB.Click += new System.EventHandler(this.btnSuaHDB_Click);
            // 
            // btnXoaHDB
            // 
            this.btnXoaHDB.Location = new System.Drawing.Point(132, 129);
            this.btnXoaHDB.Name = "btnXoaHDB";
            this.btnXoaHDB.Size = new System.Drawing.Size(75, 40);
            this.btnXoaHDB.TabIndex = 14;
            this.btnXoaHDB.Text = "Xóa";
            this.btnXoaHDB.UseVisualStyleBackColor = true;
            // 
            // btnThemHDB
            // 
            this.btnThemHDB.Location = new System.Drawing.Point(51, 129);
            this.btnThemHDB.Name = "btnThemHDB";
            this.btnThemHDB.Size = new System.Drawing.Size(75, 40);
            this.btnThemHDB.TabIndex = 13;
            this.btnThemHDB.Text = "Thêm";
            this.btnThemHDB.UseVisualStyleBackColor = true;
            this.btnThemHDB.Click += new System.EventHandler(this.btnThemHDB_Click);
            // 
            // dtvHDB
            // 
            this.dtvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvHDB.Location = new System.Drawing.Point(359, 19);
            this.dtvHDB.Name = "dtvHDB";
            this.dtvHDB.Size = new System.Drawing.Size(287, 150);
            this.dtvHDB.TabIndex = 6;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Location = new System.Drawing.Point(132, 78);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(160, 20);
            this.dtpNgayBan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(132, 46);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(160, 21);
            this.cbbMaKH.TabIndex = 2;
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Location = new System.Drawing.Point(132, 19);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(160, 20);
            this.txtMaHDB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSuaCTHDB);
            this.groupBox2.Controls.Add(this.btnXoaCTHDB);
            this.groupBox2.Controls.Add(this.btnThemCTHDB);
            this.groupBox2.Controls.Add(this.dtvCTHDB);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbbMaMH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(21, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin CT Hóa Đơn";
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
            // btnSuaCTHDB
            // 
            this.btnSuaCTHDB.Location = new System.Drawing.Point(470, 44);
            this.btnSuaCTHDB.Name = "btnSuaCTHDB";
            this.btnSuaCTHDB.Size = new System.Drawing.Size(75, 40);
            this.btnSuaCTHDB.TabIndex = 12;
            this.btnSuaCTHDB.Text = "Sửa";
            this.btnSuaCTHDB.UseVisualStyleBackColor = true;
            this.btnSuaCTHDB.Click += new System.EventHandler(this.btnSuaCTHDB_Click);
            // 
            // btnXoaCTHDB
            // 
            this.btnXoaCTHDB.Location = new System.Drawing.Point(389, 44);
            this.btnXoaCTHDB.Name = "btnXoaCTHDB";
            this.btnXoaCTHDB.Size = new System.Drawing.Size(75, 40);
            this.btnXoaCTHDB.TabIndex = 11;
            this.btnXoaCTHDB.Text = "Xóa";
            this.btnXoaCTHDB.UseVisualStyleBackColor = true;
            // 
            // btnThemCTHDB
            // 
            this.btnThemCTHDB.Location = new System.Drawing.Point(308, 44);
            this.btnThemCTHDB.Name = "btnThemCTHDB";
            this.btnThemCTHDB.Size = new System.Drawing.Size(75, 40);
            this.btnThemCTHDB.TabIndex = 10;
            this.btnThemCTHDB.Text = "Thêm";
            this.btnThemCTHDB.UseVisualStyleBackColor = true;
            this.btnThemCTHDB.Click += new System.EventHandler(this.btnThemCTHDB_Click);
            // 
            // dtvCTHDB
            // 
            this.dtvCTHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCTHDB.Location = new System.Drawing.Point(20, 110);
            this.dtvCTHDB.Name = "dtvCTHDB";
            this.dtvCTHDB.Size = new System.Drawing.Size(490, 150);
            this.dtvCTHDB.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông Tin Hóa Đơn Bán Hàng";
            // 
            // HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoaDonBan";
            this.Text = "HoaDonNhap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHDB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCTHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtvHDB;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaHDB;
        private System.Windows.Forms.Button btnXoaHDB;
        private System.Windows.Forms.Button btnThemHDB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSuaCTHDB;
        private System.Windows.Forms.Button btnXoaCTHDB;
        private System.Windows.Forms.Button btnThemCTHDB;
        private System.Windows.Forms.DataGridView dtvCTHDB;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMaMH;
        private System.Windows.Forms.Label label5;
    }
}