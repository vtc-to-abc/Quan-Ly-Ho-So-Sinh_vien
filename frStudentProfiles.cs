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
    public partial class frStudentProfiles : MetroFramework.Forms.MetroForm
    {
        BindingSource DiemTB = new BindingSource();
        DataTable dt = new DataTable();
        QuanLyHoSoSinhVienEntities4 db = new QuanLyHoSoSinhVienEntities4();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True");
        public frStudentProfiles(string msv)
        {
            InitializeComponent();
            LoadProfile(msv);

            metroGrid1.DataSource = DiemTB;
            DiemTB.DataSource = db.xuat_SinhVien_DiemTB_TaiKhoan(msv).Select(p => p).ToList();
           
        }

        private void LoadProfile(string msv1)
        {
            string sqlQuery = "exec xuat_SinhVien_TaiKhoan'" + msv1 + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;

            dr = objCommand.ExecuteReader();

            while (dr.Read())
            {
                hsmasv.Text = msv1;
                string name = dr["HoTen"].ToString();
                hstensv.Text = name;
                string dob = dr["NgaySinh"].ToString();
                hsdob.Text = dob;
                string gt = dr["GioiTinh"].ToString();
                hssex.Text = gt;
                string qq = dr["QueQuan"].ToString();
                hsquequan.Text = qq;
                string mail = dr["Email"].ToString();
                hsmail.Text = mail;
                string tenlop = dr["tenlop"].ToString();
                hstenlop.Text = tenlop;
                string sdt = dr["SDT"].ToString();
                hssdt.Text = sdt;

            }
            con.Close();
        }

        private void hstenlop_Click(object sender, EventArgs e)
        {

        }

        private void capnhathoso_Click(object sender, EventArgs e)
        {
            frStudentCapNhat sc = new frStudentCapNhat(hsmasv.Text);
            sc.ShowDialog();
        }
    }
}
