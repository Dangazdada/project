using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;

namespace _36_41_ShopBanDienThoai
{
    public partial class HoaDonBan : Form
    {
        cls36_41_ShopBanDienThoai c = new cls36_41_ShopBanDienThoai();
        DataSet dshd = new DataSet();
        DataSet dscthd = new DataSet();
        DataSet dscthdloc = new DataSet();
        DataSet dsctsp = new DataSet();
        DataSet dsdt = new DataSet();
        DataSet dskh = new DataSet();
        DataSet dsnv = new DataSet();
        DataSet dssddtkh = new DataSet();
        DataSet dsmaudt = new DataSet();
        DataSet dsslhd = new DataSet();

        int vitri = 0;
        Boolean f = false;
        int flag = 0;
        public HoaDonBan()
        {
            InitializeComponent();
           
            txtSDT.TextAlignChanged += new EventHandler(txtSDT_TextChanged);
            txtGiaBan.TextAlignChanged += new EventHandler(txtGiaBan_TextChanged);
            txtKhuyenMai.TextAlignChanged += new EventHandler(txtKhuyenMai_TextChanged);
            txtSL.TextAlignChanged += new EventHandler(txtSL_TextChanged);
        }
        void hienThi_TextBox(DataSet ds, int vitri)
        {
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (vitri < ds.Tables[0].Rows.Count)
                {
                    txtMaHD.Text = ds.Tables[0].Rows[vitri]["MaHDBan"].ToString();
                    int giaTriTrangThai = int.Parse(ds.Tables[0].Rows[vitri]["TrangThai"].ToString());
                    string stringDatetime = ds.Tables[0].Rows[vitri]["NgLapHD"].ToString();
                    dtpNgaylap.Value = DateTime.Parse(stringDatetime);
                    txtKhuyenMai.Text = "0";

                    if (giaTriTrangThai == 0)
                    {
                        cboTrangThai.SelectedIndex = 0;
                    }
                    else
                    {
                        cboTrangThai.SelectedIndex = 1;
                    }
                    load_ctspTheoMaHDBan(ds.Tables[0].Rows[vitri]["MaHDBan"].ToString());
                    string manv = ds.Tables[0].Rows[vitri]["MaNV"].ToString();
                    locdl_theodatagridview(cboNV, dsnv, "MaNV", "TenNV", manv);
                }
                else
                {
                    txtMaHD.Text = "";
                    cboTrangThaiDonhang.SelectedIndex = -1;


                }
            }
           
           
            
            //string madt = dscthd.Tables[0].Rows[vitri]["MaDT"].ToString();
            //locdl_theodatagridview(cboTenDT, dsdt, "MaDT", "TenDT", madt);


        }
        void TaoCotHDBan()
        {
            dgvDSHD.Columns.Clear();
            dgvDSHD.DataSource = null;
            dgvDSHD.Columns.Add("MaHDBan", "Mã HD Bán");
            dgvDSHD.Columns.Add("MaKH", "Mã KH");
            dgvDSHD.Columns.Add("MaNV", "Mã NV");
            dgvDSHD.Columns.Add("NgLapHD", "Ngày lập HD");
            dgvDSHD.Columns.Add("TrangThai", "Trạng Thái");
        }
        void TaoCotCTHDBan()
        {
            dgvDSCTHD.Columns.Clear();
            dgvDSCTHD.DataSource = null;
            dgvDSCTHD.Columns.Add("MaCTHDBan", "Mã CTHD bán");
            dgvDSHD.Columns.Add("MaHDBan", "Mã HD Bán");
            dgvDSHD.Columns.Add("MaDT", "Mã điện thoại");
            dgvDSHD.Columns.Add("SoLuong", "Số lượng");
            dgvDSHD.Columns.Add("DonGia", "Đơn giá");
            dgvDSHD.Columns.Add("ChietKhau", "Chiết khấu");
            dgvDSHD.Columns.Add("MaVC", "Mã vận chuyển");
            dgvDSHD.Columns.Add("GhiChu", "Ghi chú");
            dgvDSHD.Columns.Add("Tongtien", "Thành tiền");
        }


            void load_ctspTheoMaHDBan(string mahdb)
        {
            string s = "select * from CTHoaDonBan where MaHDBan = '" + mahdb + "'";
            dscthd = c.LayDuLieu(s);
            dgvDSCTHD.DataSource = null;
            dgvDSCTHD.Columns.Clear();
            dgvDSCTHD.DataSource = dscthd.Tables[0];

        }
        
