namespace CMPM_QLyHoSoSinhVien
{
    partial class frStudentMain
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.svname = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.HoSobtt = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.BangDiembtt = new MetroFramework.Controls.MetroTile();
            this.svmainexit = new System.Windows.Forms.PictureBox();
            this.svmainsetting = new System.Windows.Forms.PictureBox();
            this.svmainuser = new System.Windows.Forms.PictureBox();
            this.svma = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svmainexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svmainsetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svmainuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Xin Chào ";
            // 
            // svname
            // 
            this.svname.AutoSize = true;
            this.svname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.svname.ForeColor = System.Drawing.Color.Red;
            this.svname.Location = new System.Drawing.Point(77, 38);
            this.svname.Name = "svname";
            this.svname.Size = new System.Drawing.Size(0, 0);
            this.svname.TabIndex = 1;
            this.svname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.svname.UseCustomBackColor = true;
            this.svname.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.HoSobtt);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(17, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(122, 462);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // HoSobtt
            // 
            this.HoSobtt.ActiveControl = null;
            this.HoSobtt.Location = new System.Drawing.Point(0, 109);
            this.HoSobtt.Name = "HoSobtt";
            this.HoSobtt.Size = new System.Drawing.Size(115, 64);
            this.HoSobtt.TabIndex = 2;
            this.HoSobtt.Text = "Hồ Sơ";
            this.HoSobtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HoSobtt.UseSelectable = true;
            this.HoSobtt.Click += new System.EventHandler(this.HoSobtt_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(138, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(676, 449);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // BangDiembtt
            // 
            this.BangDiembtt.ActiveControl = null;
            this.BangDiembtt.Location = new System.Drawing.Point(17, 272);
            this.BangDiembtt.Name = "BangDiembtt";
            this.BangDiembtt.Size = new System.Drawing.Size(115, 64);
            this.BangDiembtt.TabIndex = 3;
            this.BangDiembtt.Text = "Bảng Điểm";
            this.BangDiembtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BangDiembtt.UseSelectable = true;
            this.BangDiembtt.Click += new System.EventHandler(this.BangDiembtt_Click);
            // 
            // svmainexit
            // 
            this.svmainexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.svmainexit.Image = global::CMPM_QLyHoSoSinhVien.Properties.Resources._46_512;
            this.svmainexit.Location = new System.Drawing.Point(754, 18);
            this.svmainexit.Name = "svmainexit";
            this.svmainexit.Size = new System.Drawing.Size(40, 36);
            this.svmainexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.svmainexit.TabIndex = 10;
            this.svmainexit.TabStop = false;
            this.svmainexit.WaitOnLoad = true;
            this.svmainexit.Click += new System.EventHandler(this.svmainexit_Click);
            // 
            // svmainsetting
            // 
            this.svmainsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.svmainsetting.Image = global::CMPM_QLyHoSoSinhVien.Properties.Resources.blue_settings_icon_9;
            this.svmainsetting.Location = new System.Drawing.Point(696, 18);
            this.svmainsetting.Name = "svmainsetting";
            this.svmainsetting.Size = new System.Drawing.Size(36, 36);
            this.svmainsetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.svmainsetting.TabIndex = 9;
            this.svmainsetting.TabStop = false;
            this.svmainsetting.Click += new System.EventHandler(this.svmainsetting_Click);
            // 
            // svmainuser
            // 
            this.svmainuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.svmainuser.Image = global::CMPM_QLyHoSoSinhVien.Properties.Resources.people_106458;
            this.svmainuser.Location = new System.Drawing.Point(630, 18);
            this.svmainuser.Name = "svmainuser";
            this.svmainuser.Size = new System.Drawing.Size(40, 36);
            this.svmainuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.svmainuser.TabIndex = 8;
            this.svmainuser.TabStop = false;
            this.svmainuser.Click += new System.EventHandler(this.svmainuser_Click);
            // 
            // svma
            // 
            this.svma.AutoSize = true;
            this.svma.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.svma.ForeColor = System.Drawing.Color.Red;
            this.svma.Location = new System.Drawing.Point(209, 38);
            this.svma.Name = "svma";
            this.svma.Size = new System.Drawing.Size(0, 0);
            this.svma.TabIndex = 12;
            this.svma.UseCustomForeColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(837, 532);
            this.ControlBox = false;
            this.Controls.Add(this.svma);
            this.Controls.Add(this.svmainexit);
            this.Controls.Add(this.svmainsetting);
            this.Controls.Add(this.svmainuser);
            this.Controls.Add(this.BangDiembtt);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.svname);
            this.Controls.Add(this.metroLabel1);
            this.IsMdiContainer = true;
            this.Name = "frStudentMain";
            this.Text = "                                            Hồ Sơ Sinh Viên";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svmainexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svmainsetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svmainuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel svname;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile HoSobtt;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile BangDiembtt;
        private System.Windows.Forms.PictureBox svmainexit;
        private System.Windows.Forms.PictureBox svmainsetting;
        private System.Windows.Forms.PictureBox svmainuser;
        private MetroFramework.Controls.MetroLabel svma;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}