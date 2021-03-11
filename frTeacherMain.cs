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
    public partial class frTeacherMain : MetroFramework.Forms.MetroForm
    {
        BindingSource DSSinhVien = new BindingSource();
        QuanLyHoSoSinhVienEntities4 db = new QuanLyHoSoSinhVienEntities4();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True");

        public frTeacherMain(string taikhoan)
        {
            InitializeComponent();
            ShowName(taikhoan);
            hocphancbb.DataSource = db.xuat_LopHP_GiaoVien(magv.Text).Select(p => p).ToList();
            hocphancbb.DisplayMember = ("MaLopHocPhan");
            hocphancbb.ValueMember= ("MaLopHocPhan");
        }

        private void ShowName(string mgv)
        {
            string sqlQuery = "exec xuat_GiaoVien_TaiKhoan'" + mgv + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;

            dr = objCommand.ExecuteReader();

            while (dr.Read())
            {
                string name = dr["HoTen"].ToString();
                tengv.Text = name;
                magv.Text = mgv;
            }
            con.Close();
        }

        private void hocphancbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "exec xuat_LopHP'" + hocphancbb.SelectedValue.ToString() + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;

            dr = objCommand.ExecuteReader();

            while (dr.Read())
            {
                tenmonhoc.Text = dr["TenMonHoc"].ToString();
                hk.Text = dr["HocKi"].ToString();
                slsvmax.Text = dr["SoLuongSV"].ToString();
                slsvdk.Text = dr["slsv"].ToString();
                
                metroGrid1.DataSource = db.xuat_SinhVien_DiemTB_CaKi_LopHocPhan(hocphancbb.SelectedValue.ToString(), System.Convert.ToInt32(hk.Text));
            }
            con.Close();
        }

        private void cndiembtt_Click(object sender, EventArgs e)
        {
            frTeacherCapNhatDiem tc = new frTeacherCapNhatDiem(hocphancbb.SelectedValue.ToString(),hk.Text);
            tc.ShowDialog();
        }

        private void svmainuser_Click(object sender, EventArgs e)
        {
            frLogin l = new frLogin();
            l.Show();
            this.Close();
        }

        private void svmainexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
