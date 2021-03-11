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
    public partial class frStudentCapNhat : MetroFramework.Forms.MetroForm
    {
        QuanLyHoSoSinhVienEntities4 db = new QuanLyHoSoSinhVienEntities4();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True");
        public frStudentCapNhat(string msv1)
        {
            InitializeComponent();
            msv.Text = msv1;
            svtenlopcbb.DataSource = db.DSLops.Select(p => p).ToList();
            svtenlopcbb.DisplayMember = ("tenlop");
            svtenlopcbb.ValueMember = ("id");
            

            string sqlQuery = "exec xuat_SinhVien_TaiKhoan'" + msv.Text + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;

            dr = objCommand.ExecuteReader();

            while (dr.Read())
            {

                svnametxt.Text = dr["HoTen"].ToString();
                svtenlopcbb.SelectedValue = dr["MaLop"].ToString();
                svmailtxt.Text = dr["Email"].ToString();
                svquequantxt.Text = dr["QueQuan"].ToString();
                svsdttxt.Text = dr["SDT"].ToString();
                svdob.Value = (DateTime)dr["NgaySinh"];
                if (dr["GioiTinh"].ToString() == "Nam")
                {
                    radnam.Checked = true;
                }
                else
                {
                    radnam.Checked = false;
                    radnu.Checked = true;
                }
                
            }

        }

        private void hscapnhatyesbtt_Click(object sender, EventArgs e)
        {
            try {
                string gt = (radnam.Checked == true) ? "Nam" : "Nữ";
                db.Sua_SinhVien_HoSo(msv.Text, svnametxt.Text, svdob.Value, svsdttxt.Text, gt, svquequantxt.Text, svmailtxt.Text, svtenlopcbb.SelectedValue.ToString());
                MessageBox.Show("Cập Nhật Thành Công");
                this.Close(); }
            catch
            {
                MessageBox.Show("Kiểm tra lại Thông Tin");
            }
        }

        private void hscapnhapcancelbtt_Click(object sender, EventArgs e)
        {
           
     
            this.Close();
        }
    }
}
