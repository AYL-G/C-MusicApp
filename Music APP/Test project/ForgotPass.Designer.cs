namespace Test_project
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.resetpass = new System.Windows.Forms.Button();
            this.step1 = new System.Windows.Forms.GroupBox();
            this.hide2 = new System.Windows.Forms.PictureBox();
            this.show2 = new System.Windows.Forms.PictureBox();
            this.hide1 = new System.Windows.Forms.PictureBox();
            this.show1 = new System.Windows.Forms.PictureBox();
            this.con = new System.Windows.Forms.Label();
            this.recov = new System.Windows.Forms.Label();
            this.newpass = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.recoveryword = new System.Windows.Forms.TextBox();
            this.confirmnewpassword = new System.Windows.Forms.TextBox();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.username1 = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.wronguser1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.passmatch = new System.Windows.Forms.ErrorProvider(this.components);
            this.step1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wronguser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passmatch)).BeginInit();
            this.SuspendLayout();
            // 
            // resetpass
            // 
            this.resetpass.Location = new System.Drawing.Point(594, 406);
            this.resetpass.Name = "resetpass";
            this.resetpass.Size = new System.Drawing.Size(110, 30);
            this.resetpass.TabIndex = 29;
            this.resetpass.Text = "Reset";
            this.resetpass.UseVisualStyleBackColor = true;
            this.resetpass.Click += new System.EventHandler(this.resetpass_Click);
            // 
            // step1
            // 
            this.step1.BackColor = System.Drawing.Color.Transparent;
            this.step1.Controls.Add(this.hide2);
            this.step1.Controls.Add(this.show2);
            this.step1.Controls.Add(this.hide1);
            this.step1.Controls.Add(this.show1);
            this.step1.Controls.Add(this.con);
            this.step1.Controls.Add(this.recov);
            this.step1.Controls.Add(this.newpass);
            this.step1.Controls.Add(this.user);
            this.step1.Controls.Add(this.recoveryword);
            this.step1.Controls.Add(this.confirmnewpassword);
            this.step1.Controls.Add(this.newpassword);
            this.step1.Controls.Add(this.username1);
            this.step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.step1.Location = new System.Drawing.Point(96, 14);
            this.step1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.step1.Name = "step1";
            this.step1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.step1.Size = new System.Drawing.Size(608, 371);
            this.step1.TabIndex = 28;
            this.step1.TabStop = false;
            this.step1.Text = "Reset Password";
            // 
            // hide2
            // 
            this.hide2.BackColor = System.Drawing.Color.White;
            this.hide2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide2.BackgroundImage")));
            this.hide2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide2.Location = new System.Drawing.Point(469, 240);
            this.hide2.Name = "hide2";
            this.hide2.Size = new System.Drawing.Size(31, 27);
            this.hide2.TabIndex = 26;
            this.hide2.TabStop = false;
            this.hide2.Click += new System.EventHandler(this.hide2_Click);
            // 
            // show2
            // 
            this.show2.BackColor = System.Drawing.Color.White;
            this.show2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show2.BackgroundImage")));
            this.show2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show2.Location = new System.Drawing.Point(469, 240);
            this.show2.Name = "show2";
            this.show2.Size = new System.Drawing.Size(31, 27);
            this.show2.TabIndex = 25;
            this.show2.TabStop = false;
            this.show2.Click += new System.EventHandler(this.show2_Click);
            // 
            // hide1
            // 
            this.hide1.BackColor = System.Drawing.Color.White;
            this.hide1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide1.BackgroundImage")));
            this.hide1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide1.Location = new System.Drawing.Point(469, 199);
            this.hide1.Name = "hide1";
            this.hide1.Size = new System.Drawing.Size(31, 27);
            this.hide1.TabIndex = 24;
            this.hide1.TabStop = false;
            this.hide1.Click += new System.EventHandler(this.hide1_Click);
            // 
            // show1
            // 
            this.show1.BackColor = System.Drawing.Color.White;
            this.show1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show1.BackgroundImage")));
            this.show1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show1.Location = new System.Drawing.Point(469, 199);
            this.show1.Name = "show1";
            this.show1.Size = new System.Drawing.Size(31, 27);
            this.show1.TabIndex = 23;
            this.show1.TabStop = false;
            this.show1.Click += new System.EventHandler(this.show1_Click);
            // 
            // con
            // 
            this.con.AutoSize = true;
            this.con.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(211)))), ((int)(((byte)(190)))));
            this.con.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.con.Location = new System.Drawing.Point(110, 246);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(161, 20);
            this.con.TabIndex = 0;
            this.con.Text = "Confirm password";
            // 
            // recov
            // 
            this.recov.AutoSize = true;
            this.recov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(211)))), ((int)(((byte)(190)))));
            this.recov.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recov.Location = new System.Drawing.Point(110, 287);
            this.recov.Name = "recov";
            this.recov.Size = new System.Drawing.Size(133, 20);
            this.recov.TabIndex = 19;
            this.recov.Text = "Recovery word";
            // 
            // newpass
            // 
            this.newpass.AutoSize = true;
            this.newpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(211)))), ((int)(((byte)(190)))));
            this.newpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newpass.Location = new System.Drawing.Point(110, 204);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(133, 20);
            this.newpass.TabIndex = 1;
            this.newpass.Text = "New Password";
            this.newpass.Click += new System.EventHandler(this.newpass_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(211)))), ((int)(((byte)(190)))));
            this.user.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user.Location = new System.Drawing.Point(110, 163);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(94, 20);
            this.user.TabIndex = 2;
            this.user.Text = "Username";
            // 
            // recoveryword
            // 
            this.recoveryword.Location = new System.Drawing.Point(284, 281);
            this.recoveryword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recoveryword.Name = "recoveryword";
            this.recoveryword.Size = new System.Drawing.Size(216, 27);
            this.recoveryword.TabIndex = 15;
            // 
            // confirmnewpassword
            // 
            this.confirmnewpassword.Location = new System.Drawing.Point(284, 240);
            this.confirmnewpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmnewpassword.MaxLength = 25;
            this.confirmnewpassword.Name = "confirmnewpassword";
            this.confirmnewpassword.Size = new System.Drawing.Size(216, 27);
            this.confirmnewpassword.TabIndex = 14;
            this.confirmnewpassword.UseSystemPasswordChar = true;
            this.confirmnewpassword.TextChanged += new System.EventHandler(this.confirmnewpassword_TextChanged);
            // 
            // newpassword
            // 
            this.newpassword.Location = new System.Drawing.Point(284, 199);
            this.newpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newpassword.MaxLength = 25;
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(216, 27);
            this.newpassword.TabIndex = 13;
            this.newpassword.UseSystemPasswordChar = true;
            // 
            // username1
            // 
            this.username1.Location = new System.Drawing.Point(284, 158);
            this.username1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username1.MaxLength = 25;
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(216, 27);
            this.username1.TabIndex = 12;
            this.username1.TextChanged += new System.EventHandler(this.username1_TextChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(96, 406);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(110, 30);
            this.back.TabIndex = 30;
            this.back.TabStop = false;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // wronguser1
            // 
            this.wronguser1.ContainerControl = this;
            // 
            // passmatch
            // 
            this.passmatch.ContainerControl = this;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.resetpass);
            this.Controls.Add(this.step1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ForgotPass";
            this.Text = "ForgotPass";
            this.Load += new System.EventHandler(this.ForgotPass_Load);
            this.step1.ResumeLayout(false);
            this.step1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wronguser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passmatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button resetpass;
        private GroupBox step1;
        private PictureBox hide2;
        private PictureBox show2;
        private PictureBox hide1;
        private PictureBox show1;
        private Label con;
        private Label recov;
        private Label newpass;
        private Label user;
        private TextBox recoveryword;
        private TextBox confirmnewpassword;
        private TextBox newpassword;
        private TextBox username1;
        private Button back;
        private ErrorProvider wronguser1;
        private ErrorProvider passmatch;
    }
}