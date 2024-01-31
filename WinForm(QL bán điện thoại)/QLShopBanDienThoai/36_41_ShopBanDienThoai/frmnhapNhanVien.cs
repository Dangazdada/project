using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_41_ShopBanDienThoai
{
    public partial class frmnhapNhanVien : Form
    {
        cls36_41_ShopBanDienThoai c = new cls36_41_ShopBanDienThoai();
        DataSet ds = new DataSet();
        public frmnhapNhanVien()
        {
            InitializeComponent();
        }
        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        void danhsach_datagridview(DataGridView a, string sql)
        {
            ds = c.LayDuLieu(sql);
            a.DataSource = ds.Tables[0];
        }
        string PhatSinhMaKH()
        {
            string MaKH = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaKH = "M0" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaKH = "M" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaKH;
        }
        private void frmnhapNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhapDChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhapSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnhapMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmnhapNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
                e.Cancel = true;
        }
    }
}
