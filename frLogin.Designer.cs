namespace CMPM_QLyHoSoSinhVien
{
    partial class frLogin
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
            this.usertxt = new MetroFramework.Controls.MetroTextBox();
            this.passtxt = new MetroFramework.Controls.MetroTextBox();
            this.Loginbtt = new MetroFramework.Controls.MetroTile();
            this.errorDangNhap = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // usertxt
            // 
            // 
            // 
            // 
            this.usertxt.CustomButton.Image = null;
            this.usertxt.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.usertxt.CustomButton.Name = "";
            this.usertxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usertxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usertxt.CustomButton.TabIndex = 1;
            this.usertxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usertxt.CustomButton.UseSelectable = true;
            this.usertxt.CustomButton.Visible = false;
            this.usertxt.Lines = new string[0];
            this.usertxt.Location = new System.Drawing.Point(44, 98);
            this.usertxt.MaxLength = 32767;
            this.usertxt.Name = "usertxt";
            this.usertxt.PasswordChar = '\0';
            this.usertxt.PromptText = "Tên Đăng Nhập...";
            this.usertxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usertxt.SelectedText = "";
            this.usertxt.SelectionLength = 0;
            this.usertxt.SelectionStart = 0;
            this.usertxt.ShortcutsEnabled = true;
            this.usertxt.Size = new System.Drawing.Size(308, 23);
            this.usertxt.TabIndex = 0;
            this.usertxt.UseSelectable = true;
            this.usertxt.WaterMark = "Tên Đăng Nhập...";
            this.usertxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usertxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.usertxt.Click += new System.EventHandler(this.usertxt_Click);
            // 
            // passtxt
            // 
            // 
            // 
            // 
            this.passtxt.CustomButton.Image = null;
            this.passtxt.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.passtxt.CustomButton.Name = "";
            this.passtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passtxt.CustomButton.TabIndex = 1;
            this.passtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passtxt.CustomButton.UseSelectable = true;
            this.passtxt.CustomButton.Visible = false;
            this.passtxt.Lines = new string[0];
            this.passtxt.Location = new System.Drawing.Point(44, 179);
            this.passtxt.MaxLength = 32767;
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.PromptText = "mật khẩu...";
            this.passtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passtxt.SelectedText = "";
            this.passtxt.SelectionLength = 0;
            this.passtxt.SelectionStart = 0;
            this.passtxt.ShortcutsEnabled = true;
            this.passtxt.Size = new System.Drawing.Size(308, 23);
            this.passtxt.TabIndex = 1;
            this.passtxt.UseSelectable = true;
            this.passtxt.WaterMark = "mật khẩu...";
            this.passtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Loginbtt
            // 
            this.Loginbtt.ActiveControl = null;
            this.Loginbtt.Location = new System.Drawing.Point(253, 252);
            this.Loginbtt.Name = "Loginbtt";
            this.Loginbtt.Size = new System.Drawing.Size(99, 37);
            this.Loginbtt.TabIndex = 2;
            this.Loginbtt.Text = "Đăng Nhập";
            this.Loginbtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Loginbtt.UseSelectable = true;
            this.Loginbtt.Click += new System.EventHandler(this.Loginbtt_Click);
            // 
            // errorDangNhap
            // 
            this.errorDangNhap.ContainerControl = this;
            // 
            // frLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 361);
            this.Controls.Add(this.Loginbtt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Name = "frLogin";
            this.Text = "               Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.errorDangNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox usertxt;
        private MetroFramework.Controls.MetroTextBox passtxt;
        private MetroFramework.Controls.MetroTile Loginbtt;
        private System.Windows.Forms.ErrorProvider errorDangNhap;
    }
}

