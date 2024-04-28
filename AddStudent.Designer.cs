namespace CollegeInformationSystem
{
    partial class AddStudent
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
            this.fname = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.RichTextBox();
            this.select_campus_combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.select_department_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.select_course_combobox = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.gwa_label = new System.Windows.Forms.Label();
            this.gwa = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fname.Location = new System.Drawing.Point(26, 118);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(149, 33);
            this.fname.TabIndex = 0;
            this.fname.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a Student";
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fname_label.Location = new System.Drawing.Point(12, 87);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(116, 28);
            this.fname_label.TabIndex = 3;
            this.fname_label.Text = "  First Name";
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lname_label.Location = new System.Drawing.Point(200, 87);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(113, 28);
            this.lname_label.TabIndex = 5;
            this.lname_label.Text = "  Last Name";
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lname.Location = new System.Drawing.Point(213, 118);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(150, 33);
            this.lname.TabIndex = 4;
            this.lname.Text = "";
            // 
            // select_campus_combobox
            // 
            this.select_campus_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_campus_combobox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_campus_combobox.FormattingEnabled = true;
            this.select_campus_combobox.Location = new System.Drawing.Point(438, 118);
            this.select_campus_combobox.Name = "select_campus_combobox";
            this.select_campus_combobox.Size = new System.Drawing.Size(337, 33);
            this.select_campus_combobox.TabIndex = 6;
            this.select_campus_combobox.SelectedIndexChanged += new System.EventHandler(this.select_campus_combobox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(438, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "  Select Campus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "  Select Department";
            // 
            // select_department_combobox
            // 
            this.select_department_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_department_combobox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_department_combobox.FormattingEnabled = true;
            this.select_department_combobox.Location = new System.Drawing.Point(26, 208);
            this.select_department_combobox.Name = "select_department_combobox";
            this.select_department_combobox.Size = new System.Drawing.Size(337, 33);
            this.select_department_combobox.TabIndex = 8;
            this.select_department_combobox.SelectedIndexChanged += new System.EventHandler(this.select_department_combobox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(425, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "  Select Course";
            // 
            // select_course_combobox
            // 
            this.select_course_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_course_combobox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_course_combobox.FormattingEnabled = true;
            this.select_course_combobox.Location = new System.Drawing.Point(438, 208);
            this.select_course_combobox.Name = "select_course_combobox";
            this.select_course_combobox.Size = new System.Drawing.Size(337, 33);
            this.select_course_combobox.TabIndex = 10;
            // 
            // add_btn
            // 
            this.add_btn.BackgroundImage = global::CollegeInformationSystem.Properties.Resources.bg_btn;
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.Location = new System.Drawing.Point(653, 378);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(122, 45);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "SAVE";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackgroundImage = global::CollegeInformationSystem.Properties.Resources.bg_btn;
            this.cancel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_btn.Location = new System.Drawing.Point(509, 380);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(122, 45);
            this.cancel_btn.TabIndex = 13;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // gwa_label
            // 
            this.gwa_label.AutoSize = true;
            this.gwa_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gwa_label.Location = new System.Drawing.Point(372, 273);
            this.gwa_label.Name = "gwa_label";
            this.gwa_label.Size = new System.Drawing.Size(67, 28);
            this.gwa_label.TabIndex = 15;
            this.gwa_label.Text = "  GWA";
            // 
            // gwa
            // 
            this.gwa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gwa.Location = new System.Drawing.Point(336, 304);
            this.gwa.Name = "gwa";
            this.gwa.Size = new System.Drawing.Size(149, 33);
            this.gwa.TabIndex = 14;
            this.gwa.Text = "";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.gwa_label);
            this.Controls.Add(this.gwa);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.select_course_combobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.select_department_combobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.select_campus_combobox);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox fname;
        private Label label1;
        private Label fname_label;
        private Label lname_label;
        private RichTextBox lname;
        private ComboBox select_campus_combobox;
        private Label label3;
        private Label label4;
        private ComboBox select_department_combobox;
        private Label label5;
        private ComboBox select_course_combobox;
        private Button add_btn;
        private Button cancel_btn;
        private Label gwa_label;
        private RichTextBox gwa;
    }
}