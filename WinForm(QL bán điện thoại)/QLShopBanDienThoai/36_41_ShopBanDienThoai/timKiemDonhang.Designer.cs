namespace _36_41_ShopBanDienThoai
{
    partial class timKiemDonhang
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
            this.dgvDSKQ = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldatetime = new System.Windows.Forms.Label();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXemDTtheoNam = new System.Windows.Forms.Button();
            this.btnXemDTtheoThang = new System.Windows.Forms.Button();
            this.btnXemHDtheoMa = new System.Windows.Forms.Button();
            this.btnTop5Mua = new System.Windows.Forms.Button();
            this.Top5Ban = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKQ)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSKQ);
            this.groupBox1.Location = new System.Drawing.Point(24, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 201);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả tìm kiếm";
            // 
            // dgvDSKQ
            // 
            this.dgvDSKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKQ.Location = new System.Drawing.Point(14, 19);
            this.dgvDSKQ.Name = "dgvDSKQ";
            this.dgvDSKQ.Size = new System.Drawing.Size(722, 176);
            this.dgvDSKQ.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "THỐNG KÊ ĐƠN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(205)))));
            this.btnTim.Location = new System.Drawing.Point(229, 39);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(85, 59);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(122, 20);
            this.dtpNgay.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã hóa đơn";
            // 
            // lbldatetime
            // 
            this.lbldatetime.Location = new System.Drawing.Point(2, 56);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(77, 23);
            this.lbldatetime.TabIndex = 16;
            this.lbldatetime.Text = "Ngày ";
            // 
            // txtMahd
            // 
            this.txtMahd.Location = new System.Drawing.Point(85, 21);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(122, 20);
            this.txtMahd.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Controls.Add(this.btnXemDTtheoNam);
            this.groupBox2.Controls.Add(this.Top5Ban);
            this.groupBox2.Controls.Add(this.btnTop5Mua);
            this.groupBox2.Controls.Add(this.btnXemDTtheoThang);
            this.groupBox2.Controls.Add(this.btnXemHDtheoMa);
            this.groupBox2.Location = new System.Drawing.Point(353, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 112);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnXemDTtheoNam
            // 
            this.btnXemDTtheoNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(205)))));
            this.btnXemDTtheoNam.Location = new System.Drawing.Point(6, 48);
            this.btnXemDTtheoNam.Name = "btnXemDTtheoNam";
            this.btnXemDTtheoNam.Size = new System.Drawing.Size(165, 23);
            this.btnXemDTtheoNam.TabIndex = 14;
            this.btnXemDTtheoNam.Text = "Xem doanh thu theo năm";
            this.btnXemDTtheoNam.UseVisualStyleBackColor = false;
            this.btnXemDTtheoNam.Click += new System.EventHandler(this.btnXemDTtheoNam_Click);
            // 
            // btnXemDTtheoThang
            // 
            this.btnXemDTtheoThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(205)))));
            this.btnXemDTtheoThang.Location = new System.Drawing.Point(177, 19);
            this.btnXemDTtheoThang.Name = "btnXemDTtheoThang";
            this.btnXemDTtheoThang.Size = new System.Drawing.Size(165, 23);
            this.btnXemDTtheoThang.TabIndex = 14;
            this.btnXemDTtheoThang.Text = "Xem doanh thu  theo tháng";
            this.btnXemDTtheoThang.UseVisualStyleBackColor = false;
            this.btnXemDTtheoThang.Click += new System.EventHandler(this.btnXemDTtheoThang_Click);
            // 
            // btnXemHDtheoMa
            // 
            this.btnXemHDtheoMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(205)))));
            this.btnXemHDtheoMa.Location = new System.Drawing.Point(6, 19);
            this.btnXemHDtheoMa.Name = "btnXemHDtheoMa";
            this.btnXemHDtheoMa.Size = new System.Drawing.Size(165, 23);
            this.btnXemHDtheoMa.TabIndex = 14;
            this.btnXemHDtheoMa.Text = "Xem doanh thu theo hd";
            this.btnXemHDtheoMa.UseVisualStyleBackColor = false;
            this.btnXemHDtheoMa.Click += new System.EventHandler(this.btnXemHDtheoMa_Click);
            // 
            // btnTop5Mua
            // 
            this.btnTop5Mua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(205)))));
            this.btnTop5Mua.Location = new System.Drawing.Point(177, 48);
            this.btnTop5Mua.Name = "btnTop5Mua";
            this.btnTop5Mua.Size = new System.Drawing.Size(165, 23);
            this.btnTop5Mua.TabIndex = 14;
            this.btnTop5Mua.Text = "Top 5 KH mua nhiều nhất";
            this.btnTop5Mua.UseVisualStyleBackColor = false;
            this.btnTop5Mua.Click += new System.EventHandler(this.btnTop5Mua_Click);
            // 
            // Top5Ban
            // 
            this.Top5Ban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(205)))));
            this.Top5Ban.Location = new System.Drawing.Point(116, 77);
            this.Top5Ban.Name = "Top5Ban";
            this.Top5Ban.Size = new System.Drawing.Size(165, 23);
            this.Top5Ban.TabIndex = 14;
            this.Top5Ban.Text = "Top 5 NV bán nhiều nhất";
            this.Top5Ban.UseVisualStyleBackColor = false;
            this.Top5Ban.Click += new System.EventHandler(this.Top5Ban_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Controls.Add(this.txtMahd);
            this.groupBox3.Controls.Add(this.dtpNgay);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lbldatetime);
            this.groupBox3.Location = new System.Drawing.Point(24, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 112);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin";
            // 
            // timKiemDonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "timKiemDonhang";
            this.Text = "timKiemDonhang";
            this.Load += new System.EventHandler(this.timKiemDonhang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKQ)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSKQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldatetime;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXemDTtheoNam;
        private System.Windows.Forms.Button btnXemDTtheoThang;
        private System.Windows.Forms.Button btnXemHDtheoMa;
        private System.Windows.Forms.Button btnTop5Mua;
        private System.Windows.Forms.Button Top5Ban;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}