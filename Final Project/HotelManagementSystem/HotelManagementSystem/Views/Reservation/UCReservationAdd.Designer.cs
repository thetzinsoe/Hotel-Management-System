namespace HotelManagementSystem.Views.Reservation
{
    partial class UCReservationAdd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCheckOutValidation = new System.Windows.Forms.Label();
            this.lbPhoneNumberValidation = new System.Windows.Forms.Label();
            this.lbRoomNoValidation = new System.Windows.Forms.Label();
            this.lbCheckInDateValidation = new System.Windows.Forms.Label();
            this.lbFullNameValidation = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.hdReservationId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.cbRoomNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Silver;
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Location = new System.Drawing.Point(0, 1);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1100, 62);
            this.pnTitle.TabIndex = 77;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(470, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(154, 30);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "RESERVATION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCheckOutValidation);
            this.groupBox1.Controls.Add(this.lbPhoneNumberValidation);
            this.groupBox1.Controls.Add(this.lbRoomNoValidation);
            this.groupBox1.Controls.Add(this.lbCheckInDateValidation);
            this.groupBox1.Controls.Add(this.lbFullNameValidation);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lb3);
            this.groupBox1.Controls.Add(this.hdReservationId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpCheckOutDate);
            this.groupBox1.Controls.Add(this.cbRoomNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.lblDob);
            this.groupBox1.Controls.Add(this.dtpCheckInDate);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 627);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Reservation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbCheckOutValidation
            // 
            this.lbCheckOutValidation.AutoSize = true;
            this.lbCheckOutValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckOutValidation.ForeColor = System.Drawing.Color.Red;
            this.lbCheckOutValidation.Location = new System.Drawing.Point(825, 380);
            this.lbCheckOutValidation.Name = "lbCheckOutValidation";
            this.lbCheckOutValidation.Size = new System.Drawing.Size(0, 15);
            this.lbCheckOutValidation.TabIndex = 112;
            // 
            // lbPhoneNumberValidation
            // 
            this.lbPhoneNumberValidation.AutoSize = true;
            this.lbPhoneNumberValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumberValidation.ForeColor = System.Drawing.Color.Red;
            this.lbPhoneNumberValidation.Location = new System.Drawing.Point(825, 218);
            this.lbPhoneNumberValidation.Name = "lbPhoneNumberValidation";
            this.lbPhoneNumberValidation.Size = new System.Drawing.Size(0, 15);
            this.lbPhoneNumberValidation.TabIndex = 111;
            // 
            // lbRoomNoValidation
            // 
            this.lbRoomNoValidation.AutoSize = true;
            this.lbRoomNoValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNoValidation.ForeColor = System.Drawing.Color.Red;
            this.lbRoomNoValidation.Location = new System.Drawing.Point(825, 275);
            this.lbRoomNoValidation.Name = "lbRoomNoValidation";
            this.lbRoomNoValidation.Size = new System.Drawing.Size(0, 15);
            this.lbRoomNoValidation.TabIndex = 110;
            // 
            // lbCheckInDateValidation
            // 
            this.lbCheckInDateValidation.AutoSize = true;
            this.lbCheckInDateValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckInDateValidation.ForeColor = System.Drawing.Color.Red;
            this.lbCheckInDateValidation.Location = new System.Drawing.Point(825, 329);
            this.lbCheckInDateValidation.Name = "lbCheckInDateValidation";
            this.lbCheckInDateValidation.Size = new System.Drawing.Size(0, 15);
            this.lbCheckInDateValidation.TabIndex = 109;
            // 
            // lbFullNameValidation
            // 
            this.lbFullNameValidation.AutoSize = true;
            this.lbFullNameValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lbFullNameValidation.Location = new System.Drawing.Point(825, 162);
            this.lbFullNameValidation.Name = "lbFullNameValidation";
            this.lbFullNameValidation.Size = new System.Drawing.Size(0, 15);
            this.lbFullNameValidation.TabIndex = 108;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(803, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 37);
            this.label11.TabIndex = 107;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(803, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 37);
            this.label10.TabIndex = 106;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(804, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 37);
            this.label9.TabIndex = 105;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(804, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 37);
            this.label8.TabIndex = 104;
            this.label8.Text = "*";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.Color.Red;
            this.lb3.Location = new System.Drawing.Point(803, 154);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(28, 37);
            this.lb3.TabIndex = 99;
            this.lb3.Text = "*";
            // 
            // hdReservationId
            // 
            this.hdReservationId.AutoSize = true;
            this.hdReservationId.Location = new System.Drawing.Point(301, 89);
            this.hdReservationId.Name = "hdReservationId";
            this.hdReservationId.Size = new System.Drawing.Size(0, 21);
            this.hdReservationId.TabIndex = 98;
            this.hdReservationId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(298, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 97;
            this.label2.Text = "CheckOut Date";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOutDate.Location = new System.Drawing.Point(422, 375);
            this.dtpCheckOutDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckOutDate.MaxDate = new System.DateTime(2024, 5, 13, 0, 0, 0, 0);
            this.dtpCheckOutDate.MinDate = new System.DateTime(2024, 4, 13, 0, 0, 0, 0);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(376, 26);
            this.dtpCheckOutDate.TabIndex = 96;
            this.dtpCheckOutDate.Value = new System.DateTime(2024, 4, 13, 0, 0, 0, 0);
            this.dtpCheckOutDate.ValueChanged += new System.EventHandler(this.dtpCheckOutDate_ValueChanged);
            // 
            // cbRoomNo
            // 
            this.cbRoomNo.DropDownWidth = 376;
            this.cbRoomNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomNo.Location = new System.Drawing.Point(422, 267);
            this.cbRoomNo.Name = "cbRoomNo";
            this.cbRoomNo.Size = new System.Drawing.Size(376, 29);
            this.cbRoomNo.TabIndex = 95;
            this.cbRoomNo.Text = "Choose Room";
            this.cbRoomNo.SelectedValueChanged += new System.EventHandler(this.cbRoomNo_SelectedValueChanged);
            this.cbRoomNo.TextChanged += new System.EventHandler(this.cbRoomNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 94;
            this.label1.Text = "Room No";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(422, 210);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.MaxLength = 15;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(376, 29);
            this.txtPhoneNumber.TabIndex = 93;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.ForeColor = System.Drawing.Color.Black;
            this.lblDob.Location = new System.Drawing.Point(298, 328);
            this.lblDob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(91, 19);
            this.lblDob.TabIndex = 91;
            this.lblDob.Text = "CheckIn Date";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInDate.Location = new System.Drawing.Point(422, 323);
            this.dtpCheckInDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckInDate.MaxDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.dtpCheckInDate.MinDate = new System.DateTime(2024, 4, 13, 22, 19, 19, 0);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(376, 26);
            this.dtpCheckInDate.TabIndex = 86;
            this.dtpCheckInDate.Value = new System.DateTime(2024, 4, 13, 22, 19, 19, 0);
            this.dtpCheckInDate.ValueChanged += new System.EventHandler(this.dtpCheckInDate_ValueChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(298, 215);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(102, 19);
            this.lblGender.TabIndex = 90;
            this.lblGender.Text = "Phone Number";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(685, 451);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 29);
            this.btnBack.TabIndex = 89;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(298, 159);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(73, 19);
            this.lblFullName.TabIndex = 84;
            this.lblFullName.Text = "Full Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(499, 451);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 29);
            this.btnDelete.TabIndex = 88;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(422, 154);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.MaxLength = 30;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(376, 29);
            this.txtFullName.TabIndex = 85;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(302, 451);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 29);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UCReservationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnTitle);
            this.Name = "UCReservationAdd";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.UCReservationAdd_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label hdReservationId;
        private System.Windows.Forms.Label lbCheckOutValidation;
        private System.Windows.Forms.Label lbPhoneNumberValidation;
        private System.Windows.Forms.Label lbRoomNoValidation;
        private System.Windows.Forms.Label lbCheckInDateValidation;
        private System.Windows.Forms.Label lbFullNameValidation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.ComboBox cbRoomNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnAdd;
    }
}
