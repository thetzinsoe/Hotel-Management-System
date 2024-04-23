﻿using System;
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
using HotelManagementSystem.Services.Employee;
using HotelManagementSystem.Services.Guest;
using Microsoft.Reporting.WinForms;
using HotelManagementSystem.Entities.Guest;
using ExcelDataReader;

namespace HotelManagementSystem.Views.Guest
{
    public partial class UCGuestList : UserControl
    {
        GuestService guestService = new GuestService();
        int pageSize = 10;
        int currentPageIndex = 1;
        int totalPage = 0;
        public UCGuestList()
        {
            InitializeComponent();
        }

        private void UCGuestList_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindReportViewer();
        }

        private void BindGrid()
        {
            DataTable dt = guestService.GetRecord(1,pageSize);
            DataTable dt1 = guestService.GetAll();
            int rowCount = dt1.Rows.Count;
            totalPage = rowCount / pageSize;
            if (rowCount % pageSize > 0)
            {
                totalPage += 1;
            }
            lblPageNo.Text = $"Page 1 of {totalPage}";
            dgvGuestList.AutoGenerateColumns = false;
            dgvGuestList.Columns["GuestId"].DataPropertyName = "guest_id";
            dgvGuestList.Columns["FullName"].DataPropertyName = "full_name";
            dgvGuestList.Columns["PhoneNumber"].DataPropertyName = "phone_number";
            dgvGuestList.Columns["Nationality"].DataPropertyName = "nationality";
            dgvGuestList.Columns["NRCNumber"].DataPropertyName = "nrc_number";
            dgvGuestList.Columns["Dob"].DataPropertyName = "dob";
            dgvGuestList.Columns["Gender"].DataPropertyName = "gender";
            dgvGuestList.Columns["Address"].DataPropertyName = "address";
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
                    success = guestService.Delete(guestId);
                    if (success)
                    {
                        MessageBox.Show("Delete Success", "Success", MessageBoxButtons.OK);
                        DataTable dt = guestService.GetRecord(currentPageIndex, pageSize);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = guestService.Search(txtSearch.Text.Trim());
            dgvGuestList.DataSource = dt;
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
            int prevPageIndex = this.currentPageIndex - 3;
            if (prevPageIndex > 1)
            {
                this.currentPageIndex = prevPageIndex;
            }
            else
            {
                this.currentPageIndex = 1;
            }
            DataTable dt = guestService.GetRecord(currentPageIndex, pageSize);
            this.dgvGuestList.DataSource = dt;
            lblPageNo.Text = $"Page {currentPageIndex} of {totalPage}";
        }

        private void btn3xNext_Click(object sender, EventArgs e)
        {
            int nextPageIndex = this.currentPageIndex + 3;
            if (nextPageIndex < totalPage)
            {
                this.currentPageIndex = nextPageIndex;
            }
            else
            {
                this.currentPageIndex = totalPage;
            }
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
                GuestEntity guestEntity = new GuestEntity()
                {

                    fullName = row["Full Name"].ToString(),
                    gender = Convert.ToInt16(row["Gender"]),
                    dob = (DateTime)row["Dob"],
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
                    MessageBox.Show("Error inserting data into the database.");
                    break;
                }
            }

            if (success)
            {
                MessageBox.Show("Data imported from Excel successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGrid();
            }
        }
    }
}
