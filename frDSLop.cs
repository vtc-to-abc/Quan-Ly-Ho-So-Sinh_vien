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
    public partial class frDSLop : MetroFramework.Forms.MetroForm
    {
        BindingSource DSSinhVien = new BindingSource();
        QuanLyHoSoSinhVienEntities4 db = new QuanLyHoSoSinhVienEntities4();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True");
        public frDSLop()
        {
            InitializeComponent();

            hocphancbb.DataSource = db.DSLopHocPhans.Select (p => p).ToList();
            hocphancbb.DisplayMember = ("MaLopHocPhan");
            hocphancbb.ValueMember = ("MaLopHocPhan");
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
                gvgd.Text = dr["HoTen"].ToString();

                metroGrid1.DataSource = db.xuat_SinhVien_DiemTB_CaKi_LopHocPhan(hocphancbb.SelectedValue.ToString(), System.Convert.ToInt32(hk.Text));
            }
            con.Close();
        }

        private void ttsvbtt_Click(object sender, EventArgs e)
        {
            frHSSV hs = new frHSSV(hocphancbb.SelectedValue.ToString());
            hs.ShowDialog();
        }
    }
}
