namespace Test_project
{
    partial class Createaccnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Createaccnt));
            this.step1 = new System.Windows.Forms.GroupBox();
            this.hide2 = new System.Windows.Forms.PictureBox();
            this.show2 = new System.Windows.Forms.PictureBox();
            this.hide1 = new System.Windows.Forms.PictureBox();
            this.first = new System.Windows.Forms.Label();
            this.show1 = new System.Windows.Forms.PictureBox();
            this.con = new System.Windows.Forms.Label();
            this.recov = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Label();
            this.recoveryword = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.username1 = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.usedusername = new System.Windows.Forms.ErrorProvider(this.components);
            this.wrongpass = new System.Windows.Forms.ErrorProvider(this.components);
            this.back = new System.Windows.Forms.Button();
            this.step1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedusername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongpass)).BeginInit();
            this.SuspendLayout();
            // 
            // step1
            // 
            this.step1.BackColor = System.Drawing.Color.Transparent;
            this.step1.Controls.Add(this.hide2);
            this.step1.Controls.Add(this.show2);
            this.step1.Controls.Add(this.hide1);
            this.step1.Controls.Add(this.first);
            this.step1.Controls.Add(this.show1);
            this.step1.Controls.Add(this.con);
            this.step1.Controls.Add(this.recov);
            this.step1.Controls.Add(this.pass);
            this.step1.Controls.Add(this.user);
            this.step1.Controls.Add(this.last);
            this.step1.Controls.Add(this.recoveryword);
            this.step1.Controls.Add(this.firstname);
            this.step1.Controls.Add(this.confirmpassword);
            this.step1.Controls.Add(this.lastname);
            this.step1.Controls.Add(this.password1);
            this.step1.Controls.Add(this.username1);
            this.step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.step1.Location = new System.Drawing.Point(96, 40);
            this.step1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.step1.Name = "step1";
            this.step1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.step1.Size = new System.Drawing.Size(608, 371);
            this.step1.TabIndex = 22;
            this.step1.TabStop = false;
            this.step1.Text = "Create Account";
            this.step1.Enter += new System.EventHandler(this.step1_Enter);
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
            this.hide1.Click += new System.EventHandler(this.hide_Click);
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(111, 80);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(99, 20);
            this.first.TabIndex = 5;
            this.first.Text = "First name";
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
            this.show1.Click += new System.EventHandler(this.show_Click);
            // 
            // con
            // 
            this.con.AutoSize = true;
            this.con.Location = new System.Drawing.Point(110, 245);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(161, 20);
            this.con.TabIndex = 0;
            this.con.Text = "Confirm password";
            // 
            // recov
            // 
            this.recov.AutoSize = true;
            this.recov.Location = new System.Drawing.Point(110, 286);
            this.recov.Name = "recov";
            this.recov.Size = new System.Drawing.Size(133, 20);
            this.recov.TabIndex = 19;
            this.recov.Text = "Recovery word";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(110, 203);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(91, 20);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(110, 162);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(94, 20);
            this.user.TabIndex = 2;
            this.user.Text = "Username";
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.Location = new System.Drawing.Point(111, 121);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(97, 20);
            this.last.TabIndex = 4;
            this.last.Text = "Last name";
            // 
            // recoveryword
            // 
            this.recoveryword.Location = new System.Drawing.Point(284, 281);
            this.recoveryword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recoveryword.Name = "recoveryword";
            this.recoveryword.Size = new System.Drawing.Size(216, 27);
            this.recoveryword.TabIndex = 15;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(284, 75);
            this.firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(216, 27);
            this.firstname.TabIndex = 9;
            // 
            // confirmpassword
            // 
            this.confirmpassword.Location = new System.Drawing.Point(284, 240);
            this.confirmpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmpassword.MaxLength = 25;
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(216, 27);
            this.confirmpassword.TabIndex = 14;
            this.confirmpassword.UseSystemPasswordChar = true;
            this.confirmpassword.TextChanged += new System.EventHandler(this.confirmpassword_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(284, 116);
            this.lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(216, 27);
            this.lastname.TabIndex = 10;
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(284, 199);
            this.password1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password1.MaxLength = 25;
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(216, 27);
            this.password1.TabIndex = 13;
            this.password1.UseSystemPasswordChar = true;
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
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(594, 432);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(110, 30);
            this.signup.TabIndex = 27;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.button1_Click);
            // 
            // usedusername
            // 
            this.usedusername.ContainerControl = this;
            // 
            // wrongpass
            // 
            this.wrongpass.ContainerControl = this;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(96, 432);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(110, 30);
            this.back.TabIndex = 31;
            this.back.TabStop = false;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Createaccnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.back);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.step1);
            this.Name = "Createaccnt";
            this.Text = "Create account";
            this.Load += new System.EventHandler(this.Createaccnt_Load);
            this.step1.ResumeLayout(false);
            this.step1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedusername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongpass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox step1;
        private Label first;
        private Label con;
        private Label recov;
        private Label pass;
        private Label user;
        private Label last;
        private TextBox recoveryword;
        private TextBox firstname;
        private TextBox confirmpassword;
        private TextBox lastname;
        private TextBox password1;
        private TextBox username1;
        private PictureBox hide1;
        private PictureBox show1;
        private PictureBox hide2;
        private PictureBox show2;
        private Button signup;
        private ErrorProvider usedusername;
        private ErrorProvider wrongpass;
        private Button back;
    }
}