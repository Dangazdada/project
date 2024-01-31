using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_41_ShopBanDienThoai
{
    public partial class timKiemDonhang : Form
    {
        cls36_41_ShopBanDienThoai c = new cls36_41_ShopBanDienThoai();
        DataSet dshd = new DataSet();
        DataSet dscthd = new DataSet();
        string sql;
        public timKiemDonhang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXemHDtheoMa_Click(object sender, EventArgs e)
        {
            string mahd = txtMahd.Text;
            sql = "select a.MaHDBan ,b.NgLapHD,SUM(a.TongTien)  from CTHoaDonBan a, HoaDonBan b where a.MaHDBan = b.MaHDBan ";
            sql += "group by a.MaHDBan ,b.NgLapHD having a.MaHDBan = '" + mahd + "'";
            
        }

        private void btnXemDTtheoThang_Click(object sender, EventArgs e)
        {
            int thang = dtpNgay.Value.Month;
            int nam = dtpNgay.Value.Year;
            sql = "select a.MaHDBan ,b.NgLapHD,SUM(a.TongTien)  from CTHoaDonBan a, HoaDonBan b where a.MaHDBan = b.MaHDBan ";
            sql += "group by a.MaHDBan ,b.NgLapHD having MONTH(NgLapHD) = "+thang+" and YEAR(NgLapHD) ="+ nam+"";
            
        }

        private void btnXemDTtheoNam_Click(object sender, EventArgs e)
        {
            int nam = dtpNgay.Value.Year;
            sql = "select YEAR(NgLapHD),SUM(a.TongTien) as Tongdoanhthu  from CTHoaDonBan a, HoaDonBan b where a.MaHDBan = b.MaHDBan ";
            sql += "group by YEAR(NgLapHD),b.NgLapHD having YEAR(NgLapHD) =" + nam + "";
            
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            dscthd = c.LayDuLieu(sql);
            dgvDSKQ.DataSource = dscthd.Tables[0];
        }

        private void btnTop5Mua_Click(object sender, EventArgs e)
        {
            sql = "select top 5 b.MaKH,c.HoKH, c.TenKH, sum(TongTien) as tongtienmua from CTHoaDonBan a, HoaDonBan  b,KhachHang c ";
            sql += "where a.MaHDBan = b.MaHDBan AND b.MaKH = c.MaKH group by b.MaKH,c.HoKH, c.TenKH order by tongtienmua desc";
        }

        private void Top5Ban_Click(object sender, EventArgs e)
        {
            sql = "select top 5 b.MaNV,c.HoNV, c.TenNV, sum(TongTien) as tongtienmua from CTHoaDonBan a, HoaDonBan  b,NhanVien c ";
            sql += "where a.MaHDBan = b.MaHDBan AND b.MaNV = c.MaNV group by b.MaNV,c.HoNV, c.TenNV order by tongtienmua desc";
        }

        private void timKiemDonhang_Load(object sender, EventArgs e)
        {

        }
    }
}
