using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CollegeInformationSystem;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;

namespace CollegeInformationSystem
{
    public partial class ReportGeneration : Form
    {
        private DatabaseConnection databaseConnection;
        private SaveFileDialog saveFileDialog1; // Add this line

        public ReportGeneration()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
            saveFileDialog1 = new SaveFileDialog(); // Instantiate SaveFileDialog
        }

        private void ReportGeneration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            this.Hide();

            dashboard.ShowDialog();

            this.Close();
        }

        private void ReportGeneration_Load_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string query = "SELECT\r\n    student.student_fname AS Firstname,\r\n    student.student_lname AS Lastname, \r\n    campus.campus_name AS Campus_Name,\r\n    department.department_name AS Department_Name,\r\n    course.course_name as Course\r\n FROM college.student\r\nJOIN college.campus ON student.campus_id = campus.campus_id\r\nJOIN college.department ON student.department_id = department.department_id\r\nJOIN college.course ON student.course_id = course.course_id";
            databaseConnection.GetData(query, dataGridView1);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Adjusted to AllCells
            dataGridView1.ReadOnly = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set FillWeight for each column to ensure equal distribution of space
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1; // Equal proportion for each column
            }

            string queryzz = @"SELECT department.department_name AS Department, COUNT(*) AS NumberOfStudents
                   FROM college.student
                   JOIN college.department ON student.department_id = department.department_id
                   GROUP BY department.department_name";


            databaseConnection.PopulateChartFromQuery(queryzz, "StudentsPerDepartment", "Department", "NumberOfStudents", chart1);

            dataGridView2.Rows.Clear();
            string query2 = "SELECT\r\n    student.student_fname AS Firstname,\r\n    student.student_lname AS Lastname,\r\n    course.course_name AS Course,\r\n    course.course_total_units AS Units,\r\n    student.student_gwa as GWA\r\nFROM\r\n    college.student\r\nJOIN\r\n    college.campus ON student.campus_id = campus.campus_id\r\nJOIN\r\n    college.department ON student.department_id = department.department_id\r\nJOIN\r\n    college.course ON student.course_id = course.course_id;\r\n";
            databaseConnection.GetData(query2, dataGridView2); // Changed to dataGridView2
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Adjusted to AllCells
            dataGridView2.ReadOnly = true;
            dataGridView2.Columns["gwa"].DefaultCellStyle.Format = "N1";

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set FillWeight for each column to ensure equal distribution of space
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1; // Equal proportion for each column
            }

            string queryzzz = @"SELECT
                    department.department_name AS Department,
                    student.student_gwa AS GWA,
                    COUNT(*) AS Student_Count
                 FROM
                    college.student
                 JOIN
                    college.department ON student.department_id = department.department_id
                 GROUP BY
                    department.department_name, student.student_gwa";

            databaseConnection.PopulateChartFromQuery(queryzzz,"GWAPerDepartment" ,"Department", "Student_Count", chart2);

            dataGridView3.Rows.Clear();
            string query3 = "SELECT\r\n action_type as Action_Type,\r\n description as Description,\r\n timestamp as Timestamp\r\n FROM college.logs;";
            databaseConnection.GetData(query3, dataGridView3); // Changed to dataGridView2
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Adjusted to AllCells
            dataGridView3.ReadOnly = true;

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set FillWeight for each column to ensure equal distribution of space
            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1; // Equal proportion for each column
            }

            string queryzzzz = @"SELECT action_type AS Action_Type, COUNT(*) AS Count FROM college.logs GROUP BY action_type;"; ;

            databaseConnection.PopulateChartFromQuery(queryzzzz, "ActionTypeCount", "Action_Type", "Count", chart3);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void export_Click(object sender, EventArgs e)
        {
            
            ExportToExcel(dataGridView1, chart1, "Sheet1", "Sheet2");
            ExportToExcel(dataGridView2, chart2, "Sheet1", "Sheet2");
            ExportToExcel(dataGridView3, chart3, "Sheet1", "Sheet2");
        }

        private void ExportToExcel(DataGridView dataGridView, Chart chart, string dataGridViewSheetName, string chartSheetName)
        {
            // Create a new Excel package
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Export DataGridView to Sheet 1
                ExportDataGridViewToSheet(dataGridView, excelPackage, dataGridViewSheetName);

                // Export Chart to Sheet 2
                ExportChartToSheet(chart, excelPackage, chartSheetName);

                // Save the Excel package to a file
                saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;
                    excelPackage.SaveAs(new System.IO.FileInfo(filePath));
                    MessageBox.Show("Excel file saved successfully.");
                }
            }
        }

        private void ExportDataGridViewToSheet(DataGridView dataGridView, ExcelPackage excelPackage, string sheetName)
        {
            // Add a new worksheet to the Excel package
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

            // Add logo at the top
            var logo = worksheet.Drawings.AddPicture("Logo", new FileInfo("../../../assets/img/logo.png"));

            // Set position and size of the logo
            int logoLeftPosition = 0; // Left position
            int logoTopPosition = 0; // Top position
            int logoWidth = 200; // Width of the logo in pixels
            int logoHeight = 200; // Height of the logo in pixels

            logo.SetPosition(logoTopPosition, logoLeftPosition);
            logo.SetSize(logoWidth, logoHeight);

            worksheet.Cells[5, 4].Value = "Bicol University";
            worksheet.Cells[5, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            worksheet.Cells[6, 4].Value = "Legazpi City, 4502";
            worksheet.Cells[6, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            // Export DataGridView to the worksheet
            for (int i = 1; i <= dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[13, i].Value = dataGridView.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 14, j + 1].Value = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            // Add signatory author at the bottom
            string name = "Francine Belgica";
            worksheet.Cells[dataGridView.Rows.Count + 15, 4].Value = $"{name}";
            worksheet.Cells[dataGridView.Rows.Count + 16, 4].Value = $"Registrar, Bicol University";

            // Autofit columns for better readability
            worksheet.Cells.AutoFitColumns();
        }



        private void ExportChartToSheet(Chart chart, ExcelPackage excelPackage, string sheetName)
        {
            // Add a new worksheet to the Excel package
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

            // Check if chart contains data
            if (chart.Series.Count == 0)
            {
                MessageBox.Show("Chart does not contain any data.");
                return;
            }

            // Export chart as an image to a memory stream
            using (MemoryStream imageStream = new MemoryStream())
            {
                chart.SaveImage(imageStream, ChartImageFormat.Png);

                // Add the chart image to the worksheet
                ExcelPicture chartPicture = worksheet.Drawings.AddPicture("Chart", imageStream);
                chartPicture.SetPosition(0, 0);
            }
        }
    }
}
