using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeInformationSystem;

namespace CollegeInformationSystem
{
    public partial class register_form : Form
    {
        private DatabaseConnection databaseConnection;

        public register_form()
        {
            InitializeComponent();

            // Create an instance of DatabaseConnection
            databaseConnection = new DatabaseConnection();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_form loginForm = new login_form();

            // Hide the current form (register form)
            this.Hide();

            // Show the login form
            loginForm.ShowDialog();

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

        private void register_btn_Click(object sender, EventArgs e)
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

                        databaseConnection.InsertData(tableName, columnNames, values);
                        MessageBox.Show("Registered Successfully!");

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

        private void register_form_Load(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true; // Hide password
            confirm_password.UseSystemPasswordChar = true; // Hide password
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Show")
            {
                button1.Text = "Hide";
                password.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                button1.Text = "Show";
                password.UseSystemPasswordChar = true; // Hide password
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Show")
            {
                button2.Text = "Hide";
                confirm_password.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                button2.Text = "Show";
                confirm_password.UseSystemPasswordChar = true; // Hide password
            }
        }

    }
}
