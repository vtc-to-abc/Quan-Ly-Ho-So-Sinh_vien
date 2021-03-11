namespace CMPM_QLyHoSoSinhVien
{
    partial class frTeacherCapNhatDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.svmacbb = new MetroFramework.Controls.MetroComboBox();
            this.svnametxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dcc = new MetroFramework.Controls.MetroTextBox();
            this.dtx = new MetroFramework.Controls.MetroTextBox();
            this.dt = new MetroFramework.Controls.MetroTextBox();
            this.cancelbtt = new MetroFramework.Controls.MetroTile();
            this.yesbtt = new MetroFramework.Controls.MetroTile();
            this.hk = new MetroFramework.Controls.MetroLabel();
            this.lophp = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Sinh Viên";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // svmacbb
            // 
            this.svmacbb.FormattingEnabled = true;
            this.svmacbb.ItemHeight = 23;
            this.svmacbb.Location = new System.Drawing.Point(133, 67);
            this.svmacbb.Name = "svmacbb";
            this.svmacbb.Size = new System.Drawing.Size(149, 29);
            this.svmacbb.TabIndex = 4;
            this.svmacbb.UseSelectable = true;
            this.svmacbb.SelectedIndexChanged += new System.EventHandler(this.svmacbb_SelectedIndexChanged);
            // 
            // svnametxt
            // 
            // 
            // 
            // 
            this.svnametxt.CustomButton.Image = null;
            this.svnametxt.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.svnametxt.CustomButton.Name = "";
            this.svnametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.svnametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.svnametxt.CustomButton.TabIndex = 1;
            this.svnametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.svnametxt.CustomButton.UseSelectable = true;
            this.svnametxt.CustomButton.Visible = false;
            this.svnametxt.Lines = new string[0];
            this.svnametxt.Location = new System.Drawing.Point(298, 69);
            this.svnametxt.MaxLength = 32767;
            this.svnametxt.Name = "svnametxt";
            this.svnametxt.PasswordChar = '\0';
            this.svnametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.svnametxt.SelectedText = "";
            this.svnametxt.SelectionLength = 0;
            this.svnametxt.SelectionStart = 0;
            this.svnametxt.ShortcutsEnabled = true;
            this.svnametxt.Size = new System.Drawing.Size(199, 23);
            this.svnametxt.TabIndex = 5;
            this.svnametxt.UseSelectable = true;
            this.svnametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.svnametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(103, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Điểm Chuyên Cần";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(103, 243);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Điểm Thi";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(103, 187);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(144, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Điểm Thường Xuyên";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // dcc
            // 
            // 
            // 
            // 
            this.dcc.CustomButton.Image = null;
            this.dcc.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.dcc.CustomButton.Name = "";
            this.dcc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dcc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dcc.CustomButton.TabIndex = 1;
            this.dcc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dcc.CustomButton.UseSelectable = true;
            this.dcc.CustomButton.Visible = false;
            this.dcc.Lines = new string[0];
            this.dcc.Location = new System.Drawing.Point(298, 134);
            this.dcc.MaxLength = 32767;
            this.dcc.Name = "dcc";
            this.dcc.PasswordChar = '\0';
            this.dcc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dcc.SelectedText = "";
            this.dcc.SelectionLength = 0;
            this.dcc.SelectionStart = 0;
            this.dcc.ShortcutsEnabled = true;
            this.dcc.Size = new System.Drawing.Size(105, 23);
            this.dcc.TabIndex = 9;
            this.dcc.UseSelectable = true;
            this.dcc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dcc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtx
            // 
            // 
            // 
            // 
            this.dtx.CustomButton.Image = null;
            this.dtx.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.dtx.CustomButton.Name = "";
            this.dtx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dtx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dtx.CustomButton.TabIndex = 1;
            this.dtx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dtx.CustomButton.UseSelectable = true;
            this.dtx.CustomButton.Visible = false;
            this.dtx.Lines = new string[0];
            this.dtx.Location = new System.Drawing.Point(298, 183);
            this.dtx.MaxLength = 32767;
            this.dtx.Name = "dtx";
            this.dtx.PasswordChar = '\0';
            this.dtx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtx.SelectedText = "";
            this.dtx.SelectionLength = 0;
            this.dtx.SelectionStart = 0;
            this.dtx.ShortcutsEnabled = true;
            this.dtx.Size = new System.Drawing.Size(105, 23);
            this.dtx.TabIndex = 10;
            this.dtx.UseSelectable = true;
            this.dtx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dtx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dt
            // 
            // 
            // 
            // 
            this.dt.CustomButton.Image = null;
            this.dt.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.dt.CustomButton.Name = "";
            this.dt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt.CustomButton.TabIndex = 1;
            this.dt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dt.CustomButton.UseSelectable = true;
            this.dt.CustomButton.Visible = false;
            this.dt.Lines = new string[0];
            this.dt.Location = new System.Drawing.Point(298, 243);
            this.dt.MaxLength = 32767;
            this.dt.Name = "dt";
            this.dt.PasswordChar = '\0';
            this.dt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dt.SelectedText = "";
            this.dt.SelectionLength = 0;
            this.dt.SelectionStart = 0;
            this.dt.ShortcutsEnabled = true;
            this.dt.Size = new System.Drawing.Size(105, 23);
            this.dt.TabIndex = 11;
            this.dt.UseSelectable = true;
            this.dt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cancelbtt
            // 
            this.cancelbtt.ActiveControl = null;
            this.cancelbtt.Location = new System.Drawing.Point(23, 279);
            this.cancelbtt.Name = "cancelbtt";
            this.cancelbtt.Size = new System.Drawing.Size(92, 50);
            this.cancelbtt.TabIndex = 12;
            this.cancelbtt.Text = "Hủy";
            this.cancelbtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelbtt.UseSelectable = true;
            this.cancelbtt.Click += new System.EventHandler(this.cancelbtt_Click);
            // 
            // yesbtt
            // 
            this.yesbtt.ActiveControl = null;
            this.yesbtt.Location = new System.Drawing.Point(410, 279);
            this.yesbtt.Name = "yesbtt";
            this.yesbtt.Size = new System.Drawing.Size(99, 50);
            this.yesbtt.TabIndex = 13;
            this.yesbtt.Text = "Đồng Ý";
            this.yesbtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yesbtt.UseSelectable = true;
            this.yesbtt.Click += new System.EventHandler(this.yesbtt_Click);
            // 
            // hk
            // 
            this.hk.AutoSize = true;
            this.hk.Location = new System.Drawing.Point(49, 20);
            this.hk.Name = "hk";
            this.hk.Size = new System.Drawing.Size(83, 19);
            this.hk.TabIndex = 14;
            this.hk.Text = "metroLabel5";
            this.hk.Visible = false;
            // 
            // lophp
            // 
            this.lophp.AutoSize = true;
            this.lophp.Location = new System.Drawing.Point(49, 48);
            this.lophp.Name = "lophp";
            this.lophp.Size = new System.Drawing.Size(83, 19);
            this.lophp.TabIndex = 15;
            this.lophp.Text = "metroLabel5";
            this.lophp.Visible = false;
            // 
            // frTeacherCapNhatDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 338);
            this.Controls.Add(this.lophp);
            this.Controls.Add(this.hk);
            this.Controls.Add(this.yesbtt);
            this.Controls.Add(this.cancelbtt);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.dtx);
            this.Controls.Add(this.dcc);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.svnametxt);
            this.Controls.Add(this.svmacbb);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frTeacherCapNhatDiem";
            this.Text = "                  Cập Nhật Điểm Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox svmacbb;
        private MetroFramework.Controls.MetroTextBox svnametxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox dcc;
        private MetroFramework.Controls.MetroTextBox dtx;
        private MetroFramework.Controls.MetroTextBox dt;
        private MetroFramework.Controls.MetroTile cancelbtt;
        private MetroFramework.Controls.MetroTile yesbtt;
        private MetroFramework.Controls.MetroLabel hk;
        private MetroFramework.Controls.MetroLabel lophp;
    }
}