        void xulytextBox(Boolean t)
        {
            txtSDT.ReadOnly = t;
           
            txtMaHD.ReadOnly = t;
            
            txtGiaBan.ReadOnly = t;
            txtSL.ReadOnly = t;
            txtKhuyenMai.ReadOnly = t;
           
        }
        void locdl_theodatagridview(ComboBox cbo, DataSet ds, string ma, string ten, string giatrima)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = ma + "= '" + giatrima + "'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;

        }
        void XoaDulieu()
        {
            txtMaHD.Clear();
            txtSDT.Clear();
            txtGiaBan.Clear();
            txtSL.Clear();
            txtKhuyenMai.Clear();
            cboNV.SelectedIndex = -1;


        }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuuHD.Enabled = !t;
           
        }
        void danhsach_datagridview(DataGridView a, string sql)
        {
            dshd = c.LayDuLieu(sql);
            a.DataSource = dshd.Tables[0];
        }
        void hienthicombobox(DataSet ds, ComboBox cb, string ma, string ten)
        {
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
            cb.SelectedIndex = -1;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSoLuong_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            xulychucnang(true);
            danhsach_datagridview(dgvDSHD, "select * from HoaDonBan Where TrangThai = 0");
            dscthd = c.LayDuLieu("select * from CTHoaDonBan");
            dshd = c.LayDuLieu("select * from HoaDonBan where TrangThai = 0");
            dsdt = c.LayDuLieu("select * from DienThoai where Trangthai = 0");
            dskh = c.LayDuLieu("select * from KhachHang");
            dsnv = c.LayDuLieu("select * from NhanVien");
            dsmaudt = c.LayDuLieu("select * from MauSac");
            btnluucthd.Enabled = false;
            lblMaDT.Visible = false;
            lblSoluongcu.Visible = false;
            lblMamau.Visible = false;
            lblMaKH.Visible = false;


            hienThi_TextBox(dshd, vitri);
            

            //String madt = cboTenDT.SelectedValue.ToString();
            //dsmaudt = c.LayDuLieu("select a.MaMau, a.TenMau from MauSac a, CTDienThoai b  where MaDT = '" + madt + "' AND A.MaMau = B.MaMau AND b.SoLuong >0");
            //hienthicombobox(dsnv, cboNV, "MaNV", "TenNV");
            //hienthicombobox(dsmaudt, cboChonmau, "MaMau", "TenMau");
            dtpNgaylap.Value = DateTime.Today;
            f = false;

            

        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            //string sdt = txtSDT.Text;
            //dssddtkh = c.LayDuLieu("select MaKH,HoKH,TenKH from KhachHang where SDT ='" + sdt +"'");
            //if (dssddtkh.Tables[0].Rows.Count>0)
            //{
            //    string hokh = dssddtkh.Tables[0].Rows[0]["HoKH"].ToString();
            //    string tenkh = dssddtkh.Tables[0].Rows[0]["TenKH"].ToString();
            //    txtTenKH.Text = hokh+tenkh;
            //    string makh = dssddtkh.Tables[0].Rows[0]["MaKH"].ToString();
            //    lblMaKH.Text = makh;
            //}
            //else
            //{
            //    txtTenKH.Text = "Không tìm thấy!";
            //    lblMaKH.Text = "";
            //}
            frmnhapKhachHang f = new frmnhapKhachHang();
            f.sdttim = txtSDT.Text;
            if (f.ShowDialog() == DialogResult.OK)
            {
                
                txtSDT.Text = f.sdt;
                txtTenKH.Text = f.tenkhh;
                lblMaKH.Text = f.makh;
                f.sdttim = txtSDT.Text;



            }    
            


        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            hienThi_TextBox(dshd, vitri);
            lblMaKH.Text = dgvDSHD.Rows[vitri].Cells[1].Value.ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextBox(false);
            xulychucnang(false);
            XoaDulieu();
            hienthicombobox(dsnv, cboNV, "MaNV", "TenNV");
            string sql = "select MaHDBan from HoaDonBan";
            DataSet ds = c.LayDuLieu(sql);
            string MaHD;
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaHD = "HDB0" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
            {
               MaHD = "HDB" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            txtMaHD.Text = MaHD;
            txtMaHD.ReadOnly = true;
            btnThemCTHD.Enabled = true;
            btnluucthd.Enabled = true;
            flag = 1;
            f = true;

        }

        private void btnChonDT_Click(object sender, EventArgs e)
        {
            //hienthicombobox(dsdt, cboTenDT, "MaDT", "TenDT");
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            string makh = lblMaKH.Text;
            string manv = cboNV.SelectedValue.ToString();
            DateTime NglapHD = dtpNgaylap.Value;

            int trangthai = cboTrangThai.SelectedIndex;
            if (string.IsNullOrEmpty(txtSL.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin vào textbox!");
            }
            else
            {
                if (flag == 1)
                {

                    string sql = "insert HoaDonBan values( '" + mahd + "','" + makh + "','" + manv;
                    sql += "','" + (@NglapHD) + "',";
                    sql += +trangthai + ") ";
                    if (c.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("thêm thành công!");
                        string mactdt = txtMactdt.Text;
                        dsctsp = c.LayDuLieu("select *from CTDienThoai where MaCTDT = '" + mactdt + "'");
                        string madt = dsctsp.Tables[0].Rows[0]["MaDT"].ToString();
                        string mamau = dsctsp.Tables[0].Rows[0]["MaMau"].ToString();
                        string macthd = mahd + "-" + madt;
                        int sl = int.Parse(txtSL.Text);
                        int donGia = int.Parse(txtGiaBan.Text);
                        float Ck = float.Parse(txtKhuyenMai.Text);
                        string mavd = txtMaVD.Text;
                        string donvivc = txtDonViVC.Text;
                        int tongtien = sl * donGia - (int)(sl * donGia * Ck);
                        int trangthaidonhang = cboTrangThaiDonhang.SelectedIndex;
                        string sqlcthd;
                        if (mavd == "" || donvivc == "")
                        {
                            sqlcthd = "insert CTHoaDonBan values('" + macthd + "','" + mahd + "','" + madt + "','" + mamau + "'," + sl + "," + donGia + ",";
                            sqlcthd += Ck + ",'null','null',1," + tongtien + ")";
                        }
                        else
                        {
                            sqlcthd = "insert CTHoaDonBan values('" + macthd + "','" + mahd + "','" + madt + "','" + mamau + "'," + sl + "," + donGia + ",";
                            sqlcthd += Ck + ",'" + mavd + "','" + donvivc + "'," + trangthaidonhang + "," + tongtien + ")";
                        }
                        string sqlkt = "SELECT COUNT(*) FROM CTHoaDonBan WHERE MaCTHoaDonBan = '" + macthd + "'";
                        int count = Convert.ToInt32(c.LayDuLieu(sqlkt).Tables[0].Rows[0][0]);
                        if (count > 0)
                        {
                            MessageBox.Show("Chi tiết hóa đơn đã tồn tại!");
                        }
                        else
                        {
                            if (c.capNhatDuLieu(sqlcthd) > 0)
                            {
                                MessageBox.Show("Đã lưu thành công chi tiết hóa đơn bán!");
                                if (trangthaidonhang == 2)
                                {
                                    string sqlsua = "update CTDienThoai set SoLuong -=" + sl + " where MaCTDT ='" + mactdt + "'";
                                    c.capNhatDuLieu(sqlsua);
                                }
                                else
                                {
                                    string sqlsua = "update CTDienThoai set SoLuong +=" + sl + " where MaCTDT ='" + mactdt + "'";
                                    c.capNhatDuLieu(sqlsua);
                                }
                            }
                        }
                    }

                }
            }
          
            if(flag == 2)
            {
                string sql = "update HoaDonBan set MaKH ='"+makh+"',MaNV = '"+manv+"', NgLapHD = '"+ NglapHD+ "' where MaHDBan = '"+mahd+"'";
                if (c.capNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");

                }
            }
            if (flag == 3)
            {
                string sql = "update HoaDonBan set TrangThai = 1 where MaHDBan = '" +mahd +"'";
                DialogResult dlxoahd;
                dlxoahd = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không?","thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dlxoahd == DialogResult.Yes)
                {
                    if (c.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Xóa hóa đơn thành công!");
                    }
                }    
                
            }
            HoaDonNhap_Load(sender, e);


        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(txtSL.Text);
            int donGia = int.Parse(txtGiaBan.Text);
            float Ck = float.Parse(txtKhuyenMai.Text);
            int tongtien = ((sl * donGia) - (int)(sl * donGia*Ck));
            lblTongTien.Text = tongtien.ToString();
        }

        private void cboTenDT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboChonmau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 2;
            xulytextBox(false);
            xulychucnang(false);
            btnThemCTHD.Enabled = true;
            btnluucthd.Enabled = true;
            btnluucthd.Enabled = true;
            btnThemCTHD.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 3;
            xulytextBox(false);
            xulychucnang(false);
            btnluucthd.Enabled = true;
            btnThemCTHD.Enabled = false;
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSDT.Text, out int result) || txtSDT.Text.Length > 10)
            {
                txtSDT.Text = "";

            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGiaBan.Text, out int result) || result <= 0)
            {
                txtGiaBan.Text = "";

            }
        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtKhuyenMai.Text, out double value))
            {
                if ((value < 0 || value > 1))
                {
                    txtKhuyenMai.Text = "0";
                }
            }
            else
            {
                txtKhuyenMai.Text = "0";
            }
  

            
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSL.Text, out int result) || result <0 )
            {
                txtSL.Text = "";

            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            TaoCotHDBan();
            DateTime NglapHD = dtpNgaylap.Value;
            object[] d = new object[6];
            d[0] = txtMaHD.Text;
            d[1] = lblMaKH.Text;
            d[2] = cboNV.SelectedValue.ToString();
            d[3] = "DT01"; //cboTenDT.SelectedValue.ToString();
            d[4] = NglapHD;
            d[5] = cboTrangThai.SelectedIndex;
            dgvDSHD.Rows.Add(d);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnluucthd_Click(object sender, EventArgs e)
        {
            string mavd = txtMaVD.Text;
            string donvivc = txtDonViVC.Text;
            int donGia = int.Parse(txtGiaBan.Text);
            int trangthaidonhang = cboTrangThaiDonhang.SelectedIndex;
            float Ck = float.Parse(txtKhuyenMai.Text);
            if (string.IsNullOrEmpty(txtSL.Text))
{
                MessageBox.Show("Vui lòng nhập thông tin vào textbox!");
            }
            else
            {
                if (flag == 4 || flag == 1)
                {
                    string mahd = txtMaHD.Text;
                    string mactdt = txtMactdt.Text;
                    dsctsp = c.LayDuLieu("select *from CTDienThoai where MaCTDT = '" + mactdt + "'");
                    string madt = dsctsp.Tables[0].Rows[0]["MaDT"].ToString();
                    string mamau = dsctsp.Tables[0].Rows[0]["MaMau"].ToString();
                    int soluonghienco = int.Parse(dsctsp.Tables[0].Rows[0]["SoLuong"].ToString());
                    int sl = int.Parse(txtSL.Text);
                    
                    string macthd = mahd + "-" + madt;
                    
                    int tongtien = sl * donGia - (int)(sl * donGia * Ck);
                    if (soluonghienco < sl)
                    {
                        MessageBox.Show("Số lượng điện thoại còn hiện tại không đủ!");

                    }
                    else
                    {
                        string sqlcthd;
                        if (mavd == "" || donvivc == "")
                        {
                            sqlcthd = "insert CTHoaDonBan values('" + macthd + "','" + mahd + "','" + madt + "','" + mamau + "'," + sl + "," + donGia + ",";
                            sqlcthd += Ck + ",'null','null',1," + tongtien + ")";
                        }
                        else
                        {
                            sqlcthd = "insert CTHoaDonBan values('" + macthd + "','" + mahd + "','" + madt + "','" + mamau + "'," + sl + "," + donGia + ",";
                            sqlcthd += Ck + ",'" + mavd + "','" + donvivc + "'," + trangthaidonhang + "," + tongtien + ")";
                        }
                        string sql = "SELECT COUNT(*) FROM CTHoaDonBan WHERE MaCTHoaDonBan = '" + macthd + "'";
                        int count = Convert.ToInt32(c.LayDuLieu(sql).Tables[0].Rows[0][0]);
                        if (count > 0)
                        {
                            MessageBox.Show("Chi tiết hóa đơn đã tồn tại!");
                        }
                        else
                        {
                            if (c.capNhatDuLieu(sqlcthd) > 0)
                            {
                                MessageBox.Show("Đã lưu thành công chi tiết hóa đơn bán!");
                                if (trangthaidonhang == 2)
                                {
                                    string sqlsua = "update CTDienThoai set SoLuong -=" + sl + " where MaCTDT ='" + mactdt + "'";
                                    c.capNhatDuLieu(sqlsua);
                                }
                                else
                                {
                                    string sqlsua = "update CTDienThoai set SoLuong +=" + sl + " where MaCTDT ='" + mactdt + "'";
                                    c.capNhatDuLieu(sqlsua);
                                }
                            }
                        }
                    }
                    
                }
                if(flag ==2)
                {
                    string mahd = txtMaHD.Text;
                    string madt = lblMaDT.Text;
                    string macthd = mahd + "-" + madt;
                    int slsphdcu = int.Parse(lblSoluongcu.Text);
                    int sl = int.Parse(txtSL.Text);
                    int soluongmoi = sl - slsphdcu;
                    int tongtien = sl * donGia - (int)(sl * donGia * Ck);

                    string sql = "update CTHoaDonBan set SoLuong ="+sl+" ,DonGia ="+donGia+" ,ChietKhau ="+Ck+" ,MaVC = '"+mavd+"', DonViVanChuyen = N'"+donvivc;
                        sql+= "',TrangThaiDonHang  ="+trangthaidonhang+", TongTien ="+tongtien+"   WHERE  MaCTHoaDonBan = '"+macthd+"'";
                    if(c.capNhatDuLieu(sql)>0)
                    {
                        MessageBox.Show("Bạn đã cập nhật chi tiết hóa đơn thành công!");
                        if(soluongmoi !=0)
                        {
                            string sqlsuasdt = "update DienThoai set SoLuong +="+soluongmoi+" where MaDT = '"+madt+"'";
                            string sqlsua = "update CTDienThoai set SoLuong +=" + soluongmoi + " where MaDT = '"+madt+"' and MaMau = ''";
                            c.capNhatDuLieu(sqlsua);
                        }    
                    }    
                }
                if(flag == 3)
                {
                    string mahd = txtMaHD.Text;
                    string madt = lblMaDT.Text;
                    string macthd = mahd + "-" + madt;
                    DialogResult dlxoacthd;
                    string sql = "delete CTHoaDonBan where MaCTHoaDonBan = '"+macthd+"'";
                    dlxoacthd = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlxoacthd == DialogResult.Yes)
                    {
                        if (c.capNhatDuLieu(sql) > 0)
                        {
                            MessageBox.Show("Đã xóa thành công!");

                        }
                    }
                }    
            }
            btnThemCTHD.Enabled = true;
            HoaDonNhap_Load(sender, e);
            
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            btnluucthd.Enabled = true;
            btnThemCTHD.Enabled = false;
            flag = 4;
        }

        private void btnThemthongtinsp_Click(object sender, EventArgs e)
        {
            string mactsp = txtMactdt.Text;
            dsctsp = c.LayDuLieu("select * from CTDienThoai where MaCTDT ='" + mactsp + "'");
            string madt = dsctsp.Tables[0].Rows[0]["MaDT"].ToString();
            dsdt = c.LayDuLieu("select * from DienThoai where MaDT ='" + madt + "'");
            if (dsctsp.Tables[0].Rows.Count > 0)
            {
                txttensp.Text = dsdt.Tables[0].Rows[0]["TenDT"].ToString();
                txtGiaBan.Text = dsdt.Tables[0].Rows[0]["Giabanle"].ToString();
                string tenHinh = dsctsp.Tables[0].Rows[0]["Hinh"].ToString();
                string filename = Path.GetFullPath("Danhsachsanpham") + @"\" + tenHinh;
                Bitmap a = new Bitmap(filename);
                picHinhsp.Image = a;
                picHinhsp.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            txtMactdt.Enabled = false;
            txttensp.Enabled = false;
            txtGiaBan.Enabled = false;
        }

        private void dgvDSCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            txtSL.Text = dgvDSCTHD.Rows[vitri].Cells[4].Value.ToString();
            lblSoluongcu.Text = dgvDSCTHD.Rows[vitri].Cells[4].Value.ToString();
            txtGiaBan.Text = dgvDSCTHD.Rows[vitri].Cells[5].Value.ToString();
            txtKhuyenMai.Text = dgvDSCTHD.Rows[vitri].Cells[6].Value.ToString();
            lblMaDT.Text = dgvDSCTHD.Rows[vitri].Cells[2].Value.ToString();
            lblMamau.Text = dgvDSCTHD.Rows[vitri].Cells[3].Value.ToString();
            txtDonViVC.Text = dgvDSCTHD.Rows[vitri].Cells[8].Value.ToString(); 
            txtMaVD.Text = dgvDSCTHD.Rows[vitri].Cells[7].Value.ToString();

        }
    }
}
