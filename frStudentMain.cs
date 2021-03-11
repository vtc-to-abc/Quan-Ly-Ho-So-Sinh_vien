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
    public partial class frStudentMain : MetroFramework.Forms.MetroForm
    {
        QuanLyHoSoSinhVienEntities4 db = new QuanLyHoSoSinhVienEntities4();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True");
        public frStudentMain(string taikhoan)
        {
            InitializeComponent();
            ShowName(taikhoan);
            
        }

        private void ShowName(string msv)
        {
            string sqlQuery = "exec xuat_TenSinhVien_TaiKhoan'" + msv + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;

            dr = objCommand.ExecuteReader();

            while (dr.Read())
            {


                string name = dr["HoTen"].ToString();
                svname.Text = name;
                svma.Text = msv;
            }
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

        private void HoSobtt_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            frStudentProfiles sp = new frStudentProfiles(this.svma.Text);
            sp.MdiParent = this;
            this.metroPanel2.Controls.Add(sp);
            sp.Dock = DockStyle.Fill;
            sp.Show();


        }

        private void BangDiembtt_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            frStudentBangDiem sp = new frStudentBangDiem(this.svma.Text);
            sp.MdiParent = this;
            this.metroPanel2.Controls.Add(sp);
            sp.Dock = DockStyle.Fill;
            sp.Show();
        }

        private void svmainsetting_Click(object sender, EventArgs e)
        {

        }
    }
}
