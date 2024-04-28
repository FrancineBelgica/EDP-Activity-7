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

namespace CollegeInformationSystem
{
    public partial class DeleteStudent : Form
    {
        private DatabaseConnection databaseConnection;
        public DeleteStudent()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            string columnID = "student_id";
            string comboBoxQuery = "SELECT student_id, student_fname, student_lname FROM college.student;";
            databaseConnection.LoadDataIntoComboBox2(comboBoxQuery, comboBox1, columnID);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> selectedStudentId = (KeyValuePair<string, string>)comboBox1.SelectedItem;
            string id = selectedStudentId.Key;

            try
            {
                string primaryColumn = "student_id";
                string tableName = "student";
                string fnameInput = databaseConnection.GetData2(tableName, "student_fname", id, primaryColumn);
                string lnameInput = databaseConnection.GetData2(tableName, "student_lname", id, primaryColumn);
                string campusSelected = databaseConnection.GetData2(tableName, "campus_id", id, primaryColumn);
                string departmentSelected = databaseConnection.GetData2(tableName, "department_id", id, primaryColumn);
                string courseSelected = databaseConnection.GetData2(tableName, "course_id", id, primaryColumn);
                string gwa = databaseConnection.GetData2(tableName, "student_gwa", id, primaryColumn);

                string actionType = "Delete a Student";
                string description = $"Student record deleted: {fnameInput} {lnameInput} Campus: {campusSelected} Department: {departmentSelected} Course: {courseSelected} GWA: {gwa}";

                databaseConnection.InsertLog(actionType, description);

                databaseConnection.DeleteData("student", "student_id", id);
                MessageBox.Show("Deleted Successfully!");

                Dashboard dashboard = new Dashboard();

                this.Hide();

                dashboard.ShowDialog();

                this.Close();
            }
            catch
            {
                MessageBox.Show("There was an error deleting the student");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            this.Hide();

            dashboard.ShowDialog();

            this.Close();
        }

    }
}
