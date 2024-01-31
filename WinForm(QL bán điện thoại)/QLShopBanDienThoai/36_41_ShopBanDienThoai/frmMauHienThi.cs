using System;
using System.Collections;
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
    public partial class frmMauHienThi : Form
    {
        
        public frmMauHienThi()
        {
            InitializeComponent();
        }
        cls36_41_ShopBanDienThoai c = new cls36_41_ShopBanDienThoai();
        public ArrayList dschonmau = new ArrayList();
        DataSet dsMau = new DataSet();
        private void frmMauHienThi_Load(object sender, EventArgs e)
        {
            dsMau = c.LayDuLieu("select * from MauSac where TrangThai = 0");
            for(int i = 0;i< dsMau.Tables[0].Rows.Count;i++)
            {
                CheckBox chk = new CheckBox();
                chk.Name = dsMau.Tables[0].Rows[i]["MaMau"].ToString();
                chk.Text = dsMau.Tables[0].Rows[i]["TenMau"].ToString();
                flpMau.Controls.Add(chk);

            }    
        }
        public string phatSinhMau()//cach 1
        {
            string maMau = "";
            if (dsMau.Tables[0].Rows.Count < 10)
            {
                maMau = "M0" + (dsMau.Tables[0].Rows.Count + 1).ToString();
            }
            else
                maMau = "M" + (dsMau.Tables[0].Rows.Count + 1).ToString();
            return maMau;
        }
        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(CheckBox chk in flpMau.Controls)
            {
                if(chk.Checked)
                {
                    dschonmau.Add(chk);
                }    
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into MauSac values('" + phatSinhMau().ToString() + "',N'" + txtTenMau.Text + "',0)";
            if(c.capNhatDuLieu(sql) > 0)
                MessageBox.Show("Ban da cap nhat thanh cong!");
            frmMauHienThi_Load(sender, e);

        }

        private void flpMau_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
