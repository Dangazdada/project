
namespace _36_41_ShopBanDienThoai
{
    partial class frmnhapKhachHang
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
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.dgvDanhsach = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNhapEmail = new System.Windows.Forms.TextBox();
            this.txtNhapDChi = new System.Windows.Forms.TextBox();
            this.txtNhapSDT = new System.Windows.Forms.TextBox();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.txtNhapHo = new System.Windows.Forms.TextBox();
            this.txtnhapMaKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Dừng hoạt động"});
            this.cboTrangThai.Location = new System.Drawing.Point(99, 156);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(145, 21);
            this.cboTrangThai.TabIndex = 6;
            // 
            // dgvDanhsach
            // 
            this.dgvDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.HoKH,
            this.TenKH,
            this.SDT,
            this.DiaChi,
            this.Email,
            this.TrangThai});
            this.dgvDanhsach.Location = new System.Drawing.Point(29, 286);
            this.dgvDanhsach.Name = "dgvDanhsach";
            this.dgvDanhsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhsach.Size = new System.Drawing.Size(742, 150);
            this.dgvDanhsach.TabIndex = 6;
            this.dgvDanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsach_CellClick);
            this.dgvDanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsach_CellContentClick);
            this.dgvDanhsach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsach_CellValueChanged);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MaKH";
            this.MAKH.HeaderText = "Mã KH";
            this.MAKH.Name = "MAKH";
            // 
            // HoKH
            // 
            this.HoKH.DataPropertyName = "HoKH";
            this.HoKH.HeaderText = "Họ KH";
            this.HoKH.Name = "HoKH";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(14, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 161);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Them";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(446, 78);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 30);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(321, 114);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 30);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(446, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(321, 78);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNhapEmail
            // 
            this.txtNhapEmail.Location = new System.Drawing.Point(99, 133);
            this.txtNhapEmail.Name = "txtNhapEmail";
            this.txtNhapEmail.Size = new System.Drawing.Size(145, 20);
            this.txtNhapEmail.TabIndex = 5;
            // 
            // txtNhapDChi
            // 
            this.txtNhapDChi.Location = new System.Drawing.Point(99, 107);
            this.txtNhapDChi.Name = "txtNhapDChi";
            this.txtNhapDChi.Size = new System.Drawing.Size(145, 20);
            this.txtNhapDChi.TabIndex = 4;
            // 
            // txtNhapSDT
            // 
            this.txtNhapSDT.Location = new System.Drawing.Point(99, 81);
            this.txtNhapSDT.Name = "txtNhapSDT";
            this.txtNhapSDT.Size = new System.Drawing.Size(145, 20);
            this.txtNhapSDT.TabIndex = 3;
            this.txtNhapSDT.TextChanged += new System.EventHandler(this.txtNhapSDT_TextChanged);
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Location = new System.Drawing.Point(99, 55);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(145, 20);
            this.txtNhapTen.TabIndex = 2;
            // 
            // txtNhapHo
            // 
            this.txtNhapHo.Location = new System.Drawing.Point(99, 32);
            this.txtNhapHo.Name = "txtNhapHo";
            this.txtNhapHo.Size = new System.Drawing.Size(145, 20);
            this.txtNhapHo.TabIndex = 1;
            // 
            // txtnhapMaKH
            // 
            this.txtnhapMaKH.Location = new System.Drawing.Point(99, 9);
            this.txtnhapMaKH.Name = "txtnhapMaKH";
            this.txtnhapMaKH.Size = new System.Drawing.Size(145, 20);
            this.txtnhapMaKH.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(2, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Trạng Thái";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(2, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(2, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa chỉ ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(2, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên lót và tên NV";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Họ NV";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã KH";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GroupBox2.Controls.Add(this.txtnhapMaKH);
            this.GroupBox2.Controls.Add(this.cboTrangThai);
            this.GroupBox2.Controls.Add(this.label1);
            this.GroupBox2.Controls.Add(this.label2);
            this.GroupBox2.Controls.Add(this.label3);
            this.GroupBox2.Controls.Add(this.label4);
            this.GroupBox2.Controls.Add(this.label5);
            this.GroupBox2.Controls.Add(this.label6);
            this.GroupBox2.Controls.Add(this.label7);
            this.GroupBox2.Controls.Add(this.txtNhapEmail);
            this.GroupBox2.Controls.Add(this.txtNhapHo);
            this.GroupBox2.Controls.Add(this.txtNhapDChi);
            this.GroupBox2.Controls.Add(this.txtNhapTen);
            this.GroupBox2.Controls.Add(this.txtNhapSDT);
            this.GroupBox2.Location = new System.Drawing.Point(14, 54);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(264, 185);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Nhập thông tin";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(447, 150);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 29);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(322, 150);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 29);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "&Huy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DodgerBlue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(800, 27);
            this.label8.TabIndex = 26;
            this.label8.Text = "KHÁCH HÀNG";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChon
            // 
            this.btnChon.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChon.Location = new System.Drawing.Point(380, 213);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(86, 30);
            this.btnChon.TabIndex = 3;
            this.btnChon.Text = "Chọn ";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(567, 210);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 20);
            this.txtsdt.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(507, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "sdt:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Tìm kh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmnhapKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.dgvDanhsach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "frmnhapKhachHang";
            this.Text = "frmnhapKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmnhapKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmnhapKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.DataGridView dgvDanhsach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNhapEmail;
        private System.Windows.Forms.TextBox txtNhapDChi;
        private System.Windows.Forms.TextBox txtNhapSDT;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.TextBox txtNhapHo;
        private System.Windows.Forms.TextBox txtnhapMaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}