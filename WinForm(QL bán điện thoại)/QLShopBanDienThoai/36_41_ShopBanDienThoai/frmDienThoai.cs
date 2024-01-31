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
    public partial class frmDienThoai : Form
    {
        DataSet dsNhaSX = new DataSet();
        DataSet dsLoaiDT = new DataSet();
        DataSet dsDienThoai = new DataSet();
        cls36_41_ShopBanDienThoai c = new cls36_41_ShopBanDienThoai();
        int flag = 0;
        Boolean f = false;
        int vitri = 0;
        public frmDienThoai()
        {
            InitializeComponent();
        }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        void xuLyTexBox(Boolean t)
        {
            txtMaDT.ReadOnly = t;
            txtTenDT.ReadOnly = t;
            txtMaNSX.ReadOnly = t;
        }
        void hienThi_TextBox(DataSet ds, int vitri)
        {

            txtMaDT.Text = ds.Tables[0].Rows[vitri]["MaDT"].ToString();
            txtTenDT.Text = ds.Tables[0].Rows[vitri]["TenDT"].ToString();
            //txtMaNSX.Text = ds.Tables[0].Rows[vitri]["MaNSX"].ToString();
            locDuLieuComBoBox(dsLoaiDT, cobLoaiDT, "TenDT", "MaDT", ds.Tables[0].Rows[vitri]["MaNSX"].ToString());

        }
        void danhsach_datagridview(DataGridView a,string sql)
        {
            dsDienThoai = c.LayDuLieu(sql);
            a.DataSource = dsDienThoai.Tables[0];
        }
        void HienThiComBoBox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }
        void locDuLieuComBoBox(DataSet ds, ComboBox cbo,string ten, string ma, string giatrima)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = ma + "= '" + giatrima + "'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }

        private void frmDienThoai_Load(object sender, EventArgs e)
        {
            dsLoaiDT = c.LayDuLieu("select * from LoaiDT");
            HienThiComBoBox(cobLoaiDT, dsLoaiDT, "TenDT", "MaLoaiDT");
            danhsach_datagridview(dgvDanhsach, "select MaDT,TenDT,MaNSX from DienThoai");
            f = true;

        }
           
        private void cobLoaiDT_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if(f)
                if(cobLoaiDT.SelectedIndex != -1)
                {
                    string maloai = cobLoaiDT.SelectedValue.ToString();//lấy giá trị trong combobox 
                    danhsach_datagridview(dgvDanhsach, "select MaDT,TenDT,MaNSX from DienThoai where MaLoaiDT = '" + maloai + "'");
                }    
        }

        private void dgvDanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmDienThoai_Load(sender, e);
        }

        private void dgvDanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            hienThi_TextBox(dsDienThoai, vitri);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
