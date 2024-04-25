using System;
using HotelManagementSystem.Services.Employee;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using HotelManagementSystem.Entities.Guest;
using HotelManagementSystem.Entities.Employee;
using ExcelDataReader;
using HotelManagementSystem.Services.Guest;
namespace HotelManagementSystem.Views.Employee
{
    public partial class UCEmployeeList : UserControl
    {
        int pageSize = 10;
        int currentPageIndex = 1;
        int totalPage = 0;
        public UCEmployeeList()
        {
            InitializeComponent();
        }

        private void UCEmployeeLIst_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindReportViewer();
        }

        private void BindGrid()
        {
            EmployeeService employeeService = new EmployeeService();
            DataTable dt = employeeService.GetRecord(1,pageSize);
            DataTable dt1 = employeeService.GetAll();
            int rowCount = dt1.Rows.Count;
            totalPage = rowCount/pageSize;
            if (rowCount % pageSize > 0)
            {
                totalPage += 1;
            }
            dgvEmployeeList.AutoGenerateColumns = false;
            AddImage(dt,"image");            
            dgvEmployeeList.DataSource = dt;
            
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        }

        private void dgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UCEmployee uCEmployee = new UCEmployee();
            if (e.RowIndex > -1)
            {
                int employeeId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells["EmployeeId"].Value);
                if (e.ColumnIndex == dgvEmployeeList.Columns["EmployeeId"].Index)
                {
                    uCEmployee.ID = employeeId.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(uCEmployee);
                }

