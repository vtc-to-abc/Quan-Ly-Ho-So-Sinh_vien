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
    public partial class frDSLopHoc : MetroFramework.Forms.MetroForm
    {
        BindingSource DSSinhVien = new BindingSource();
        QuanLyHoSoSinhVienEntities4 db = new QuanLyHoSoSinhVienEntities4();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True");
        public frDSLopHoc()
        {
            InitializeComponent();

            lopcbb.DataSource = db.DSLops.Select(p => p).ToList();
            lopcbb.DisplayMember = ("id");
            lopcbb.ValueMember = ("id");
        }

        private void lopcbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "exec xuat_Lop'" + lopcbb.SelectedValue.ToString() + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;

            dr = objCommand.ExecuteReader();

            while (dr.Read())
            {
                tenlop.Text = dr["tenlop"].ToString();
                nk.Text = dr["NienKhoa"].ToString();
                gvcn.Text = dr["HoTen"].ToString();
                slsv.Text = dr["slsv"].ToString();


                metroGrid1.DataSource = db.xuat_SinhVien_Lop(lopcbb.SelectedValue.ToString());
            }
            con.Close();
        }

        private void ttsvbtt_Click(object sender, EventArgs e)
        {
            frHSSV hs = new frHSSV(lopcbb.SelectedValue.ToString());
            hs.ShowDialog();
                
        }
    }
}
