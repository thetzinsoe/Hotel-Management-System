using System.Drawing;
using System.Windows.Forms;

namespace HotelManagementSystem.Views.Guest
{
    partial class UCGuestCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblNRCNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtNRCNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGuestId = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbOther = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(39, 121);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(91, 23);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(204, 112);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(500, 34);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(204, 462);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(500, 34);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // lblNRCNumber
            // 
            this.lblNRCNumber.AutoSize = true;
            this.lblNRCNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRCNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNRCNumber.Location = new System.Drawing.Point(39, 400);
            this.lblNRCNumber.Name = "lblNRCNumber";
            this.lblNRCNumber.Size = new System.Drawing.Size(116, 23);
            this.lblNRCNumber.TabIndex = 2;
            this.lblNRCNumber.Text = "NRC Number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(204, 532);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(500, 34);
            this.txtPhoneNumber.TabIndex = 9;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.ForeColor = System.Drawing.Color.Black;
            this.lblNationality.Location = new System.Drawing.Point(39, 330);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(97, 23);
            this.lblNationality.TabIndex = 4;
            this.lblNationality.Text = "Nationality:";
            // 
            // txtNRCNumber
            // 
            this.txtNRCNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRCNumber.Location = new System.Drawing.Point(204, 391);
            this.txtNRCNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNRCNumber.Name = "txtNRCNumber";
            this.txtNRCNumber.Size = new System.Drawing.Size(500, 34);
            this.txtNRCNumber.TabIndex = 7;
            this.txtNRCNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNRCNumber_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(39, 470);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 23);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.Location = new System.Drawing.Point(204, 322);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(500, 34);
            this.txtNationality.TabIndex = 6;
            this.txtNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationality_KeyPress);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(39, 540);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(131, 23);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(43, 617);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 34);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(571, 617);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 34);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(310, 617);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 34);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.hdReservationId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGuestId);
            this.groupBox1.Controls.Add(this.lblDob);
            this.groupBox1.Controls.Add(this.dtpDob);
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.rdbOther);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.lblNRCNumber);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblNationality);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtNationality);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.txtNRCNumber);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1200, 850);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GUEST REGISTRATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(711, 540);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(711, 399);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(711, 330);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(711, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(711, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.guestCRUD;
            this.pictureBox1.Location = new System.Drawing.Point(736, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 539);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // txtGuestId
            // 
            this.txtGuestId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestId.Location = new System.Drawing.Point(204, 112);
            this.txtGuestId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGuestId.Name = "txtGuestId";
            this.txtGuestId.Size = new System.Drawing.Size(500, 34);
            this.txtGuestId.TabIndex = 36;
            this.txtGuestId.Visible = false;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.ForeColor = System.Drawing.Color.Black;
            this.lblDob.Location = new System.Drawing.Point(39, 260);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(111, 23);
            this.lblDob.TabIndex = 35;
            this.lblDob.Text = "Date of Birth:";
            // 
            // dtpDob
            // 
            this.dtpDob.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.Location = new System.Drawing.Point(204, 254);
            this.dtpDob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDob.MaxDate = new System.DateTime(2024, 4, 11, 0, 0, 0, 0);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(500, 26);
            this.dtpDob.TabIndex = 5;
            this.dtpDob.Value = new System.DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.Location = new System.Drawing.Point(389, 186);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(85, 27);
            this.rdbFemale.TabIndex = 4;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(300, 186);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(68, 27);
            this.rdbMale.TabIndex = 32;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbOther
            // 
            this.rdbOther.AutoSize = true;
            this.rdbOther.Checked = true;
            this.rdbOther.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOther.Location = new System.Drawing.Point(204, 186);
            this.rdbOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbOther.Name = "rdbOther";
            this.rdbOther.Size = new System.Drawing.Size(75, 27);
            this.rdbOther.TabIndex = 2;
            this.rdbOther.TabStop = true;
            this.rdbOther.Text = "Other";
            this.rdbOther.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(39, 190);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 23);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Gender:";
            // 
            // UCGuestCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCGuestCRUD";
            this.Size = new System.Drawing.Size(1200, 850);
            this.Load += new System.EventHandler(this.UCGuestCRUD_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblFullName;
        private TextBox txtFullName;
        private TextBox txtAddress;
        private Label lblNRCNumber;
        private TextBox txtPhoneNumber;
        private Label lblNationality;
        private TextBox txtNRCNumber;
        private Label lblAddress;
        private TextBox txtNationality;
        private Label lblPhoneNumber;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private GroupBox groupBox1;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private RadioButton rdbOther;
        private Label lblGender;
        private DateTimePicker dtpDob;
        private Label lblDob;
        private TextBox txtGuestId;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label hdReservationId;
    }
}
