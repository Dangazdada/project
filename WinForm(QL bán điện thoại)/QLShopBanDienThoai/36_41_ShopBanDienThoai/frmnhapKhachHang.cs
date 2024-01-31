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
    public partial class frmnhapKhachHang : Form
    {
        

        cls36_41_ShopBanDienThoai c = new cls36_41_ShopBanDienThoai();
        
        int vitri = 0;
        public string makh;
        public string tenkhh;
        public string sdt;
        DataSet ds = new DataSet();
        public string sdttim = "";
        void hienThi_TextBox(DataSet ds, int vitri)
        {
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (vitri < ds.Tables[0].Rows.Count)
                {
                    txtnhapMaKH.Text = ds.Tables[0].Rows[vitri]["MaKH"].ToString();
                    txtNhapTen.Text = ds.Tables[0].Rows[vitri]["tenKH"].ToString();
                    txtNhapHo.Text = ds.Tables[0].Rows[vitri]["HoKH"].ToString();
                    txtNhapSDT.Text = ds.Tables[0].Rows[vitri]["SDT"].ToString();
                    txtNhapDChi.Text = ds.Tables[0].Rows[vitri]["DiaChi"].ToString();
                    txtNhapEmail.Text = ds.Tables[0].Rows[vitri]["Email"].ToString();
                }
                else
                {
                    txtnhapMaKH.Text = "";
                    txtNhapTen.Text = "";
                    txtNhapHo.Text  = "";
                    txtNhapSDT.Text = "";
                    txtNhapDChi.Text = "";
                    txtNhapEmail.Text = "";

                }
            }
          
        }
        int flag = 0;
        
        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        void xuLyTextBox(Boolean t)
        {
            txtnhapMaKH.ReadOnly = t;
            txtNhapHo.ReadOnly = t;
            txtNhapSDT.ReadOnly = t;
            txtNhapTen.ReadOnly = t;
            txtNhapDChi.ReadOnly = t;
            txtNhapEmail.ReadOnly = t;
        }
        void xoaTextBox()
        {
            txtnhapMaKH.Clear();
            txtNhapHo.Clear();
            txtNhapSDT.Clear();
            txtNhapDChi.Clear();
            txtNhapEmail.Clear();
            txtNhapTen.Clear();
        }
        public frmnhapKhachHang()
        {
            InitializeComponent();
            txtNhapSDT.TextChanged += new EventHandler(txtNhapSDT_TextChanged);
        }
        void danhsach_datagridview(DataGridView a,string sql)
        {
             ds = c.LayDuLieu(sql);
            a.DataSource = ds.Tables[0];
        }
        string PhatSinhMaKH()
        {
            string MaKH = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaKH = "kh00" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaKH = "kh0" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaKH;
        }
        private void frmnhapKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
                e.Cancel = true;
        }
        Boolean f = false;
        private void frmnhapKhachHang_Load(object sender, EventArgs e)
        {
            
            danhsach_datagridview(dgvDanhsach, "select * from KhachHang where TrangThai = 0");
            hienThi_TextBox(ds, vitri);
            xuLyChucNang(true);
            xuLyTextBox(true);
            f = true;
            txtsdt.Text = sdttim;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            hienThi_TextBox(ds, vitri);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xoaTextBox();
            xuLyTextBox(false);
            flag = 1;
            txtnhapMaKH.Text = PhatSinhMaKH();
            
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuLyTextBox(true);
            string makh = txtnhapMaKH.Text;
            string hokh = txtNhapHo.Text;
            string tenkh = txtNhapTen.Text;
            string sdt = txtNhapSDT.Text;
            string diachi = txtNhapDChi.Text;
            string email = txtNhapEmail.Text;
            int trangthai = cboTrangThai.SelectedIndex;
            if(flag == 1)
            {
                string sql = "insert KhachHang values('" + makh + "',N'" + hokh + "',N'" + tenkh + "','"+sdt+"',N'"+diachi+"','"+email+"',"+trangthai+")";
                if(c.capNhatDuLieu(sql)>0)
                {
                    MessageBox.Show("Thêm thành công!");
                }    

            }



        }

        private void dgvDanhsach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(f)
            if(e.ColumnIndex >=1)
            {
                int vitri = dgvDanhsach.CurrentRow.Index;
                string MaKH = dgvDanhsach.CurrentRow.Cells[0].Value.ToString();
                string HoKH = dgvDanhsach.CurrentRow.Cells[1].Value.ToString();
                string TenKH = dgvDanhsach.CurrentRow.Cells[2].Value.ToString();
                string SDT = dgvDanhsach.CurrentRow.Cells[3].Value.ToString();
                string DiaChi = dgvDanhsach.CurrentRow.Cells[4].Value.ToString();
                string Email = dgvDanhsach.CurrentRow.Cells[5].Value.ToString();
                string sql = "update KhachHang set HoKH = N'" + HoKH;
                sql += "',TenKH = N'" + TenKH + "', SDT = '" + SDT + "', DiaChi = N'" + DiaChi + "',Email = N'" + Email + "' where MaKH = '" + MaKH + "'";
                if(c.capNhatDuLieu(sql)>0)
                {
                    MessageBox.Show("Bạn đã cập nhật thành công!");
                    frmnhapKhachHang_Load(sender,e);
                }
            }    
        }

        

        private void txtNhapSDT_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhapSDT.Text, out int result) || txtNhapSDT.Text.Length > 10)
            {
                txtNhapSDT.Text = "";
            }
        }

        public void btnChon_Click(object sender, EventArgs e)
        {
            makh = txtnhapMaKH.Text;
            tenkhh = txtNhapHo.Text + " " + txtNhapTen.Text;
            sdt = txtNhapSDT.Text;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhsach, "select * from KhachHang where SDT = '"+sdttim+"'");
        }
    }
}
