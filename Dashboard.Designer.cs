namespace CollegeInformationSystem
{
    partial class Dashboard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.edit_student = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.generate_report = new System.Windows.Forms.Button();
            this.add_student = new System.Windows.Forms.Button();
            this.delete_student = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(719, 299);
            this.dataGridView1.TabIndex = 2;
            // 
            // edit_student
            // 
            this.edit_student.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.edit_student.BackgroundImage = global::CollegeInformationSystem.Properties.Resources.bg_btn;
            this.edit_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_student.FlatAppearance.BorderSize = 0;
            this.edit_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit_student.ForeColor = System.Drawing.Color.White;
            this.edit_student.Location = new System.Drawing.Point(166, 376);
            this.edit_student.Name = "edit_student";
            this.edit_student.Size = new System.Drawing.Size(125, 45);
            this.edit_student.TabIndex = 3;
            this.edit_student.Text = "EDIT A STUDENT";
            this.edit_student.UseVisualStyleBackColor = false;
            this.edit_student.Click += new System.EventHandler(this.edit_student_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hello, Admin!";
            // 
            // generate_report
            // 
            this.generate_report.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.generate_report.BackgroundImage = global::CollegeInformationSystem.Properties.Resources.bg_btn;
            this.generate_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generate_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate_report.FlatAppearance.BorderSize = 0;
            this.generate_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generate_report.ForeColor = System.Drawing.Color.White;
            this.generate_report.Location = new System.Drawing.Point(629, 10);
            this.generate_report.Name = "generate_report";
            this.generate_report.Size = new System.Drawing.Size(125, 45);
            this.generate_report.TabIndex = 5;
            this.generate_report.Text = "GENERATE REPORT";
            this.generate_report.UseVisualStyleBackColor = false;
            this.generate_report.Click += new System.EventHandler(this.generate_report_Click);
            // 
            // add_student
            // 
            this.add_student.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.add_student.BackgroundImage = global::CollegeInformationSystem.Properties.Resources.bg_btn;
            this.add_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_student.FlatAppearance.BorderSize = 0;
            this.add_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_student.ForeColor = System.Drawing.Color.White;
            this.add_student.Location = new System.Drawing.Point(35, 376);
            this.add_student.Name = "add_student";
            this.add_student.Size = new System.Drawing.Size(125, 45);
            this.add_student.TabIndex = 6;
            this.add_student.Text = "ADD A STUDENT";
            this.add_student.UseVisualStyleBackColor = false;
            this.add_student.Click += new System.EventHandler(this.add_student_Click);
            // 
            // delete_student
            // 
            this.delete_student.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.delete_student.BackgroundImage = global::CollegeInformationSystem.Properties.Resources.bg_btn;
            this.delete_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_student.FlatAppearance.BorderSize = 0;
            this.delete_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_student.ForeColor = System.Drawing.Color.White;
            this.delete_student.Location = new System.Drawing.Point(297, 376);
            this.delete_student.Name = "delete_student";
            this.delete_student.Size = new System.Drawing.Size(125, 45);
            this.delete_student.TabIndex = 7;
            this.delete_student.Text = "DELETE A STUDENT";
            this.delete_student.UseVisualStyleBackColor = false;
            this.delete_student.Click += new System.EventHandler(this.delete_student_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.BackgroundImage = global::CollegeInformationSystem.Properties.Resources.bg_btn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(629, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_student);
            this.Controls.Add(this.add_student);
            this.Controls.Add(this.generate_report);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_student);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private Button edit_student;
        private Label label1;
        private Button generate_report;
        private Button add_student;
        private Button delete_student;
        private Button button1;
    }
}