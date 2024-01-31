using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_41_ShopBanDienThoai
{
   
    public partial class frmMau : Form
    {
        cls36_41_ShopBanDienThoai c = new cls36_41_ShopBanDienThoai();
        DataSet ds = new DataSet();
        int vitri = 0;
        public frmMau()
        {
            InitializeComponent();
        }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled=t;
            btnLuu.Enabled = !t;
        }
        public string phatSinhMau()//cach 1
        {
            string maMau = "";
            if (ds.Tables[0].Rows.Count < 10)
            {
                maMau = "M0" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                 maMau = "M"+(ds.Tables[0].Rows.Count + 1).ToString();
            return maMau;
        }
        /*
         cach 2
        string phatSinhMau()
        {
            string maMau = "";
            DataSet dsmau = c.LayDuLieu("SELECT MaMau from MauSac)
            if (dsmau.Tables[0].Rows.Count < 10)
            {
                maMau = "M0" + (dsmau.Tables[0].Rows.Count + 1).ToString();
            }
            else
                 maMau = "M"+(dsmau.Tables[0].Rows.Count + 1).ToString();

            return maMau;
        }
        string 
        */
        int flag = 0;
        void xoaTextBox()
        {
            txtMaMau.Clear();
            txtTenMau.Clear();
        }
        void xuLyTexBox(Boolean t)
        {
             txtTenMau.ReadOnly = t;
            txtMaMau.ReadOnly = t;
        }
        void hienThi_TextBox(DataSet ds, int vitri)
        {
            
            txtMaMau.Text = ds.Tables[0].Rows[vitri]["MaMau"].ToString();
            txtTenMau.Text = ds.Tables[0].Rows[vitri]["TenMau"].ToString();
        }
        void danhsach_datagridview(DataGridView a, string sql)
        {
             ds = c.LayDuLieu(sql);
            a.DataSource = ds.Tables[0];
        }   
        private void label7_Click(object sender, EventArgs e)
        {
            xulychucnang(true);
        }
        Boolean f = false;
        private void frmMau_Load(object sender, EventArgs e)
        {
            danhsach_datagridview(dvgDanhSach, "select * from MauSac where TrangThai = 0");
            hienThi_TextBox(ds, vitri);
            f = true;
        }

        private void dvgDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            hienThi_TextBox(ds, vitri);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulychucnang(false);
            xuLyTexBox(false);
            cboTrangThai.SelectedIndex = 0;
            txtMaMau.Text = phatSinhMau();
            flag = 1;
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulychucnang(true);
            xuLyTexBox(true);
            string sql = "";
            if (flag == 1)
            {
                sql = "insert into MauSac values('" + txtMaMau.Text + "',N'" + txtTenMau.Text + "',0)";
            }
            if(flag == 2)
            {
                sql = "update  MauSac set TenMau = N'" + txtTenMau.Text + "',TrangThai = " + cboTrangThai.SelectedIndex + " where MaMau = '"+ txtMaMau.Text +"'";
            }
            if(flag == 3)
            {
               sql = "update  MauSac set TenMau = N'" + txtTenMau.Text + "',TrangThai = 1   where MaMau = '" + txtMaMau.Text + "'";
            }
            if(c.capNhatDuLieu(sql)>0)
            {
                MessageBox.Show("Ban da cap nhat thanh cong!");
                frmMau_Load(sender, e);
            }
        }

        private void txtMaMau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            hienThi_TextBox(ds, vitri);
            xulychucnang(false);
            xuLyTexBox(false);
            flag = 2;
        }

        private void dvgDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            hienThi_TextBox(ds, vitri);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 3;
        }

        private void dvgDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(f)
            if(e.ColumnIndex == 1)
            {
                int vt = dvgDanhSach.CurrentRow.Index;
                string MaMau = dvgDanhSach.CurrentRow.Cells[0].Value.ToString();
                string TenMau = dvgDanhSach.CurrentRow.Cells[1].Value.ToString();
                string sql = sql = "update  MauSac set TenMau = N'" + TenMau + "' where MaMau = '" + MaMau + "'";
                if(c.capNhatDuLieu(sql)>0)
                {
                    MessageBox.Show("Bạn đã cập nhaakt thành công!");
                    frmMau_Load(sender,e);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
