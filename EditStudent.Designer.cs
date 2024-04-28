namespace CollegeInformationSystem
{
    partial class EditStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.select_student_combobox = new System.Windows.Forms.ComboBox();
            this.fname_label = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.select_campus_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.select_department_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.select_course_combobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gwa_input = new System.Windows.Forms.RichTextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit a Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "  Select Student";
            // 
            // select_student_combobox
            // 
            this.select_student_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_student_combobox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_student_combobox.FormattingEnabled = true;
            this.select_student_combobox.Location = new System.Drawing.Point(10, 99);
            this.select_student_combobox.Name = "select_student_combobox";
            this.select_student_combobox.Size = new System.Drawing.Size(253, 33);
            this.select_student_combobox.TabIndex = 8;
            this.select_student_combobox.SelectedIndexChanged += new System.EventHandler(this.select_student_combobox_SelectedIndexChanged);
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fname_label.Location = new System.Drawing.Point(257, 65);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(116, 28);
            this.fname_label.TabIndex = 11;
            this.fname_label.Text = "  First Name";
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fname.Location = new System.Drawing.Point(272, 99);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(253, 33);
            this.fname.TabIndex = 10;
            this.fname.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(522, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "  Last Name";
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lname.Location = new System.Drawing.Point(535, 99);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(253, 33);
            this.lname.TabIndex = 12;
            this.lname.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-4, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "  Select Campus";
            // 
            // select_campus_combobox
            // 
            this.select_campus_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_campus_combobox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_campus_combobox.FormattingEnabled = true;
            this.select_campus_combobox.Location = new System.Drawing.Point(10, 179);
            this.select_campus_combobox.Name = "select_campus_combobox";
            this.select_campus_combobox.Size = new System.Drawing.Size(363, 33);
            this.select_campus_combobox.TabIndex = 14;
            this.select_campus_combobox.SelectedIndexChanged += new System.EventHandler(this.select_campus_combobox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(411, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "  Select Department";
            // 
            // select_department_combobox
            // 
            this.select_department_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_department_combobox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_department_combobox.FormattingEnabled = true;
            this.select_department_combobox.Location = new System.Drawing.Point(425, 179);
            this.select_department_combobox.Name = "select_department_combobox";
            this.select_department_combobox.Size = new System.Drawing.Size(363, 33);
            this.select_department_combobox.TabIndex = 16;
            this.select_department_combobox.SelectedIndexChanged += new System.EventHandler(this.select_department_combobox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(-2, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "  Select Course";
            // 
            // select_course_combobox
            // 
            this.select_course_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_course_combobox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_course_combobox.FormattingEnabled = true;
            this.select_course_combobox.Location = new System.Drawing.Point(12, 260);
            this.select_course_combobox.Name = "select_course_combobox";
            this.select_course_combobox.Size = new System.Drawing.Size(363, 33);
            this.select_course_combobox.TabIndex = 18;
            this.select_course_combobox.SelectedIndexChanged += new System.EventHandler(this.select_course_combobox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(411, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "  General Weighted Average";
            // 
            // gwa_input
            // 
            this.gwa_input.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gwa_input.Location = new System.Drawing.Point(425, 257);
            this.gwa_input.Name = "gwa_input";
            this.gwa_input.Size = new System.Drawing.Size(358, 33);
            this.gwa_input.TabIndex = 20;
            this.gwa_input.Text = "";
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
            this.add_btn.Location = new System.Drawing.Point(666, 334);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(122, 45);
            this.add_btn.TabIndex = 22;
            this.add_btn.Text = "SAVE";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CollegeInformationSystem.Properties.Resources.bg_btn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(522, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gwa_input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.select_course_combobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.select_department_combobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.select_campus_combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.select_student_combobox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "EditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private ComboBox select_student_combobox;
        private Label fname_label;
        private RichTextBox fname;
        private Label label2;
        private RichTextBox lname;
        private Label label4;
        private ComboBox select_campus_combobox;
        private Label label5;
        private ComboBox select_department_combobox;
        private Label label6;
        private ComboBox select_course_combobox;
        private Label label7;
        private RichTextBox gwa_input;
        private Button add_btn;
        private Button button1;
    }
}