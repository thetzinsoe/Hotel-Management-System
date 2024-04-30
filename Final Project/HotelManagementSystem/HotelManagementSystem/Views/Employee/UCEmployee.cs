using System;
using HotelManagementSystem.Entities.Employee;
using HotelManagementSystem.Services.Employee;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HotelManagementSystem.Views.Employee
{
    public partial class UCEmployee : UserControl
    {
        public string ID
        { set { txtEmployeeId.Text = value; } }
        OpenFileDialog _openFileDialog = new OpenFileDialog();
        
        public UCEmployee()
        {
            InitializeComponent();
        }

        private void UCEmployee_Load(object sender, EventArgs e)
        {
            dtpDob.MaxDate = DateTime.Now;
            dtpJoinedDate.MaxDate = DateTime.Now;
            dtpDob.Value = DateTime.Today;
            dtpJoinedDate.Value = DateTime.Today;
            BtnControl();
            BindData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }            
            AddorUpdate();
        }

        private EmployeeEntity CreateData()
        {
            EmployeeEntity employeeEntity = new EmployeeEntity();
            short gender = 0;
            if (rdbOther.Checked)
            {
                gender = 0;
            }
            else if (rdbMale.Checked)
            {
                gender = 1;
            }
            else if (rdbFemale.Checked)
            {
                gender = 2;
            }
            string imagePath = "";
            if (!string.IsNullOrWhiteSpace(_openFileDialog.FileName))
            {
                imagePath = _openFileDialog.FileName;

            }
            if (!string.IsNullOrWhiteSpace(txtEmployeeId.Text))
            {
                employeeEntity.employeeId = Convert.ToInt32(txtEmployeeId.Text);
            }
            employeeEntity.fullName = txtFullName.Text;
            employeeEntity.phoneNumber = txtPhoneNumber.Text;
            employeeEntity.position = cbPosition.SelectedItem.ToString();
            employeeEntity.nrcNumber = txtNRCNumber.Text;
            employeeEntity.dob = dtpDob.Value;
            employeeEntity.gender = gender;
            employeeEntity.joinedDate = dtpJoinedDate.Value;
            employeeEntity.address = txtAddress.Text;
            employeeEntity.image = imagePath;
            employeeEntity.createdDateTime = DateTime.Now;
            employeeEntity.updatedDateTime = DateTime.Now;            
            return employeeEntity;
        }

        private void AddorUpdate()
        {
            UCEmployeeList uCEmployeeList = new UCEmployeeList();
            EmployeeService employeeService = new EmployeeService();
            EmployeeEntity employeeEntity = CreateData();
            bool success = false;
            if (String.IsNullOrEmpty(txtEmployeeId.Text))
            {
                success = employeeService.Insert(employeeEntity);
                if (success)
                {
                    MessageBox.Show("Save success", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error saving", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                success = employeeService.Update(employeeEntity);
                if (success)
                {
                    MessageBox.Show("Update success", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error updating", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            this.Controls.Clear();
            this.Controls.Add(uCEmployeeList);
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            _openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            _openFileDialog.Title = "Choose an Image";
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbImage.Image = System.Drawing.Image.FromFile(_openFileDialog.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }               
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            BtnControl();
        }

        private void ClearForm()
        {
            txtEmployeeId.Clear();
            txtFullName.Clear();
            txtPhoneNumber.Clear();
            txtNRCNumber.Clear();
            txtAddress.Clear();
            cbPosition.SelectedIndex = -1;
            dtpDob.Value = DateTime.Today;
            dtpJoinedDate.Value = DateTime.Today;
            rdbOther.Checked = false;
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            pbImage.Image = null;
            _openFileDialog.FileName = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            UCEmployeeList uCEmployeeList = new UCEmployeeList();
            int guestId = Convert.ToInt32(txtEmployeeId.Text);
            bool success = false;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                success = employeeService.Delete(guestId);
                if (success)
                {
                    MessageBox.Show("Delete success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Controls.Clear();
                this.Controls.Add(uCEmployeeList);
            }
        }

        private void BtnControl()
        {
            if (!String.IsNullOrEmpty(txtEmployeeId.Text))
            {
                btnAdd.Text = "UPDATE";
                btnDelete.Enabled = true;
            }
            else
            {
                btnAdd.Text = "ADD";
                btnDelete.Enabled = false;
                
            }
        }

        private void BindData()     
        {
            EmployeeService employeeService = new EmployeeService();
            if (!string.IsNullOrEmpty(txtEmployeeId.Text))
            {
                DataTable dt = employeeService.Get(Convert.ToInt32(txtEmployeeId.Text));
                txtFullName.Text = dt.Rows[0]["full_name"].ToString();
                txtPhoneNumber.Text = dt.Rows[0]["phone_number"].ToString();
                cbPosition.SelectedItem = dt.Rows[0]["position"].ToString();
                txtNRCNumber.Text = dt.Rows[0]["nrc_number"].ToString();
                dtpDob.Value = (DateTime)dt.Rows[0]["dob"];
                int gendervalue = Convert.ToInt32(dt.Rows[0]["gender"]);
                switch (gendervalue)
                {
                    case 0:
                        rdbOther.Checked = true;
                        break;

                    case 1:
                        rdbMale.Checked = true;
                        break;
                    case 2:
                        rdbFemale.Checked = true;
                        break;
                    default:
                        MessageBox.Show("Error assigning gendervalue");
                        break;
                }
                dtpJoinedDate.Value = (DateTime)dt.Rows[0]["joined_date"];
                txtAddress.Text = dt.Rows[0]["address"].ToString();
                string imagePath = dt.Rows[0]["image"].ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    pbImage.Image = System.Drawing.Image.FromFile(imagePath);
                }
                else
                {
                    pbImage.Image = null;
                }
                _openFileDialog.FileName = imagePath;
            }
        }
        private bool InputValidation()
        {
            EmployeeService employeeService = new EmployeeService();
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Please enter Full Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Text)) 
            {
                MessageBox.Show("Please enter Phone Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }
            if (cbPosition.SelectedItem == null)
            {
                MessageBox.Show("Please select Position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtNRCNumber.Text)) 
            {
                MessageBox.Show("Please enter NRC Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            if (!ValidateNRCNumber(txtNRCNumber.Text))
            {
                return false;
            }
            int age = Convert.ToInt32(DateTime.Today.Year - dtpDob.Value.Year);
            if (dtpDob.Value.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            if (age < 18 || age > 60)
            {
                MessageBox.Show("You need to be above 18 years old and under 60 years old", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            if (!rdbOther.Checked && !rdbMale.Checked && !rdbFemale.Checked)
            {
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DateTime minJoinedDate = dtpDob.Value.AddYears(18);
            if (dtpJoinedDate.Value.Date < minJoinedDate)
            {
                MessageBox.Show("Invalid Joined Date.Employee must be at least 18 years old to join.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtEmployeeId.Text))
            {
                if (employeeService.IsGuestValid(txtFullName.Text, txtNRCNumber.Text))
                {
                    MessageBox.Show("The Employee with this name and this NRC number is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (employeeService.IsNRCValid(txtFullName.Text, txtNRCNumber.Text))
                {
                    MessageBox.Show("This NRC number is already registered with different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            else if (!string.IsNullOrEmpty (txtEmployeeId.Text)) 
            {
                if (employeeService.IsGuestValidForUpdating(Convert.ToInt32(txtEmployeeId.Text), txtFullName.Text, txtNRCNumber.Text))
                {
                    MessageBox.Show("The Employee with this name and this NRC number is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (employeeService.IsNRCValidForUpdating(Convert.ToInt32(txtEmployeeId.Text), txtFullName.Text, txtNRCNumber.Text))
                {
                    MessageBox.Show("This NRC number is already registered with different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            
            return true;
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFullName.Text.Length >= 100 && e.KeyChar != '\b')
            {
                MessageBox.Show("Maximum character limit reached (100).","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPhoneNumber.Text.Length >= 50 && e.KeyChar != '\b')
            {
                MessageBox.Show("Maximum character limit reached (50).","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtNRCNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNRCNumber.Text.Length >= 50 && e.KeyChar != '\b')
            {
                MessageBox.Show("Maximum character limit reached (50).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAddress.Text.Length >= 255 && e.KeyChar != '\b')
            {
                MessageBox.Show("Maximum character limit reached (255).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UCEmployeeList uCEmployeeList = new UCEmployeeList();
            this.Controls.Clear();
            this.Controls.Add(uCEmployeeList);
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

    }
}
