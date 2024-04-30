using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Services.Guest;
using Microsoft.Reporting.WinForms;
using HotelManagementSystem.Entities.Guest;
using ExcelDataReader;
using HotelManagementSystem.Services.CheckIn;
using HotelManagementSystem.Views.CheckIn;
using System.Text.RegularExpressions;

namespace HotelManagementSystem.Views.Guest
{
    public partial class UCGuestList : UserControl
    {
        GuestService guestService = new GuestService();
        int pageSize = 10;
        int currentPageIndex = 1;
        int totalPage = 0;
        private string guest_name = string.Empty;
        private string guest_phone = string.Empty;
        public string ReservationID
        {
            set { hdReservationId.Text = value; }
        }
        public UCGuestList()
        {
            InitializeComponent();
        }
        public UCGuestList(string guestName, string guestPhone)
        {
            InitializeComponent();
            txtSearch.Text = guestName;
            guest_name = guestName;
            guest_phone = guestPhone;
        }
        private void UCGuestList_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindReportViewer();
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                SearchNameorNrc();
            }
            dgvGuestList.RowTemplate.MinimumHeight = 40;
        }

        private void BindGrid()
        {
            
            DataTable dt = guestService.GetRecord(1,pageSize);
            DataTable dt1 = guestService.GetAll();
            int rowCount = dt1.Rows.Count;
            currentPageIndex = 1;
            totalPage = rowCount / pageSize;
            if (rowCount % pageSize > 0)
            {
                totalPage += 1;
            }           
            lblPageNo.Text = $"Page 1 of {totalPage}";
            dgvGuestList.AutoGenerateColumns = false;           
            dgvGuestList.DataSource = dt;
        }

        private void dgvGuestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UCGuestCRUD uCGuestCRUD = new UCGuestCRUD();
            if (e.RowIndex > -1)
            {
                int guestId = Convert.ToInt32(dgvGuestList.Rows[e.RowIndex].Cells["GuestId"].Value);
                if(e.ColumnIndex == dgvGuestList.Columns["GuestId"].Index)
                {
                    uCGuestCRUD.ID = guestId.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(uCGuestCRUD);
                }

                if(e.ColumnIndex == dgvGuestList.Columns["Delete"].Index)
                {
                    bool success = false;
                    
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        success = guestService.Delete(guestId);
                        if (success)
                        {
                            DataTable dt1 = guestService.GetAll();
                            int rowCount = dt1.Rows.Count;
                            totalPage = rowCount / pageSize;
                            if (rowCount % pageSize > 0)
                            {
                                totalPage += 1;
                            }
                            MessageBox.Show("Delete Success", "Success", MessageBoxButtons.OK);
                            DataTable dt = guestService.GetRecord(currentPageIndex, pageSize);
                            if(dt.Rows.Count == 0 && currentPageIndex > 1)
                            {
                                currentPageIndex--;
                                dt = guestService.GetRecord(currentPageIndex, pageSize);
                            }

                            this.dgvGuestList.DataSource = dt;
                            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
                        }
                        else
                        {
                            MessageBox.Show("Error deleting", "Error", MessageBoxButtons.OK);
                        }
                    }
                }
            }             
        }

        private void dgvGuestList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvGuestList.Columns["Gender"].Index && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int gender)) 
                {
                    string gendertype = "";
                    if (gender == 0)
                    {
                        gendertype = "Other";
                    }
                    else if (gender == 1)
                    {
                        gendertype = "Male";
                    }
                    else if (gender ==2)
                    {
                        gendertype = "Female";
                    }
                    e.Value = gendertype;
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {           
            if (this.currentPageIndex > 1)
            {
                this.currentPageIndex--;
                DataTable dt = guestService.GetRecord(currentPageIndex, pageSize);
                this.dgvGuestList.DataSource = dt;
                lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.currentPageIndex < totalPage)
            {
                this.currentPageIndex++;
                DataTable dt = guestService.GetRecord(currentPageIndex, pageSize);
                this.dgvGuestList.DataSource = dt;
                lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
            }
        }

        private void btn3xPrevious_Click(object sender, EventArgs e)
        {
            this.currentPageIndex = 1;
            DataTable dt = guestService.GetRecord(currentPageIndex, pageSize);
            this.dgvGuestList.DataSource = dt;
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        }

        private void btn3xNext_Click(object sender, EventArgs e)
        {
            int lastPage = totalPage;
            this.currentPageIndex = lastPage;           
            DataTable dt = guestService.GetRecord(currentPageIndex, pageSize);
            this.dgvGuestList.DataSource= dt;
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
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
            saveFileDialog.FileName = "GuestReport";
            saveFileDialog.DefaultExt = ".xls";
            saveFileDialog.Filter = "Excel files (*.xls)|*.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
                MessageBox.Show("Guest Report downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BindReportViewer()
        {
            GuestService guestService = new GuestService();
            DataTable dt = guestService.GetAll();
            ReportDataSource dataSource = new ReportDataSource("DataSetGuest", dt);
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
            bool success = false;

            foreach (DataRow row in dataTable.Rows)
            {
                if (!ValidateExcelDataRow(row))
                {
                     return;
                }

                string gender = row["Gender"].ToString();
                short genderValue = 0;
                if (gender == "Other")
                {
                    genderValue = 0;
                }
                else if (gender == "Male")
                {
                    genderValue = 1;
                }
                else if (gender == "Female")
                {
                    genderValue = 2;
                }
                else
                {
                    MessageBox.Show("Please enter correctly in Gender column.(Other,Male,Female)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime dob = DateTime.Now;
                if (DateTime.TryParse(row["Date of Birth"].ToString(), out DateTime dobvalue))
                {
                    dob = dobvalue;
                }
                GuestEntity guestEntity = new GuestEntity()
                {

                    fullName = row["Full Name"].ToString(),
                    gender = genderValue,
                    dob = (DateTime)dob,
                    nationality = row["Nationality"].ToString(),
                    nrcNumber = row["NRC Number"].ToString(),
                    address = row["Address"].ToString(),
                    phoneNumber = row["Phone Number"].ToString(),
                    createdDate = DateTime.Now,
                    updatedDate= DateTime.Now,
                    is_deleted = 0
                };

                success = guestService.Insert(guestEntity);
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

        private bool ValidateExcelDataRow(DataRow row)
        {
            if (string.IsNullOrEmpty(row["Full Name"].ToString()))
            {
                MessageBox.Show("Please enter Full Name for all rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }          

            if (!IsValidDateOfBirth(row["Date of Birth"]))
            {
                MessageBox.Show("Please enter a valid Date of Birth for all rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(row["Nationality"].ToString()))
            {
                MessageBox.Show("Please enter Nationality for all rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(row["NRC Number"].ToString()))
            {
                MessageBox.Show("Please enter NRC Number for all rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateNRCNumber(row["NRC Number"].ToString()))
            {
                return false;
            }

            if (string.IsNullOrEmpty(row["Address"].ToString()))
            {
                MessageBox.Show("Please enter Address for all rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(row["Phone Number"].ToString()))
            {
                MessageBox.Show("Please enter Phone Number for all rows.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (guestService.IsGuestValid(row["Full Name"].ToString(), row["NRC Number"].ToString()))
            {
                MessageBox.Show("The Guest who is already registered is included in excel data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (guestService.IsNRCValid(row["Full Name"].ToString(), row["NRC Number"].ToString()))
            {
                MessageBox.Show("The NRC number that is already registered with different name is included in excel data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }       
        private bool IsValidDateOfBirth(object dob)
        {
            DateTime dobValue;
            if (DateTime.TryParse(dob.ToString(), out dobValue))
            {
                return dobValue.AddYears(18) < DateTime.Today;
            }
            return false;
        }

        private bool ValidateNRCNumber(string nrcNumber)
        {
            string nrcPattern = @"^\d+\/[\p{IsBasicLatin}\p{IsMyanmar}]+\([\p{IsBasicLatin}\p{IsMyanmar}]+\)\d{6}$"; ;

            if (!Regex.IsMatch(nrcNumber, nrcPattern))
            {
                MessageBox.Show("Incorrect NRC format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchNameorNrc();
        }

        private void SearchNameorNrc()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                if (cbSearch.SelectedIndex == 0 || cbSearch.SelectedIndex == -1)
                {
                    DataTable dt = guestService.Search(0, txtSearch.Text.Trim());
                    lblPageNo.Text = $"Page 1 of 1";
                    dgvGuestList.AutoGenerateColumns = false;
                    dgvGuestList.DataSource = dt;
                }
                else if (cbSearch.SelectedIndex == 1)
                {
                    DataTable dt = guestService.Search(1, txtSearch.Text.Trim());
                    lblPageNo.Text = $"Page 1 of 1";
                    dgvGuestList.AutoGenerateColumns = false;
                    dgvGuestList.DataSource = dt;
                }
            }
            else
            {
                BindGrid();
            }
        }
        private void btnCreateGuest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hdReservationId.Text))
            {
                UCGuestCRUD uCGuestCRUD = new UCGuestCRUD();
                this.Controls.Clear();
                this.Controls.Add(uCGuestCRUD);
            }
            else
            {
                UCGuestCRUD uCGuestCRUD = new UCGuestCRUD(guest_name, guest_phone);
                uCGuestCRUD.ReservationId = hdReservationId.Text;
                this.Controls.Clear();
                this.Controls.Add(uCGuestCRUD);
            }
        }

        private void btnGoToCheckin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (hdReservationId.Text))
            {
                if (dgvGuestList.RowCount > 0)
                {
                    if (dgvGuestList.SelectedCells.Count > 0)
                    {
                        int rowIndex = dgvGuestList.SelectedCells[0].RowIndex;
                        // string guestId = dgvGuestList.Rows[rowIndex].Cells["GuestId"].Value.ToString();
                        string guestNrc = dgvGuestList.Rows[rowIndex].Cells["NRCNumber"].Value.ToString();
                        UCCheckinAdd uCCheckinAdd = new UCCheckinAdd();
                        uCCheckinAdd.RvId = hdReservationId.Text;
                        uCCheckinAdd.Nrc = guestNrc;
                        this.Controls.Clear();
                        this.Controls.Add(uCCheckinAdd);
                        // MessageBox.Show("Guest ID: " + guestId+"  "+guestNrc);

                    }
                }
            }
            else
            {
                if (dgvGuestList.SelectedCells.Count > 0)
                {
                    int rowIndex = dgvGuestList.SelectedCells[0].RowIndex;
                    // string guestId = dgvGuestList.Rows[rowIndex].Cells["GuestId"].Value.ToString();
                    string guestNrc = dgvGuestList.Rows[rowIndex].Cells["NRCNumber"].Value.ToString();
                    UCCheckinAdd uCCheckinAdd = new UCCheckinAdd();
                    uCCheckinAdd.Nrc = guestNrc;
                    this.Controls.Clear();
                    this.Controls.Add(uCCheckinAdd);
                    // MessageBox.Show("Guest ID: " + guestId+"  "+guestNrc);

                }
            }

        }
     
    }
}