                if (e.ColumnIndex == dgvEmployeeList.Columns["Delete"].Index)
                {
                    EmployeeService employeeService = new EmployeeService();
                    bool success = false;
                    success = employeeService.Delete(employeeId, 1);
                    if (success)
                    {
                        MessageBox.Show("Delete Success", "Success", MessageBoxButtons.OK);                      
                        DataTable dt = employeeService.GetRecord(currentPageIndex, pageSize);
                        AddImage(dt, "image");
                        this.dgvEmployeeList.DataSource = dt;
                        lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
                        
                    }
                    else
                    {
                        MessageBox.Show("Error deleting", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void dgvEmployeeList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvEmployeeList.Columns["Gender"].Index && e.Value != null)
            {
                string gender = "";
                int gendervalue = Convert.ToInt32(e.Value);
                switch (gendervalue)
                {
                    case 0:
                        gender = "Other";
                        break;
                    case 1:
                        gender = "Male";
                        break;
                    case 2:
                        gender = "Female";
                        break;
                    default:
                        MessageBox.Show("Error assigning gender", "Error", MessageBoxButtons.OK);
                        break;
                }
                e.Value = gender;
                e.FormattingApplied = true;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            if (this.currentPageIndex > 1)
            {
                this.currentPageIndex--;
                DataTable dt = employeeService.GetRecord(currentPageIndex, pageSize);
                AddImage(dt, "image");
                this.dgvEmployeeList.DataSource = dt;
                lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            if (this.currentPageIndex < totalPage)
            {
                this.currentPageIndex++;
                DataTable dt = employeeService.GetRecord(currentPageIndex, pageSize);
                AddImage(dt, "image");
                this.dgvEmployeeList.DataSource = dt;
                lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
            }
        }

        private void btn3xPrevious_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();

            int prevPageIndex = this.currentPageIndex - 3;
            if (prevPageIndex > 1)
            {
                this.currentPageIndex = prevPageIndex;
            }
            else
            {
                this.currentPageIndex = 1;
            }
            DataTable dt = employeeService.GetRecord(currentPageIndex, pageSize);
            AddImage(dt, "image");
            this.dgvEmployeeList.DataSource = dt;
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        }

        private void btn3xNext_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            int nextPageIndex = this.currentPageIndex + 3;
            if (nextPageIndex < totalPage)
            {
                this.currentPageIndex = nextPageIndex;
            }
            else
            {
                this.currentPageIndex = totalPage;
            }
            DataTable dt = employeeService.GetRecord(currentPageIndex, pageSize);
            AddImage(dt, "image");
            this.dgvEmployeeList.DataSource = dt;
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        }

        private void AddImage(DataTable dt, string imagePathColumnName)
        {
            dt.Columns.Add("photo", typeof(System.Drawing.Image));

            foreach (DataRow row in dt.Rows)
            {
                string imagePath = row[imagePathColumnName].ToString();
                System.Drawing.Image image = null;

                if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
                {
                    image = System.Drawing.Image.FromFile(imagePath);
                    row["photo"] = image;
                }
                else
                {
                    row["photo"] = DBNull.Value;
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Warning[] warnings;
            string[] streamIds;
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;

            byte[] bytes = reportViewer1.LocalReport.Render("Excel", null, out mimeType, out encoding, out extension, out streamIds, out warnings);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "EmployeeReport";
            saveFileDialog.DefaultExt = ".xls";
            saveFileDialog.Filter = "Excel files (*.xls)|*.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
                MessageBox.Show("Employee Report downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BindReportViewer()
        {
            EmployeeService employeeService = new EmployeeService();
            DataTable dt = employeeService.GetAll();
            ReportDataSource dataSource = new ReportDataSource("DataSetEmployee", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string strFileName;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strFileName = openFileDialog.FileName;

                if (!string.IsNullOrEmpty(strFileName))
                {
                    using (var stream = File.Open(strFileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var excelDataSetConfig = new ExcelDataSetConfiguration
                            {
                                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                                {
                                    UseHeaderRow = true
                                }
                            };
                            var excelData = reader.AsDataSet(excelDataSetConfig);
                            var dataTable = excelData.Tables[0];
                            InsertDataFromExcel(dataTable);
                        }
                    }
                }
            }
        }

        private void InsertDataFromExcel(DataTable dataTable)
        {
            EmployeeService employeeService = new EmployeeService();
            bool success = false;
            foreach (DataRow row in dataTable.Rows)
            {
                EmployeeEntity employeeEntity = new EmployeeEntity()
                {
                    fullName = row["Full Name"].ToString(),
                    phoneNumber = row["Phone Number"].ToString(),
                    position = row["Position"].ToString(),
                    nrcNumber = row["NRC Number"].ToString(),
                    dob = (DateTime)row["Dob"],
                    gender = Convert.ToInt16(row["Gender"]),
                    joinedDate = (DateTime)row["Joined Date"],
                    address = row["Address"].ToString(),
                    image = row["Image"].ToString(),
                    createdDateTime = DateTime.Now,
                    updatedDateTime = DateTime.Now,
                    is_deleted = 0
                };
                success = employeeService.Insert(employeeEntity);
                if (!success)
                {
                    MessageBox.Show("Error inserting data into the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            if (success)
            {
                MessageBox.Show("Data imported from Excel successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGrid();
            }           
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            UCEmployee uCEmployee = new UCEmployee();
            this.Controls.Clear();
            this.Controls.Add(uCEmployee);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                if (cbSearch.SelectedIndex == 0 || cbSearch.SelectedIndex == -1)
                {
                    DataTable dt = employeeService.Search(0, txtSearch.Text.Trim());
                    lblPageNo.Text = $"Page 1 of 1";
                    dgvEmployeeList.AutoGenerateColumns = false;
                    AddImage(dt, "image");
                    dgvEmployeeList.DataSource = dt;
                }
                else if (cbSearch.SelectedIndex == 1)
                {
                    DataTable dt = employeeService.Search(1, txtSearch.Text.Trim());
                    lblPageNo.Text = $"Page 1 of 1";
                    dgvEmployeeList.AutoGenerateColumns = false;
                    AddImage(dt, "image");
                    dgvEmployeeList.DataSource = dt;
                }
            }
            else
            {
                BindGrid();
            }
        }
    }
}
