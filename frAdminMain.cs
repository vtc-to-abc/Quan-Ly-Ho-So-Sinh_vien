using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPM_QLyHoSoSinhVien
{
    public partial class frAdminMain : MetroFramework.Forms.MetroForm
    {
        public frAdminMain()
        {
            InitializeComponent();
        }

        private void svmainexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void svmainuser_Click(object sender, EventArgs e)
        {
            frLogin l = new frLogin();
            l.Show();
            this.Close();
        }

        private void frAdminMain_Load(object sender, EventArgs e)
        {

        }

        private void hocphanbtt_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            frDSLop sp = new frDSLop();
            sp.MdiParent = this;
            this.metroPanel2.Controls.Add(sp);
            sp.Dock = DockStyle.Fill;
            sp.Show();
        }

        private void lophocbtt_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            frDSLopHoc sp = new frDSLopHoc();
            sp.MdiParent = this;
            this.metroPanel2.Controls.Add(sp);
            sp.Dock = DockStyle.Fill;
            sp.Show();
        }

        private void taikhoanbtt_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            frDSTaiKhoan sp = new frDSTaiKhoan();
            sp.MdiParent = this;
            this.metroPanel2.Controls.Add(sp);
            sp.Dock = DockStyle.Fill;
            sp.Show();
        }
    }
}
