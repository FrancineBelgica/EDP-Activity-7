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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollegeInformationSystem
{
    public partial class EditStudent : Form
    {
        private DatabaseConnection databaseConnection;
        public EditStudent()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            this.Hide();

            dashboard.ShowDialog();

            // Close the current form after the login form is closed
            this.Close();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            string columnID = "student_id";
            string comboBoxQuery = "SELECT student_id, student_fname, student_lname FROM college.student;";
            databaseConnection.LoadDataIntoComboBox2(comboBoxQuery, select_student_combobox, columnID);
        }

        private void select_student_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, string> selectedStudentId = (KeyValuePair<string, string>)select_student_combobox.SelectedItem;
            string id = selectedStudentId.Key;
            string primaryColumn = "student_id";
            string tableName = "student";
            string fnameInput = databaseConnection.GetData2(tableName, "student_fname", id, primaryColumn);
            string lnameInput = databaseConnection.GetData2(tableName, "student_lname", id, primaryColumn);
            string campusSelected = databaseConnection.GetData2(tableName, "campus_id", id, primaryColumn);
            string departmentSelected = databaseConnection.GetData2(tableName, "department_id", id, primaryColumn);
            string courseSelected = databaseConnection.GetData2(tableName, "course_id", id, primaryColumn);
            string gwa = databaseConnection.GetData2(tableName, "student_gwa", id, primaryColumn);

            fname.Text = fnameInput;
            lname.Text = lnameInput;
            gwa_input.Text = gwa;

            select_campus_combobox.Items.Clear();
            string query1 = "SELECT campus_id, campus_name FROM college.campus;";
            databaseConnection.LoadDataIntoComboBox(query1, select_campus_combobox, "campus_id");

            foreach (var item in select_campus_combobox.Items)
            {
                var keyProperty = item.GetType().GetProperty("Key");

                if (keyProperty != null)
                {
                    object keyValue = keyProperty.GetValue(item);

                    // Compare the "Key" value with courseSelected
                    if (keyValue != null && keyValue.ToString() == campusSelected)
                    {
                        // Set the selected index based on the match
                        select_campus_combobox.SelectedItem = item;

                        break; // Exit the loop once a match is found
                    }
                }
            }


            if (select_campus_combobox.SelectedItem != null)
            {
                select_department_combobox.Items.Clear();
                // Retrieve the selected value
                KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)select_campus_combobox.SelectedItem;
                string selectedValue = selectedPair.Key;

                string columnID = "department_id";
                string comboBoxQuery = $"SELECT {columnID}, department_name FROM college.department WHERE campus_id = '{selectedValue}'";
                databaseConnection.LoadDataIntoComboBox(comboBoxQuery, select_department_combobox, columnID);

                foreach (var item in select_department_combobox.Items)
                {
                    var keyProperty = item.GetType().GetProperty("Key");

                    // MessageBox.Show($"Key Value: {keyProperty}", "Key Property Value");
                    if (keyProperty != null)
                    {
                        object keyValue = keyProperty.GetValue(item);


                        // Compare the "Key" value with courseSelected
                        if (keyValue != null && keyValue.ToString() == departmentSelected)
                        {
                            // Set the selected index based on the match
                            select_department_combobox.SelectedItem = item;

                            break; // Exit the loop once a match is found
                        }
                    }
                }

            }

            if (select_department_combobox.SelectedItem != null)
            {
                select_course_combobox.Items.Clear();
                // Retrieve the selected value
                KeyValuePair<string, string> selectedPair = (KeyValuePair<string, string>)select_department_combobox.SelectedItem;
                string selectedValue = selectedPair.Key;

                string columnID = "course_id";
                string comboBoxQuery = $"SELECT {columnID}, course_name FROM college.course WHERE department_id = '{selectedValue}'";
                databaseConnection.LoadDataIntoComboBox(comboBoxQuery, select_course_combobox, columnID);

                foreach (var item in select_course_combobox.Items)
                {
                    var keyProperty = item.GetType().GetProperty("Key");

                    if (keyProperty != null)
                    {
                        object keyValue = keyProperty.GetValue(item);

                        // Compare the "Key" value with courseSelected
                        if (keyValue != null && keyValue.ToString() == courseSelected)
                        {
                            // Set the selected index based on the match
                            select_course_combobox.SelectedItem = item;

                            break; // Exit the loop once a match is found
                        }
                    }
                }

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

        private void select_campus_combobox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void select_course_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = select_course_combobox.SelectedItem;

            // Check if the selected item is not null
            if (selectedItem != null)
            {
                // Get the type of the selected item
                Type itemType = selectedItem.GetType();

                // Find and display the value of the "Key" property
                var keyProperty = itemType.GetProperty("Key");

                if (keyProperty != null)
                {
                    object keyValue = keyProperty.GetValue(selectedItem);
                    //MessageBox.Show($"Key Value: {keyValue}", "Property Value");
                }

            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConnection.Open();
                KeyValuePair<string, string> selectedStudentId = (KeyValuePair<string, string>)select_student_combobox.SelectedItem;
                string id = selectedStudentId.Key;
                string fnameInput = fname.Text;
                string lnameInput = lname.Text;
                string gwaInput = gwa_input.Text;

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

                    databaseConnection.UpdateData2(tableName, columnNames, values, "student_id", id);
                    MessageBox.Show("Updated Successfully!");

                    string actionType = "Edit a Student";
                    string description = $"Student updated: {fnameInput} {lnameInput} Campus: {selectedCampus} Department: {selectedDepartment} Course: {selectedCourse} GWA: {gwaInput}";

                    databaseConnection.InsertLog(actionType, description);

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
