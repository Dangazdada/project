using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;

namespace _36_41_ShopBanDienThoai
{
    public partial class frmSanpham : Form
    {
        cls36_41_ShopBanDienThoai c = new cls36_41_ShopBanDienThoai();
        DataSet dsdt = new DataSet();
        DataSet dsnsx = new DataSet();
        DataSet dsctsp = new DataSet();
        DataSet dsbh = new DataSet();
        DataSet dsmau = new DataSet();

        int vitri = 0;
        Boolean f = false;
        int flag = 0;
        void hienThi_TextBox(DataSet ds, int vitri)
        {
            if(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count >0)
            {
                if(vitri < ds.Tables[0].Rows.Count)
                {
                    txtMaDT.Text = ds.Tables[0].Rows[vitri]["MaDT"].ToString();
                    txtTenDT.Text = ds.Tables[0].Rows[vitri]["TenDT"].ToString();
                    txtGiaNhap.Text = ds.Tables[0].Rows[vitri]["GiaNhap"].ToString();
                    txtGiaBan.Text = ds.Tables[0].Rows[vitri]["GiaBanLe"].ToString();
                    txtSoLuong.Text = ds.Tables[0].Rows[vitri]["SoLuong"].ToString();
                    int giaTriTrangThai = int.Parse(ds.Tables[0].Rows[vitri]["TrangThai"].ToString());
                    if (giaTriTrangThai == 0)
                    {
                        cboTrangThai.SelectedIndex = 0;
                    }
                    else
                    {
                        cboTrangThai.SelectedIndex = 1;
                    }

                    string tenHinh = ds.Tables[0].Rows[vitri]["Hinh"].ToString();
                    lbltenHinh.Text = tenHinh;

                    string filename = Path.GetFullPath("Danhsachsanpham") + @"\" + tenHinh;
                    string mansx;
                    mansx = ds.Tables[0].Rows[vitri]["MaNSX"].ToString();
                    locdl_theodatagridview(cboTenNSX, dsnsx, "MaNSX", "TenNhaSX", mansx);// lọc dữ liệu mã NSX theo dgv
                    taoanh_tufileLen(picHinhSP, filename);
                    load_ctspTheoMaSp(ds.Tables[0].Rows[vitri]["MaDT"].ToString());
                }  
                else
                {
                    txtMaDT.Text = "";
                    txtTenDT.Text = "";
                    txtGiaNhap.Text = "";
                    txtGiaBan.Text = "";
                    cboTrangThai.SelectedIndex = -1;

                }    
            } 
            else
            {
                txtMaDT.Text = "";
                txtTenDT.Text = "";
                txtGiaNhap.Text = "";
                txtGiaBan.Text = "";
                cboTrangThai.SelectedIndex = -1;

            }



            //load_ctspTheoMaSp(ds.Tables[0].Rows[vitri]["MaDT"].ToString());


        }
        void XoaDulieu()
        {
            txtMaDT.Clear();
            txtTenDT.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            picHinhSP.Image = null;
            cboTenNSX.SelectedIndex = -1;


        }
        void load_ctspTheoMaSp(string masp)
        {
            string s = "select * from CTDienThoai where MaDT = '" + masp + "'";
            dsctsp = c.LayDuLieu(s);
            dgvDSCTSP.DataSource = null;
            dgvDSCTSP.Columns.Clear();
            dgvDSCTSP.DataSource = dsctsp.Tables[0];
            
        }
        void xulytextBox(Boolean t)
        {
            txtMaDT.ReadOnly = t;
            txtTenDT.ReadOnly = t;
            txtGiaBan.ReadOnly = t;
            txtGiaBan.ReadOnly = t;

            txtSoLuong.ReadOnly = !t;
        }
        public frmSanpham()
        {
            InitializeComponent();
            txtSLTheoMau.TextChanged += new EventHandler(txtSLTheoMau_TextChanged);//  Khởi tạo textchanged

            txtGiaNhap.TextChanged += new EventHandler(txtGiaNhap_TextChanged);
            txtGiaBan.TextChanged += new EventHandler(txtGiaBan_TextChanged);
            txtSoLuong.TextChanged += new EventHandler(txtSoLuong_TextChanged);
        }
        

