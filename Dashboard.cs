using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeInformationSystem;
using System.Data.Common;

namespace CollegeInformationSystem
{
    public partial class Dashboard : Form
    {
        private DatabaseConnection databaseConnection;
        public Dashboard()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string query = "SELECT\r\n    student.student_fname AS Firstname,\r\n    student.student_lname AS Lastname, \r\n    campus.campus_name AS Campus_Name,\r\n    department.department_name AS Department_Name,\r\n    course.course_name as Course,\r\n    course.course_total_units as Units,\r\n    student.student_gwa as GWA\r\nFROM college.student\r\nJOIN college.campus ON student.campus_id = campus.campus_id\r\nJOIN college.department ON student.department_id = department.department_id\r\nJOIN college.course ON student.course_id = course.course_id;\r\n";
            databaseConnection.GetData(query, dataGridView1);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Adjusted to AllCells
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns["gwa"].DefaultCellStyle.Format = "N1";
        }

        private void add_student_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            this.Hide();
            addStudent.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_form loginForm = new login_form();

            // Hide the current form (register form)
            this.Hide();

            // Show the login form
            loginForm.ShowDialog();

            // Close the current form after the login form is closed
            this.Close();
        }

        private void delete_student_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new DeleteStudent();

            // Hide the current form (register form)
            this.Hide();

            // Show the login form
            deleteStudent.ShowDialog();

            // Close the current form after the login form is closed
            this.Close();
        }

        private void generate_report_Click(object sender, EventArgs e)
        {
            ReportGeneration reportGeneration = new ReportGeneration();
            this.Hide();
            reportGeneration.ShowDialog();
            this.Close();
        }

        private void edit_student_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            this.Hide();
            editStudent.ShowDialog();
            this.Close();
        }
    }
}
