using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPM_QLyHoSoSinhVien
{
    public partial class frDSTaiKhoan : MetroFramework.Forms.MetroForm
    {
        BindingSource DSTK= new BindingSource();
        QuanLyHoSoSinhVienEntities4 db = new QuanLyHoSoSinhVienEntities4();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True");
        public frDSTaiKhoan()
        {
            InitializeComponent();
            Load();
            Bingding();
        }
        private void Load()
        {
            metroGrid1.DataSource = DSTK;
            DSTK.DataSource = db.xuat_TaiKhoan();
         
        }
        private void Bingding()
        {
            tdntxt.DataBindings.Add(new Binding("Text", metroGrid1.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never));
            mktxt.DataBindings.Add(new Binding("Text", metroGrid1.DataSource, "MatKhau", true, DataSourceUpdateMode.Never));
            quyentxt.DataBindings.Add(new Binding("Text", metroGrid1.DataSource, "QuyenHan", true, DataSourceUpdateMode.Never));
            ngaylappicker.DataBindings.Add(new Binding("Value", metroGrid1.DataSource, "NgayLap", true, DataSourceUpdateMode.Never));
            han.DataBindings.Add(new Binding("Value", metroGrid1.DataSource, "NgayHetHan", true, DataSourceUpdateMode.Never));
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void hạn_ValueChanged(object sender, EventArgs e)
        {
            if (han.Value == DateTime.Today)
            {
                canhbao.Visible = true;
            }
            else
            {
                canhbao.Visible = false;
            }
        }

        private void thembtt_Click(object sender, EventArgs e)
        {
            try
            {

                db.new_TaiKhoan(tdntxt.Text,mktxt.Text,ngaylappicker.Value,han.Value,System.Convert.ToInt32(quyentxt.Text));
                MessageBox.Show("thêm mới thành công");
                Load();
            }
            catch
            {
                MessageBox.Show("kiểm tra lại dữ liệu");
            }
        }

        private void suabtt_Click(object sender, EventArgs e)
        {
            //try
            //{

                db.sua_TaiKhoan(tdntxt.Text, mktxt.Text, ngaylappicker.Value, han.Value, System.Convert.ToInt32(quyentxt.Text));
                MessageBox.Show("sửa mới thành công");
                Load();
         //   }
         //   catch
          //  {
         //       MessageBox.Show("kiểm tra lại dữ liệu");
         //   }
        }

        private void xoabtt_Click(object sender, EventArgs e)
        {
            try
            {

                db.xoa_TaiKhoan(tdntxt.Text);
                MessageBox.Show("xóa mới thành công");
                Load();
            }
            catch
            {
                MessageBox.Show("kiểm tra lại dữ liệu");
            }
        }

        private void searchbtt_Click(object sender, EventArgs e)
        {
            try
            {

                metroGrid1.DataSource = db.tk_TaiKhoan(searchtxt.Text);
            }
            catch
            {
                MessageBox.Show("không có thông tin trùng với từ khóa");
            }
        }
    }
}