       //void xoaTextBox(Boolean t)
       // {
       //     txtGiaBan.Enabled = t;
       //     txtMaDT.Enabled = t;
       //     txtTenDT.Enabled = t;
       //     txtGiaLech.Enabled = t;
       //     txtGiaNhap.Enabled = t;
       //     txtSLTheoMau.Enabled = t;
       // }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        void TaoCotCTDienThoai()
        {
            dgvDSCTSP.Columns.Clear();
            dgvDSCTSP.DataSource = null;
            dgvDSCTSP.Columns.Add("MaCTDT", "Mã CTDT");
            dgvDSCTSP.Columns.Add("MaDT", "Mã DT");
            dgvDSCTSP.Columns.Add("MaBH", "Mã BH");
            dgvDSCTSP.Columns.Add("MaMau", "Mã màu");
            dgvDSCTSP.Columns.Add("DungLuong", "Dung lượng");
            dgvDSCTSP.Columns.Add("GiaBan", "Gía bán");
            dgvDSCTSP.Columns.Add("SoLuong", "Số lượng");
            dgvDSCTSP.Columns.Add("Hinh", "MÃ HÌNH");

        }
        void TaoCotDienThoai()
        {
            dgvDSSP.Columns.Clear();
            dgvDSSP.DataSource = null;
            dgvDSSP.Columns.Add("MaDT", "Mã DT");
            dgvDSSP.Columns.Add("TenDT", "Tên DT");
            dgvDSSP.Columns.Add("MaNSX", "Mã NSX");
            dgvDSSP.Columns.Add("GiaNhap", "Gía nhập");
            dgvDSSP.Columns.Add("Giabanle", "Gía bán lẻ");
            dgvDSSP.Columns.Add("Hinh", "Hình");
            dgvDSSP.Columns.Add("TrangThai", "TrangThai");
        }
        void danhsach_datagridview(DataGridView a, string sql)
        {
            dsdt = c.LayDuLieu(sql);
            a.DataSource = dsdt.Tables[0];
        }
        void hienthicombobox(DataSet ds, ComboBox cb, string ma, string ten)
        {
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
            cb.SelectedIndex = -1;
        }
        void locdl_theodatagridview(ComboBox cbo, DataSet ds , string  ma , string  ten, string giatrima)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = ma + "= '" + giatrima + "'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;

        }
        //void ThongtinThamso(DataSet ds, ref ArrayList ten)
        //{
        //    for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
        //    {
        //        ten.Add("@" + ds.Tables[0].Columns[i].ColumnName.ToString());
        //    }
        //}
        void taoanh_tufileLen(PictureBox p, string filename)
        {
            Bitmap a = new Bitmap(filename);
            p.Image = a;
            p.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        void load_CTSPTheoMaSP(string masp)
        {
            string s = "select * from CTDienThoai where MaDT = '"+masp+"'";
            dsctsp = c.LayDuLieu(s);
            dgvDSCTSP.DataSource = null;
            dgvDSCTSP.Columns.Clear();
            dgvDSCTSP.DataSource = dsctsp.Tables[0];
        }
        private void frmSanpham_Load(object sender, EventArgs e)
        {
            dgvDSSP.Columns.Clear();
            dgvDSSP.DataSource = null;
            xulytextBox(true);
            lbltenHinh.Visible = true;
            danhsach_datagridview(dgvDSSP, "select * from DienThoai where TrangThai = 0");
            dsnsx = c.LayDuLieu("select * from NhaSanXuat");
            dsdt = c.LayDuLieu("select * from DienThoai");
            dsctsp = c.LayDuLieu("select * from CTDienThoai");
            dsbh = c.LayDuLieu("select * from BaoHanh");
            dsmau = c.LayDuLieu("select * from MauSac");
            
            
            hienthicombobox(dsnsx, cboTenNSX, "MaNSX", "TenNhaSX");
            hienthicombobox(dsbh,cboMaBH, "MaBH","TenBH");
            //hienthicombobox(dsmau,cboMau,"MaMau","TenMau");
            hienThi_TextBox(dsdt, vitri);

            btnDoiNSX.Visible = false;
            lblmactsp.Visible = false;
            lblHinhctsp.Visible = false;
            lblSLdtCu.Visible = false;
            lbltenHinh.Visible = false;
            txtGiaBan.Enabled = false;
            f = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulychucnang(false);
            xulytextBox(false);
            hienThi_TextBox(dsdt, vitri);
            btnDoiNSX.Visible = true;
            lblNSX.Visible = false;
            txtMaDT.ReadOnly = true;
            f = false;

            flag = 2;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TaoCotDienThoai();
            XoaDulieu();
            hienthicombobox(dsnsx, cboTenNSX, "MaNSX", "TenNhaSX");
            TaoCotDienThoai();
            xulychucnang(false);
            xulytextBox(false);
            f = true;
            flag = 1;

            TaoCotCTDienThoai();
           // dgvDSCTSP.Rows.Add();
        }


        private void cboTenNSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(f)
            {
               if(cboTenNSX.SelectedIndex!= -1)
                {
                    string mansx = cboTenNSX.SelectedValue.ToString();
                    string sql = "select MaDT from DienThoai";
                    DataSet ds = c.LayDuLieu(sql);
                    string MaDT;
                    if (ds.Tables[0].Rows.Count < 9)
                    {
                        MaDT =   "DT0" + (ds.Tables[0].Rows.Count + 2).ToString();
                    }
                    else
                    {
                        MaDT = "DT" + (ds.Tables[0].Rows.Count + 2).ToString();
                    }
                    txtMaDT.Text = MaDT;
                }
            }
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGiaNhap.Text, out int result) || result <=0)
            {
                txtGiaNhap.Text = "";
                
            }
        }

        private void txtGiaNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                float giaNhap = int.Parse(txtGiaNhap.Text);
                txtGiaBan.Text = (giaNhap * 2.5).ToString();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            hienThi_TextBox(dsdt, vitri);
        }
        ArrayList s = new ArrayList();
        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private void flpMau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDSCTSP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (f)
            {
                if (flag == 1)
                {
                    if(e.ColumnIndex == 6)
                    {
                        int tongsl = 0;
                        for (int i = 0; i < dgvDSCTSP.Rows.Count - 1; i++)
                        {
                            tongsl += int.Parse(dgvDSCTSP.Rows[i].Cells[6].Value.ToString());
                        }
                        txtSoLuong.Text = tongsl.ToString();
                    }
  
                   
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaDT = txtMaDT.Text;
            string TenDT = txtTenDT.Text;
            string NSX = cboTenNSX.SelectedValue.ToString();
            int soluong = int.Parse(txtSoLuong.Text);
            int giaNhap = int.Parse(txtGiaNhap.Text);
            int giaBan = giaNhap * 2;
            
            string mahinh = lbltenHinh.Text;
            
            int trangthai = cboTrangThai.SelectedIndex;
            int sl = int.Parse(txtSoLuong.Text);
            
            if (flag == 1)
            {
                //them sp
                


                string sqlDienThoai = "insert DienThoai values ('" + MaDT + "',N'" + TenDT + "','" + NSX + "'," + giaNhap + ","+giaBan+","+sl+",'"+mahinh+"',"+trangthai+" )";

                if(c.capNhatDuLieu(sqlDienThoai) >0)
                {
                    MessageBox.Show("Cap nhatj thanh cong!");
                    for (int i = 0; i < dgvDSCTSP.Rows.Count - 1; i++)
                    {

                        string mactsp = dgvDSCTSP.Rows[i].Cells[0].Value.ToString();
                        string madt = dgvDSCTSP.Rows[i].Cells[1].Value.ToString();
                        string mabh = dgvDSCTSP.Rows[i].Cells[2].Value.ToString();
                        string mamau = dgvDSCTSP.Rows[i].Cells[3].Value.ToString();
                        string DL = dgvDSCTSP.Rows[i].Cells[4].Value.ToString();
                        int dungluong = int.Parse(DL);
                        string GBan = dgvDSCTSP.Rows[i].Cells[5].Value.ToString();
                        int giaban = int.Parse(GBan);
                        string SL = dgvDSCTSP.Rows[i].Cells[6].Value.ToString();
                        int sl_1 = int.Parse(SL);
                        string hinh = dgvDSCTSP.Rows[i].Cells[7].Value.ToString();

                        //them ctdt
                        string sqlCTDT = "insert into CTDienThoai values('" + mactsp + "','" + madt + "','" + mabh + "','" + mamau + "','" + dungluong + "','";
                        sqlCTDT += giaban + "','" + sl_1 + "','" + hinh + "')";
                        if (c.capNhatDuLieu(sqlCTDT) > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                        }
                    }
                }

            }
            if(flag == 2)
            {
                
                string sqlDienThoai = "update DienThoai set  TenDT = N'"+ TenDT+ "',MaNSX ='" + NSX+"',GiaNhap ="+giaNhap+" ,Giabanle ="+giaBan+" ,SoLuong = "+soluong+",Hinh ='"+ mahinh +"',TrangThai ="+ trangthai +" where MaDT = '"+MaDT +"'";
                if(c.capNhatDuLieu(sqlDienThoai) >0)
                {
                    MessageBox.Show("Bạn đã cập nhật thành công!");
                    string mabh = cboMaBH.SelectedValue.ToString();
                    string mamau = cboMau.SelectedValue.ToString();
                    int giaban = int.Parse(txtGiaBan.Text);
                    int dungluong = int.Parse(txtDungLuong.Text);
                    int soluongctdt = int.Parse(txtSLTheoMau.Text);
                    int slcu = int.Parse(lblSLdtCu.Text);
                    int sldtcapnhat = soluongctdt - slcu;
                    string hinh = lbltenHinh.Text;
                    string mactsp_sua = lblmactsp.Text; 
                    
                    string sqlsuactsp = "update CTDienThoai set MaBH ='" + mabh + "', MaMau = '";
                    sqlsuactsp+= mamau+"',DungLuongBoNho ="+dungluong+" , SoLuong ="+soluongctdt+",Hinh = '"+hinh+"' where MaCTDT = '"+mactsp_sua+"'";
                    if(c.capNhatDuLieu(sqlsuactsp)>0)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công!");
                        string sqlsuasldt = "update DienThoai set SoLuong += "+sldtcapnhat+ "where MaDT = '"+MaDT +"'";
                        c.capNhatDuLieu(sqlsuasldt);
                        string sqlsuagiaCTSP = "update CTDienThoai set GiaBan =" + giaBan + " where MaDT = '" + MaDT + "'";
                        c.capNhatDuLieu(sqlsuagiaCTSP);
                    }

                }    
            }    
            if(flag == 3)
            {
                string sql = "update DienThoai set TrangThai = 1 where MaDT = '" +MaDT +"'";
                DialogResult dlxoahd;
                dlxoahd = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dlxoahd == DialogResult.Yes)
                {
                    if (c.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Đã xóa thành công!");

                    }
                }    
                  
            }
            frmSanpham_Load(sender, e);
            xulychucnang(true);
            flag = 0;   
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtTenDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSLTheoMau_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSLTheoMau.Text, out int result) || result <= 0)
            {
                txtSLTheoMau.Text = "";
            }
        }

        private void txtGiaLech_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGiaBan.Text, out int result) || result <= 0)
            {
                txtGiaBan.Text = "";
            }
        }

        private void btnLoadHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = Path.GetFileName("Danhsachsanpham") + @"/";
            o.ShowDialog();
            string fileName = o.FileName;
            string[] tenHinh = fileName.Split('\\');
            lbltenHinh.Text = tenHinh[9];
            Bitmap a = new Bitmap(fileName);
            picHinhSP.Image = a;
            picHinhSP.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnThemMau_Click(object sender, EventArgs e)
        {
            frmMauHienThi f = new frmMauHienThi();
            if (f.ShowDialog() == DialogResult.OK)
            {
                flpMau.Controls.Clear();
                foreach (CheckBox chk in f.dschonmau)
                {
                    flpMau.Controls.Add(chk);
                }
            }
            flpMau.Enabled = false;
        }

        private void btnThemCTSP_Click_1(object sender, EventArgs e)
        {
            TaoCotDienThoai();
            object[] d = new object[8];
            int giaTheoBanMau = int.Parse(txtGiaBan.Text);
            int tongSoLuong = 0;

            foreach (CheckBox chk in flpMau.Controls)
            {
                d[0] = txtMaDT.Text + "." + cboMaBH.SelectedValue.ToString() + "." + chk.Name;
                d[1] = txtMaDT.Text;
                d[2] = cboMaBH.SelectedValue.ToString();
                d[3] = chk.Name;
                d[4] = txtDungLuong.Text;
                d[5] = txtGiaBan.Text;
                d[6] = txtSLTheoMau.Text;
                d[7] = lbltenHinh.Text;
                tongSoLuong += int.Parse(txtSLTheoMau.Text);
                txtSoLuong.Text = tongSoLuong.ToString();
                dgvDSCTSP.Rows.Add(d);

            }
        }

        private void txtMaBH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                int tongsl = 0;
                for (int i = 0; i < dgvDSCTSP.Rows.Count - 1; i++)
                {
                    string SL = dgvDSCTSP.Rows[i].Cells[6].Value.ToString();
                    int soluong = int.Parse(SL);
                    tongsl += soluong;

                }
                txtSoLuong.Text = tongsl.ToString();
                object[] dt = new object[7];
                dt[0] = txtMaDT.Text;
                dt[1] = txtTenDT.Text;
                dt[2] = cboTenNSX.SelectedValue.ToString();
                dt[3] = txtGiaNhap.Text;
                dt[4] = txtGiaBan.Text;
                dt[5] = lbltenHinh.Text;
                dt[6] = cboTrangThai.SelectedIndex;
                dgvDSSP.Rows.Add(dt);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "chú ý",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

        }

        private void dgvDSCTSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSCTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            txtSLTheoMau.Text = dgvDSCTSP.Rows[vitri].Cells[6].Value.ToString();
            txtDungLuong.Text = dgvDSCTSP.Rows[vitri].Cells[4].Value.ToString();
            txtGiaBan.Text = dgvDSCTSP.Rows[vitri].Cells[5].Value.ToString();
            string mamau = dgvDSCTSP.Rows[vitri].Cells[3].Value.ToString();
            string mabh = dgvDSCTSP.Rows[vitri].Cells[2].Value.ToString();
            lblmactsp.Text = dgvDSCTSP.Rows[vitri].Cells[0].Value.ToString();
            locdl_theodatagridview(cboMau, dsmau, "MaMau", "TenMau", mamau);
            locdl_theodatagridview(cboMaBH, dsbh, "MaBH", "TenBH", mabh);
            string tenhinh = dgvDSCTSP.Rows[vitri].Cells[7].Value.ToString();
            lblHinhctsp.Text = dgvDSCTSP.Rows[vitri].Cells[7].Value.ToString();
            string filename = Path.GetFullPath("Danhsachsanpham") + @"\" + tenhinh;
            taoanh_tufileLen(picHinhCTSP, filename);
            lblSLdtCu.Text = dgvDSCTSP.Rows[vitri].Cells[6].Value.ToString();




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiNSX_Click(object sender, EventArgs e)
        {
            hienthicombobox(dsnsx, cboTenNSX, "MaNSX", "TenNhaSX");
        }

        private void dgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 3;
            xulychucnang(false);
            xulytextBox(false);
        }

        private void txtMaDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoLuong.Text, out int result) || result <= 0)
            {
                txtSoLuong.Text = "";

            }
        }

        private void frmSanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlthoat;
            //dlthoat = MessageBox.Show("Bạn")
        }

        private void btnhinhctsp_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = Path.GetFileName("Danhsachsanpham") + @"/";
            o.ShowDialog();
            string fileName = o.FileName;
            string[] tenHinh = fileName.Split('\\');
            lblHinhctsp.Text = tenHinh[9];
            Bitmap a = new Bitmap(fileName);
            picHinhCTSP.Image = a;
            picHinhCTSP.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblSLdtCu_Click(object sender, EventArgs e)
        {

        }
    }
}
