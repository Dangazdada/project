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
    public partial class frmNhaSX : Form
    {
        public frmNhaSX()
        {
            InitializeComponent();
        }

        private void frmNhaSX_Load(object sender, EventArgs e)
        {

        }

        private void frmNhaSX_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
                e.Cancel = true;
        }
    }
}
