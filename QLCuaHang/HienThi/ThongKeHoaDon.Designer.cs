namespace QLCuaHang.HienThi
{
    partial class ThongKeHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHDNTu = new System.Windows.Forms.DateTimePicker();
            this.dtpHDNDen = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKeNhap = new System.Windows.Forms.Button();
            this.btnThongKeBan = new System.Windows.Forms.Button();
            this.dtpHDBDen = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHDBTu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtvHDN = new System.Windows.Forms.DataGridView();
            this.dtvHDB = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Hóa Đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtvHDN);
            this.groupBox1.Controls.Add(this.btnThongKeNhap);
            this.groupBox1.Controls.Add(this.dtpHDNDen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpHDNTu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtvHDB);
            this.groupBox2.Controls.Add(this.btnThongKeBan);
            this.groupBox2.Controls.Add(this.dtpHDBDen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpHDBTu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 197);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ Ngày";
            // 
            // dtpHDNTu
            // 
            this.dtpHDNTu.Location = new System.Drawing.Point(90, 20);
            this.dtpHDNTu.Name = "dtpHDNTu";
            this.dtpHDNTu.Size = new System.Drawing.Size(158, 20);
            this.dtpHDNTu.TabIndex = 1;
            // 
            // dtpHDNDen
            // 
            this.dtpHDNDen.Location = new System.Drawing.Point(90, 58);
            this.dtpHDNDen.Name = "dtpHDNDen";
            this.dtpHDNDen.Size = new System.Drawing.Size(158, 20);
            this.dtpHDNDen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến Ngày";
            // 
            // btnThongKeNhap
            // 
            this.btnThongKeNhap.Location = new System.Drawing.Point(151, 108);
            this.btnThongKeNhap.Name = "btnThongKeNhap";
            this.btnThongKeNhap.Size = new System.Drawing.Size(93, 36);
            this.btnThongKeNhap.TabIndex = 4;
            this.btnThongKeNhap.Text = "Thống Kê";
            this.btnThongKeNhap.UseVisualStyleBackColor = true;
            this.btnThongKeNhap.Click += new System.EventHandler(this.btnThongKeNhap_Click);
            // 
            // btnThongKeBan
            // 
            this.btnThongKeBan.Location = new System.Drawing.Point(151, 123);
            this.btnThongKeBan.Name = "btnThongKeBan";
            this.btnThongKeBan.Size = new System.Drawing.Size(93, 36);
            this.btnThongKeBan.TabIndex = 9;
            this.btnThongKeBan.Text = "Thống Kê";
            this.btnThongKeBan.UseVisualStyleBackColor = true;
            this.btnThongKeBan.Click += new System.EventHandler(this.btnThongKeBan_Click);
            // 
            // dtpHDBDen
            // 
            this.dtpHDBDen.Location = new System.Drawing.Point(90, 73);
            this.dtpHDBDen.Name = "dtpHDBDen";
            this.dtpHDBDen.Size = new System.Drawing.Size(158, 20);
            this.dtpHDBDen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đến Ngày";
            // 
            // dtpHDBTu
            // 
            this.dtpHDBTu.Location = new System.Drawing.Point(90, 25);
            this.dtpHDBTu.Name = "dtpHDBTu";
            this.dtpHDBTu.Size = new System.Drawing.Size(158, 20);
            this.dtpHDBTu.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Từ Ngày";
            // 
            // dtvHDN
            // 
            this.dtvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvHDN.Location = new System.Drawing.Point(267, 23);
            this.dtvHDN.Name = "dtvHDN";
            this.dtvHDN.Size = new System.Drawing.Size(319, 156);
            this.dtvHDN.TabIndex = 5;
            // 
            // dtvHDB
            // 
            this.dtvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvHDB.Location = new System.Drawing.Point(267, 19);
            this.dtvHDB.Name = "dtvHDB";
            this.dtvHDB.Size = new System.Drawing.Size(319, 156);
            this.dtvHDB.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(506, 477);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 36);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 525);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeHoaDon";
            this.Text = "ThongKeHoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThongKeNhap;
        private System.Windows.Forms.DateTimePicker dtpHDNDen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHDNTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtvHDN;
        private System.Windows.Forms.DataGridView dtvHDB;
        private System.Windows.Forms.Button btnThongKeBan;
        private System.Windows.Forms.DateTimePicker dtpHDBDen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHDBTu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
    }
}