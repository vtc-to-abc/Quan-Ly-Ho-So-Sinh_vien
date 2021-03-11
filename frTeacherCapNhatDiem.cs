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
    public partial class frTeacherCapNhatDiem : MetroFramework.Forms.MetroForm
    {
       
        QuanLyHoSoSinhVienEntities4 db = new QuanLyHoSoSinhVienEntities4();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True");
        public frTeacherCapNhatDiem(string lophp1,string ki)
        {
            InitializeComponent();
            lophp.Text = lophp1;
            hk.Text = ki;
            svmacbb.DataSource = db.xuat_SinhVien_LopHocPhan(lophp1).Select(p => p).ToList();
            svmacbb.DisplayMember = ("MaSV");
            svmacbb.ValueMember = ("MaSV");

        }

        private void svmacbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "exec xuat_SinhVien_Diem_CaKi_LopHocPhan'"+svmacbb.SelectedValue.ToString()+"','" + lophp.Text+ "',"+System.Convert.ToInt32(hk.Text)+"";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;

            dr = objCommand.ExecuteReader();

            while (dr.Read())
            {
                svnametxt.Text = dr["HoTen"].ToString();
                dcc.Text = dr["dcc"].ToString();
                dtx.Text = dr["dtx"].ToString();
                dt.Text = dr["dt"].ToString();
                //metroGrid1.DataSource = db.xuat_SinhVien_LopHocPhan(hocphancbb.SelectedValue.ToString());
            }
            con.Close();
        }

        private void cancelbtt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesbtt_Click(object sender, EventArgs e)
        {
            try
            {
                db.Sua_SinhVien_Diem(svmacbb.SelectedValue.ToString(), lophp.Text, System.Convert.ToDouble(dcc.Text), System.Convert.ToDouble(dtx.Text), System.Convert.ToDouble(dt.Text));
                MessageBox.Show("Sửa Thành Công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Kiểm tra dữ liệu nhập vào");
            }
        }
    }
}
