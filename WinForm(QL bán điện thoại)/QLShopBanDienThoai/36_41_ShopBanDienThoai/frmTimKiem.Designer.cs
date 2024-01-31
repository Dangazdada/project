namespace _36_41_ShopBanDienThoai
{
    partial class frmTimKiem
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNSX = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSKQ = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboChonGia = new System.Windows.Forms.ComboBox();
            this.btnchonNSX = new System.Windows.Forms.Button();
            this.btnChontatCaGia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKQ)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Nhà sản xuất";
            // 
            // cboNSX
            // 
            this.cboNSX.FormattingEnabled = true;
            this.cboNSX.Location = new System.Drawing.Point(137, 79);
            this.cboNSX.Name = "cboNSX";
            this.cboNSX.Size = new System.Drawing.Size(121, 21);
            this.cboNSX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm theo giá";
            // 
            // dgvDSKQ
            // 
            this.dgvDSKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKQ.Location = new System.Drawing.Point(14, 19);
            this.dgvDSKQ.Name = "dgvDSKQ";
            this.dgvDSKQ.Size = new System.Drawing.Size(722, 176);
            this.dgvDSKQ.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSKQ);
            this.groupBox1.Location = new System.Drawing.Point(12, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 201);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả tìm kiếm";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(806, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "TÌM KIẾM ĐIỆN THOẠI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboChonGia
            // 
            this.cboChonGia.FormattingEnabled = true;
            this.cboChonGia.Items.AddRange(new object[] {
            "2.000.000 - 4.000.000",
            "4.000.000 - 6.000.000",
            "6.000.000 - 10.000.000",
            "10.000.000 - 30.000.000"});
            this.cboChonGia.Location = new System.Drawing.Point(137, 103);
            this.cboChonGia.Name = "cboChonGia";
            this.cboChonGia.Size = new System.Drawing.Size(121, 21);
            this.cboChonGia.TabIndex = 7;
            // 
            // btnchonNSX
            // 
            this.btnchonNSX.Location = new System.Drawing.Point(265, 77);
            this.btnchonNSX.Name = "btnchonNSX";
            this.btnchonNSX.Size = new System.Drawing.Size(101, 23);
            this.btnchonNSX.TabIndex = 8;
            this.btnchonNSX.Text = "Chọn tất cả NSX";
            this.btnchonNSX.UseVisualStyleBackColor = true;
            this.btnchonNSX.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChontatCaGia
            // 
            this.btnChontatCaGia.Location = new System.Drawing.Point(265, 106);
            this.btnChontatCaGia.Name = "btnChontatCaGia";
            this.btnChontatCaGia.Size = new System.Drawing.Size(101, 23);
            this.btnChontatCaGia.TabIndex = 8;
            this.btnChontatCaGia.Text = "Chọn tất cả giá";
            this.btnChontatCaGia.UseVisualStyleBackColor = true;
            this.btnChontatCaGia.Click += new System.EventHandler(this.btnChontatCaGia_Click);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 432);
            this.Controls.Add(this.btnChontatCaGia);
            this.Controls.Add(this.btnchonNSX);
            this.Controls.Add(this.cboChonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboNSX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKQ)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSKQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboChonGia;
        private System.Windows.Forms.Button btnchonNSX;
        private System.Windows.Forms.Button btnChontatCaGia;
    }
}