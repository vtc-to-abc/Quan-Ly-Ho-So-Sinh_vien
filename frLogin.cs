using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CMPM_QLyHoSoSinhVien
{
    public partial class frLogin : MetroFramework.Forms.MetroForm
    {
        string Quyen;
        public frLogin()
        {
            InitializeComponent();
        }

        private void usertxt_Click(object sender, EventArgs e)
        {

        }

        private void Loginbtt_Click(object sender, EventArgs e)
        {
            if ((usertxt.Text == "") || (passtxt.Text == ""))
            {

                errorDangNhap.SetError(usertxt, "Tài Khoản Lỗi");
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {


                errorDangNhap.SetError(usertxt, "OK");

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True");
                string sqlQuery = "SELECT QuyenHan FROM TaiKhoan where TenDangNhap= '" + usertxt.Text + "'";
                SqlCommand objCommand = new SqlCommand(sqlQuery, con);
                con.Open();
                objCommand.ExecuteNonQuery();
                SqlDataReader dr;

                dr = objCommand.ExecuteReader();


                while (dr.Read())
                {
                    Quyen = dr["QuyenHan"].ToString();
                }

                SqlConnection scn = new SqlConnection();
                scn.ConnectionString = @"server=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;integrated security=true";
                SqlCommand scmd = new SqlCommand("select count (*)  from TaiKhoan where TenDangNhap=@usr and MatKhau=@pwd", scn);
                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@usr", usertxt.Text);
                scmd.Parameters.AddWithValue("@pwd", passtxt.Text);
                scn.Open();
                if (scmd.ExecuteScalar().ToString() == "1")
                {
                    if (Quyen.Equals("1"))
                    {
                        MessageBox.Show("đăng nhập thành công");
                        frTeacherMain h = new frTeacherMain(usertxt.Text);
                        h.Show();
                        this.Hide();
                    }
                    else if (Quyen.Equals("2"))
                    {
                        MessageBox.Show("đăng nhập thành công");
                        frStudentMain h = new frStudentMain(usertxt.Text);
                        h.Show();
                        this.Hide();
                    }

                    else if (Quyen.Equals("0"))
                    {
                        MessageBox.Show("đăng nhập thành công");
                        frAdminMain h = new frAdminMain();
                        h.Show();
                        this.Hide();
                    }
                }

                else
                {
                    usertxt.Clear();
                    passtxt.Clear();
                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Hoặc Tài Khoản");
                }
                scn.Close();

            }
        }
    }
}
