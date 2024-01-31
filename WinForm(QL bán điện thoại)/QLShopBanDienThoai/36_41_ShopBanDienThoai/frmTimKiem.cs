using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_41_ShopBanDienThoai
{
    
    public partial class frmTimKiem : Form
    {
        cls36_41_ShopBanDienThoai c = new cls36_41_ShopBanDienThoai();
        DataSet dsdskqsp = new DataSet();
        DataSet dsnsx = new DataSet();
        public frmTimKiem()
        {
            InitializeComponent();
        }
        void hienthicombobox(DataSet ds, ComboBox cb, string ma, string ten)
        {
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
            cb.SelectedIndex = -1;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int gia1 = 0;
            int gia2 = 0;

            
            switch(cboChonGia.SelectedIndex)
            {
                case 0:
                    {
                        gia1 = 2000000;
                        gia2 = 4000000;
                        break;
                    }
                case 1:
                    {
                        gia1 = 4000000;
                        gia2 = 6000000;
                        break;
                    }
                case 2:
                    {
                        gia1 = 6000000;
                        gia2 = 10000000;
                        break;
                    }
                case 3:
                    {
                        gia1 = 10000000;
                        gia2  = 30000000;
                        break;
                    }
                case -1:
                    {
                        gia2 = 0;
                        gia2 = 0;
                        break;
                    }
            }
            string sql = "";
            if (cboNSX.SelectedIndex == -1 && gia1 != 0)
            {
                sql = "select * from DienThoai where Giabanle Between " + gia1 + " and " + gia2 + "";
            } 
            else if(cboNSX.SelectedIndex != -1 && gia1  == 0)
            {
                string mansx = cboNSX.SelectedValue.ToString();

                sql = "select * from DienThoai where MaNSX = '" + mansx + "'";
            } 
            else if(cboNSX.SelectedIndex ==-1 && gia1 == 0)
            {
                sql = "select * from DienThoai";
            } 
            else if(cboNSX.SelectedIndex != -1 && gia1 != 0)
            {
                string mansx = cboNSX.SelectedValue.ToString();

                sql = "select * from DienThoai where MaNSX = '" + mansx + "' and Giabanle Between " + gia1 + " and " + gia2 + "";
            }    
            
             
            
            dsdskqsp = c.LayDuLieu(sql);
            dgvDSKQ.DataSource = dsdskqsp.Tables[0];
              




        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            dsnsx = c.LayDuLieu("select * from NhaSanXuat");
            hienthicombobox(dsnsx, cboNSX, "MaNSX", "TenNhaSX");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hienthicombobox(dsnsx, cboNSX, "MaNSX", "TenNSX");
        }

        private void btnChontatCaGia_Click(object sender, EventArgs e)
        {
            cboChonGia.SelectedIndex = -1;
        }
    }
}
