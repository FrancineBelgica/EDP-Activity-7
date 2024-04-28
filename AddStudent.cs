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
using Microsoft.VisualBasic.Devices;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CollegeInformationSystem
{
    public partial class AddStudent : Form
    {
        private DatabaseConnection databaseConnection;
        public AddStudent()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            string columnID = "campus_id";
            string comboBoxQuery = "SELECT campus_id, campus_name FROM college.campus;";
            databaseConnection.LoadDataIntoComboBox(comboBoxQuery, select_campus_combobox, columnID);

        }

        private void select_campus_combobox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (select_campus_combobox.SelectedItem != null)
            {
                select_department_combobox.Items.Clear();
                // Retrieve the selected value
                KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)select_campus_combobox.SelectedItem;
                string selectedValue = selectedPair.Key;

                string columnID = "department_id";
                string comboBoxQuery = $"SELECT {columnID}, department_name FROM college.department WHERE campus_id = '{selectedValue}'";
                databaseConnection.LoadDataIntoComboBox(comboBoxQuery, select_department_combobox, columnID);

            }
        }

        private void select_department_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select_department_combobox.SelectedItem != null)
            {
                select_course_combobox.Items.Clear();
                // Retrieve the selected value
                KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)select_department_combobox.SelectedItem;
                string selectedValue = selectedPair.Key;

                string columnID = "course_id";
                string comboBoxQuery = $"SELECT {columnID}, course_name FROM college.course WHERE department_id = '{selectedValue}'";
                databaseConnection.LoadDataIntoComboBox(comboBoxQuery, select_course_combobox, columnID);

            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            this.Hide();

            dashboard.ShowDialog();

            // Close the current form after the login form is closed
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            try
            {
                databaseConnection.Open();
                string fnameInput = fname.Text;
                string lnameInput = lname.Text;
                string gwaInput = gwa.Text;

                KeyValuePair<string, string> selectedCampusObj = (KeyValuePair<string, string>)select_campus_combobox.SelectedItem;
                string selectedCampus = selectedCampusObj.Key;

                KeyValuePair<string, string> selectedDepartmentObj = (KeyValuePair<string, string>)select_department_combobox.SelectedItem;
                string selectedDepartment = selectedDepartmentObj.Key;

                KeyValuePair<string, string> selectedCourseObj = (KeyValuePair<string, string>)select_course_combobox.SelectedItem;
                string selectedCourse = selectedDepartmentObj.Key;

                if (string.IsNullOrEmpty(fnameInput) || string.IsNullOrEmpty(lnameInput) ||
                string.IsNullOrEmpty(selectedCampus) || string.IsNullOrEmpty(selectedDepartment) ||
                string.IsNullOrEmpty(selectedCourse))
                {

                    MessageBox.Show("All fields must be filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string tableName = "student";
                    string[] columnNames = { "campus_id", "department_id", "student_fname", "student_lname", "course_id", "student_gwa" };
                    string[] values = { selectedCampus, selectedDepartment, fnameInput, lnameInput, selectedCourse, gwaInput };

                    databaseConnection.InsertData(tableName, columnNames, values);

                    string actionType = "Add a Student";
                    string description = $"Student added: {fnameInput} {lnameInput} Campus: {selectedCampus} Department: {selectedDepartment} Course: {selectedCourse} GWA: {gwaInput}";

                    databaseConnection.InsertLog(actionType, description);

                    MessageBox.Show("Added Successfully!");


                    Dashboard dashboard = new Dashboard();

                    this.Hide();

                    dashboard.ShowDialog();

                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Make sure to close the database connection, whether the registration was successful or not
                databaseConnection.Close();
            }
        }

    }
}
