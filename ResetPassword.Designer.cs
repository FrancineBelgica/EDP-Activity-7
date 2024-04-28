namespace CollegeInformationSystem
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.reset_password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.RichTextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.confirm_password_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.login_link = new System.Windows.Forms.LinkLabel();
            this.register_link = new System.Windows.Forms.LinkLabel();
            this.password = new System.Windows.Forms.TextBox();
            this.confirm_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reset_password_label
            // 
            this.reset_password_label.AutoSize = true;
            this.reset_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset_password_label.Location = new System.Drawing.Point(505, 136);
            this.reset_password_label.Name = "reset_password_label";
            this.reset_password_label.Size = new System.Drawing.Size(271, 38);
            this.reset_password_label.TabIndex = 1;
            this.reset_password_label.Text = "Reset Password";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_label.Location = new System.Drawing.Point(482, 203);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(133, 22);
            this.email_label.TabIndex = 2;
            this.email_label.Text = "  Email address";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(495, 238);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(292, 33);
            this.email.TabIndex = 3;
            this.email.Text = "";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_label.Location = new System.Drawing.Point(482, 284);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(99, 22);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "  Password";
            // 
            // confirm_password_label
            // 
            this.confirm_password_label.AutoSize = true;
            this.confirm_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_password_label.Location = new System.Drawing.Point(482, 362);
            this.confirm_password_label.Name = "confirm_password_label";
            this.confirm_password_label.Size = new System.Drawing.Size(166, 22);
            this.confirm_password_label.TabIndex = 6;
            this.confirm_password_label.Text = "  Confirm Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.BackgroundImage = global::CollegeInformationSystem.Properties.Resources.bg_btn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(573, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_link
            // 
            this.login_link.AutoSize = true;
            this.login_link.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_link.LinkColor = System.Drawing.Color.Black;
            this.login_link.Location = new System.Drawing.Point(672, 74);
            this.login_link.Name = "login_link";
            this.login_link.Size = new System.Drawing.Size(61, 28);
            this.login_link.TabIndex = 9;
            this.login_link.TabStop = true;
            this.login_link.Text = "Login";
            this.login_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_link_LinkClicked);
            // 
            // register_link
            // 
            this.register_link.AutoSize = true;
            this.register_link.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.register_link.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.register_link.Location = new System.Drawing.Point(768, 74);
            this.register_link.Name = "register_link";
            this.register_link.Size = new System.Drawing.Size(82, 28);
            this.register_link.TabIndex = 10;
            this.register_link.TabStop = true;
            this.register_link.Text = "Register";
            this.register_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_link_LinkClicked);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(496, 317);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(291, 34);
            this.password.TabIndex = 11;
            // 
            // confirm_password
            // 
            this.confirm_password.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_password.Location = new System.Drawing.Point(496, 387);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.PasswordChar = '•';
            this.confirm_password.Size = new System.Drawing.Size(291, 34);
            this.confirm_password.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 421);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.confirm_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.register_link);
            this.Controls.Add(this.login_link);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirm_password_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.reset_password_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label reset_password_label;
        private Label email_label;
        private RichTextBox email;
        private Label password_label;
        private Label confirm_password_label;
        private Button button1;
        private LinkLabel login_link;
        private LinkLabel register_link;
        private TextBox password;
        private TextBox confirm_password;
        private PictureBox pictureBox1;
    }
}