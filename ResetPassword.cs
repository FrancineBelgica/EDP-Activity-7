using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeInformationSystem;

namespace CollegeInformationSystem
{
    public partial class ResetPassword : Form
    {
        private DatabaseConnection databaseConnection;
        public ResetPassword()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
        }

        private void login_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_form loginForm = new login_form();

            // Hide the current form (register form)
            this.Hide();

            // Show the login form
            loginForm.ShowDialog();

            // Close the current form after the login form is closed
            this.Close();
        }

        private void register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register_form register_form = new register_form();

            this.Hide();

            register_form.ShowDialog();

            // Close the current form after the login form is closed
            this.Close();
        }
        static bool IsValidEmail(string email)
        {
            // Define a regular expression for basic email validation
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            // Create a Regex object
            Regex regex = new Regex(emailPattern);

            // Use the Regex.IsMatch method to check if the email matches the pattern
            return regex.IsMatch(email);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConnection.Open();
                string emailText = email.Text;
                string passwordText = password.Text;
                string confirmPasswordText = confirm_password.Text;

                if (passwordText == confirmPasswordText)
                {
                    if (IsValidEmail(emailText))
                    {
                        string tableName = "users";
                        string[] columnNames = { "email", "password" };
                        string[] values = { emailText, passwordText };
                        string conditionColumn = "email";
                        string conditionValue = emailText;

                        databaseConnection.UpdateData(tableName, columnNames, values, conditionColumn, conditionValue);
                        MessageBox.Show("Password was reset successfully!");
                        login_form loginForm = new login_form();

                        // Hide the current form (register form)
                        this.Hide();

                        // Show the login form
                        loginForm.ShowDialog();

                        // Close the current form after the login form is closed
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email is invalid.");
                    }
                }
                else
                {
                    MessageBox.Show("Password do not match");
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

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

    }
}
