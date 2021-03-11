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
    public partial class frStudentBangDiem : MetroFramework.Forms.MetroForm
    {
        QuanLyHoSoSinhVienEntities4 db = new QuanLyHoSoSinhVienEntities4();
        BindingSource DiemList = new BindingSource();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True");
        public frStudentBangDiem(string msv)
        {
            InitializeComponent();
            masv.Text = msv;
            List<int> hk = new List<int>();
            for (int i = 1; i <= 8; i++) hk.Add(i);
            metroComboBox1.DataSource = hk.Select(p => p).ToList();
          //  metroComboBox1.DisplayMember = ("HocKi");
          //  metroComboBox1.ValueMember = ("HocKi");
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int hk = System.Convert.ToInt32(metroComboBox1.SelectedValue);
            string sqlQuery1 = "exec xuat_SinhVien_DiemTB_CaKi'" + masv.Text + "'," + hk+"";
            SqlCommand objCommand1 = new SqlCommand(sqlQuery1, con);

            string sqlQuery2 = "exec xuat_SinhVien_TinChi'" + masv.Text + "'";
            SqlCommand objCommand2 = new SqlCommand(sqlQuery2, con);

            string sqlQuery3 = "exec xuat_SinhVien_TinChiTL'" + masv.Text + "'";
            SqlCommand objCommand3 = new SqlCommand(sqlQuery3, con);

            string sqlQuery = "exec xuat_SinhVien_TaiKhoan'" + masv.Text + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();

            SqlDataReader dr;
            
            dr = objCommand.ExecuteReader();

            while (dr.Read())
            {
                metroGrid1.DataSource = DiemList;
                DiemList.DataSource = db.xuat_DSDiem_SinhVien_Ki(masv.Text,hk).Select(p => p).ToList();
                
            }
            con.Close();

            con.Open();
            objCommand1.ExecuteNonQuery();
            SqlDataReader dr1;
            dr1 = objCommand1.ExecuteReader();
            while (dr1.Read())
            {
                diemtbcaki.Text = dr1["tb"].ToString();

            }
            con.Close();

            con.Open();
            objCommand2.ExecuteNonQuery();
            SqlDataReader dr2;
            dr2 = objCommand2.ExecuteReader();
            while (dr2.Read())
            {
                tongtc.Text = dr2["tctl"].ToString();

            }
            con.Close();

            con.Open();
            objCommand3.ExecuteNonQuery();
            SqlDataReader dr3;
            dr3= objCommand3.ExecuteReader();
            while (dr3.Read())
            {
                tctl.Text = dr3["tctl"].ToString();

            }
            con.Close();
        }
    }
}
