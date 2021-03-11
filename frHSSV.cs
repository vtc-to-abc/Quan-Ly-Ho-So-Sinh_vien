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
    public partial class frHSSV : MetroFramework.Forms.MetroForm
    {
        BindingSource DiemTB = new BindingSource();
        DataTable dt = new DataTable();
        QuanLyHoSoSinhVienEntities4 db = new QuanLyHoSoSinhVienEntities4();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True");
        public frHSSV(string malop)
        {
            InitializeComponent();
            Load1(malop);

        }

        private void Load1(string ml)
        {
           
                SqlCommand scmd = new SqlCommand("select count (*)  from DSLopHocPhan where MaLopHocPhan=@usr", con);
                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@usr", ml);
            try
            {
                con.Open();
                if (scmd.ExecuteScalar().ToString() == "1")
                {
                    svcbb2.Visible = false;
                    svcbb2.Enabled = false;
                    
                    svcbb.Visible = true;
                    svcbb.Enabled = true;
                    svcbb.DataSource = db.xuat_SinhVien_LopHocPhan(ml).Select(p => p).ToList();
                    svcbb.DisplayMember = ("MaSV");
                    svcbb.ValueMember = ("MaSV");
                }
                else
                {
                    svcbb.Visible = false;
                    svcbb.Enabled = false;
                    svcbb2.Visible = true;
                    svcbb2.Enabled = true;
                    svcbb2.DataSource = db.xuat_SinhVien_Lop(ml).Select(p => p).ToList();
                    svcbb2.DisplayMember = ("MaSV");
                    svcbb2.ValueMember = ("MaSV");

                }
            }
            catch { }
            finally
            {
                con.Close();
            }
        }

        private void capnhathoso_Click(object sender, EventArgs e)
        {
            if (svcbb.Enabled == true)
            {
                frStudentCapNhat scn = new frStudentCapNhat(svcbb.SelectedValue.ToString());
                scn.ShowDialog();
            }
            else
            {
                frStudentCapNhat scn = new frStudentCapNhat(svcbb2.SelectedValue.ToString());
                scn.ShowDialog();
            }

        }

       

        private void backbtt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bangdiembtt_Click(object sender, EventArgs e)
        {
            if (svcbb.Enabled == true)
            {
                frStudentBangDiem bd = new frStudentBangDiem(svcbb.SelectedValue.ToString());
                bd.ControlBox = true;
                bd.ShowDialog();
            }
            else
            {
                frStudentBangDiem bd = new frStudentBangDiem(svcbb2.SelectedValue.ToString());
                bd.ControlBox = true;
                bd.ShowDialog();
            }
            
        }

      

        private void svcbb2_SelectedIndexChanged(object sender, EventArgs e)
        {


            string sqlQuery = "exec xuat_SinhVien_TaiKhoan'" + svcbb2.SelectedValue.ToString() + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);


            try
            {

                con.Open();

                objCommand.ExecuteNonQuery();
                SqlDataReader dr;
                dr = objCommand.ExecuteReader();
                while (dr.Read())
                {
                    hsmasv.Text = svcbb2.SelectedValue.ToString();
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


                    metroGrid1.DataSource = DiemTB;
                    DiemTB.DataSource = db.xuat_SinhVien_DiemTB_TaiKhoan(svcbb2.SelectedValue.ToString()).Select(p => p).ToList();

                }
            }
            catch {  }
            finally
            {
                con.Close();
            }

        }

        private void svcbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "exec xuat_SinhVien_TaiKhoan'" + svcbb.SelectedValue.ToString() + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            

            try
            {

                con.Open();

                objCommand.ExecuteNonQuery();
                SqlDataReader dr;
                dr = objCommand.ExecuteReader();
                while (dr.Read())
                {
                    hsmasv.Text = svcbb.SelectedValue.ToString();
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


                    metroGrid1.DataSource = DiemTB;
                    DiemTB.DataSource = db.xuat_SinhVien_DiemTB_TaiKhoan(svcbb.SelectedValue.ToString()).Select(p => p).ToList();

                }
            }
            catch {  }
            finally
            {
                con.Close();
            }
            
        }
    }
}
