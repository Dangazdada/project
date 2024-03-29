﻿using System;
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
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void GiaoDienNhap_Load(object sender, EventArgs e)
        {

        }

        private void nhậpNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhapNhanVien f = new frmnhapNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void nhậpKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhapKhachHang f = new frmnhapKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void nhậpNhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaSX f = new frmNhaSX();
            f.MdiParent = this;
            f.Show();
        }

        private void nhậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    cboTrangThai f = new cboTrangThai();
        //    f.MdiParent = this;
        //    f.Show();
        }

        private void nhậpBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoHanh f = new BaoHanh();
            f.MdiParent = this;
            f.Show();
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMau f = new frmMau();
            f.MdiParent = this;
            f.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonBan f = new HoaDonBan();
            f.MdiParent = this;
            f.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanpham f = new frmSanpham();
            f.MdiParent = this;
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timKiemDonhang f = new timKiemDonhang();
            f.MdiParent = this;
            f.Show();
        }

        private void điệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.MdiParent = this;
            f.Show();
        }
    }
}
