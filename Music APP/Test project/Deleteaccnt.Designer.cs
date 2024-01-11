namespace Test_project
{
    partial class Deleteaccnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deleteaccnt));
            this.cancel = new System.Windows.Forms.LinkLabel();
            this.Delete = new System.Windows.Forms.Button();
            this.step1 = new System.Windows.Forms.GroupBox();
            this.hide2 = new System.Windows.Forms.PictureBox();
            this.show2 = new System.Windows.Forms.PictureBox();
            this.pass = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.TextBox();
            this.username2 = new System.Windows.Forms.TextBox();
            this.wronguser = new System.Windows.Forms.ErrorProvider(this.components);
            this.step1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wronguser)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.LinkColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(96, 310);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(62, 23);
            this.cancel.TabIndex = 9;
            this.cancel.TabStop = true;
            this.cancel.Text = "Cancel";
            this.cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cancel_LinkClicked);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(594, 305);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(110, 30);
            this.Delete.TabIndex = 29;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // step1
            // 
            this.step1.BackColor = System.Drawing.Color.Transparent;
            this.step1.Controls.Add(this.hide2);
            this.step1.Controls.Add(this.show2);
            this.step1.Controls.Add(this.pass);
            this.step1.Controls.Add(this.user);
            this.step1.Controls.Add(this.password2);
            this.step1.Controls.Add(this.username2);
            this.step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.step1.Location = new System.Drawing.Point(96, 45);
            this.step1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.step1.Name = "step1";
            this.step1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.step1.Size = new System.Drawing.Size(608, 218);
            this.step1.TabIndex = 28;
            this.step1.TabStop = false;
            this.step1.Text = "Delete Account";
            // 
            // hide2
            // 
            this.hide2.BackColor = System.Drawing.Color.White;
            this.hide2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide2.BackgroundImage")));
            this.hide2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide2.Location = new System.Drawing.Point(479, 110);
            this.hide2.Name = "hide2";
            this.hide2.Size = new System.Drawing.Size(31, 27);
            this.hide2.TabIndex = 24;
            this.hide2.TabStop = false;
            this.hide2.Click += new System.EventHandler(this.hide1_Click);
            // 
            // show2
            // 
            this.show2.BackColor = System.Drawing.Color.White;
            this.show2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show2.BackgroundImage")));
            this.show2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show2.Location = new System.Drawing.Point(479, 110);
            this.show2.Name = "show2";
            this.show2.Size = new System.Drawing.Size(31, 27);
            this.show2.TabIndex = 23;
            this.show2.TabStop = false;
            this.show2.Click += new System.EventHandler(this.show2_Click);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(120, 115);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(91, 20);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(120, 74);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(94, 20);
            this.user.TabIndex = 2;
            this.user.Text = "Username";
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(294, 110);
            this.password2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password2.MaxLength = 25;
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(216, 27);
            this.password2.TabIndex = 13;
            this.password2.UseSystemPasswordChar = true;
            // 
            // username2
            // 
            this.username2.Location = new System.Drawing.Point(294, 69);
            this.username2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username2.MaxLength = 25;
            this.username2.Name = "username2";
            this.username2.Size = new System.Drawing.Size(216, 27);
            this.username2.TabIndex = 12;
            this.username2.TextChanged += new System.EventHandler(this.username1_TextChanged);
            // 
            // wronguser
            // 
            this.wronguser.ContainerControl = this;
            // 
            // Deleteaccnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Deleteaccnt";
            this.Text = "Deleteaccnt";
            this.Load += new System.EventHandler(this.Deleteaccnt_Load);
            this.step1.ResumeLayout(false);
            this.step1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wronguser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel cancel;
        private Button Delete;
        private GroupBox step1;
        private PictureBox hide2;
        private PictureBox show2;
        private Label pass;
        private Label user;
        private TextBox password2;
        private TextBox username2;
        private ErrorProvider wronguser;
    }
}