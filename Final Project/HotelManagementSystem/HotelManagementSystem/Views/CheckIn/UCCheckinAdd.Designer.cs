﻿namespace HotelManagementSystem.Views.CheckIn
{
    partial class UCCheckinAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hdRoomId = new System.Windows.Forms.Label();
            this.hdCheckInId = new System.Windows.Forms.Label();
            this.lbGuestNrcValidation = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbGuestNameValidation = new System.Windows.Forms.Label();
            this.lbRoomNumberValidation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCheckOutValidation = new System.Windows.Forms.Label();
            this.lbCheckInDateValidation = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblDob = new System.Windows.Forms.Label();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.cbGuestNrc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRoomNumber = new System.Windows.Forms.ComboBox();
            this.cbGuestName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.hdReservationId = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Silver;
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1100, 62);
            this.pnTitle.TabIndex = 80;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(470, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(216, 30);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "ADD NEW CHECKIN ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 586);
            this.panel1.TabIndex = 81;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hdReservationId);
            this.groupBox1.Controls.Add(this.hdRoomId);
            this.groupBox1.Controls.Add(this.hdCheckInId);
            this.groupBox1.Controls.Add(this.lbGuestNrcValidation);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbGuestNameValidation);
            this.groupBox1.Controls.Add(this.lbRoomNumberValidation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbCheckOutValidation);
            this.groupBox1.Controls.Add(this.lbCheckInDateValidation);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpCheckOutDate);
            this.groupBox1.Controls.Add(this.lblDob);
            this.groupBox1.Controls.Add(this.dtpCheckInDate);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnCheckOut);
            this.groupBox1.Controls.Add(this.btnCheckIn);
            this.groupBox1.Controls.Add(this.cbGuestNrc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbRoomNumber);
            this.groupBox1.Controls.Add(this.cbGuestName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Checkin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // hdRoomId
            // 
            this.hdRoomId.AutoSize = true;
            this.hdRoomId.Location = new System.Drawing.Point(753, 42);
            this.hdRoomId.Name = "hdRoomId";
            this.hdRoomId.Size = new System.Drawing.Size(0, 25);
            this.hdRoomId.TabIndex = 150;
            // 
            // hdCheckInId
            // 
            this.hdCheckInId.AutoSize = true;
            this.hdCheckInId.Location = new System.Drawing.Point(376, 42);
            this.hdCheckInId.Name = "hdCheckInId";
            this.hdCheckInId.Size = new System.Drawing.Size(0, 25);
            this.hdCheckInId.TabIndex = 149;
            this.hdCheckInId.Visible = false;
            // 
            // lbGuestNrcValidation
            // 
            this.lbGuestNrcValidation.AutoSize = true;
            this.lbGuestNrcValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestNrcValidation.ForeColor = System.Drawing.Color.Red;
            this.lbGuestNrcValidation.Location = new System.Drawing.Point(788, 216);
            this.lbGuestNrcValidation.Name = "lbGuestNrcValidation";
            this.lbGuestNrcValidation.Size = new System.Drawing.Size(0, 15);
            this.lbGuestNrcValidation.TabIndex = 148;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(766, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 37);
            this.label12.TabIndex = 146;
            this.label12.Text = "*";
            // 
            // lbGuestNameValidation
            // 
            this.lbGuestNameValidation.AutoSize = true;
            this.lbGuestNameValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lbGuestNameValidation.Location = new System.Drawing.Point(788, 156);
            this.lbGuestNameValidation.Name = "lbGuestNameValidation";
            this.lbGuestNameValidation.Size = new System.Drawing.Size(0, 15);
            this.lbGuestNameValidation.TabIndex = 144;
            // 
            // lbRoomNumberValidation
            // 
            this.lbRoomNumberValidation.AutoSize = true;
            this.lbRoomNumberValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNumberValidation.ForeColor = System.Drawing.Color.Red;
            this.lbRoomNumberValidation.Location = new System.Drawing.Point(787, 103);
            this.lbRoomNumberValidation.Name = "lbRoomNumberValidation";
            this.lbRoomNumberValidation.Size = new System.Drawing.Size(0, 15);
            this.lbRoomNumberValidation.TabIndex = 143;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(766, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 37);
            this.label5.TabIndex = 142;
            this.label5.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(766, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 37);
            this.label7.TabIndex = 141;
            this.label7.Text = "*";
            // 
            // lbCheckOutValidation
            // 
            this.lbCheckOutValidation.AutoSize = true;
            this.lbCheckOutValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckOutValidation.ForeColor = System.Drawing.Color.Red;
            this.lbCheckOutValidation.Location = new System.Drawing.Point(787, 326);
            this.lbCheckOutValidation.Name = "lbCheckOutValidation";
            this.lbCheckOutValidation.Size = new System.Drawing.Size(0, 15);
            this.lbCheckOutValidation.TabIndex = 140;
            // 
            // lbCheckInDateValidation
            // 
            this.lbCheckInDateValidation.AutoSize = true;
            this.lbCheckInDateValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckInDateValidation.ForeColor = System.Drawing.Color.Red;
            this.lbCheckInDateValidation.Location = new System.Drawing.Point(786, 273);
            this.lbCheckInDateValidation.Name = "lbCheckInDateValidation";
            this.lbCheckInDateValidation.Size = new System.Drawing.Size(0, 15);
            this.lbCheckInDateValidation.TabIndex = 139;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(765, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 37);
            this.label11.TabIndex = 138;
            this.label11.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(765, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 37);
            this.label8.TabIndex = 137;
            this.label8.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(260, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 136;
            this.label2.Text = "CheckOut Date";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOutDate.Location = new System.Drawing.Point(384, 319);
            this.dtpCheckOutDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckOutDate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtpCheckOutDate.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(376, 26);
            this.dtpCheckOutDate.TabIndex = 135;
            this.dtpCheckOutDate.Value = new System.DateTime(2024, 4, 13, 0, 0, 0, 0);
            this.dtpCheckOutDate.ValueChanged += new System.EventHandler(this.dtpCheckOutDate_ValueChanged);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.ForeColor = System.Drawing.Color.Black;
            this.lblDob.Location = new System.Drawing.Point(260, 273);
            this.lblDob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(91, 19);
            this.lblDob.TabIndex = 134;
            this.lblDob.Text = "CheckIn Date";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInDate.Location = new System.Drawing.Point(384, 267);
            this.dtpCheckInDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckInDate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtpCheckInDate.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(376, 26);
            this.dtpCheckInDate.TabIndex = 130;
            this.dtpCheckInDate.Value = new System.DateTime(2024, 4, 17, 0, 0, 0, 0);
            this.dtpCheckInDate.ValueChanged += new System.EventHandler(this.dtpCheckInDate_ValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(647, 395);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 29);
            this.btnBack.TabIndex = 133;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.White;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.Location = new System.Drawing.Point(461, 395);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(113, 29);
            this.btnCheckOut.TabIndex = 132;
            this.btnCheckOut.Text = "CHECK OUT";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.White;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.Black;
            this.btnCheckIn.Location = new System.Drawing.Point(264, 395);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(113, 29);
            this.btnCheckIn.TabIndex = 131;
            this.btnCheckIn.Text = "CHECK IN";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbGuestNrc
            // 
            this.cbGuestNrc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGuestNrc.FormattingEnabled = true;
            this.cbGuestNrc.Location = new System.Drawing.Point(384, 209);
            this.cbGuestNrc.Name = "cbGuestNrc";
            this.cbGuestNrc.Size = new System.Drawing.Size(376, 29);
            this.cbGuestNrc.TabIndex = 129;
            this.cbGuestNrc.SelectedValueChanged += new System.EventHandler(this.cbGuestNrc_SelectedValueChanged);
            this.cbGuestNrc.TextChanged += new System.EventHandler(this.cbGuestNrc_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 128;
            this.label6.Text = "Guest NRC";
            // 
            // cbRoomNumber
            // 
            this.cbRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomNumber.FormattingEnabled = true;
            this.cbRoomNumber.Location = new System.Drawing.Point(384, 95);
            this.cbRoomNumber.Name = "cbRoomNumber";
            this.cbRoomNumber.Size = new System.Drawing.Size(376, 29);
            this.cbRoomNumber.TabIndex = 127;
            this.cbRoomNumber.SelectedValueChanged += new System.EventHandler(this.cbRoomNumber_SelectedValueChanged);
            this.cbRoomNumber.TextChanged += new System.EventHandler(this.cbRoomNumber_TextChanged);
            // 
            // cbGuestName
            // 
            this.cbGuestName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGuestName.FormattingEnabled = true;
            this.cbGuestName.Location = new System.Drawing.Point(384, 152);
            this.cbGuestName.Name = "cbGuestName";
            this.cbGuestName.Size = new System.Drawing.Size(376, 29);
            this.cbGuestName.TabIndex = 117;
            this.cbGuestName.SelectedValueChanged += new System.EventHandler(this.cbGuestName_SelectedValueChanged);
            this.cbGuestName.TextChanged += new System.EventHandler(this.cbGuestName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 116;
            this.label1.Text = "Guest Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(260, 100);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(99, 19);
            this.lblGender.TabIndex = 113;
            this.lblGender.Text = "Room Number";
            // 
            // hdReservationId
            // 
            this.hdReservationId.AutoSize = true;
            this.hdReservationId.Location = new System.Drawing.Point(574, 42);
            this.hdReservationId.Name = "hdReservationId";
            this.hdReservationId.Size = new System.Drawing.Size(0, 25);
            this.hdReservationId.TabIndex = 151;
            this.hdReservationId.Visible = false;
            // 
            // UCCheckinAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTitle);
            this.Name = "UCCheckinAdd";
            this.Size = new System.Drawing.Size(1100, 650);
            this.Load += new System.EventHandler(this.UCCheckinAdd_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGuestName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGuestNrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRoomNumber;
        private System.Windows.Forms.Label lbCheckOutValidation;
        private System.Windows.Forms.Label lbCheckInDateValidation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lbGuestNrcValidation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbGuestNameValidation;
        private System.Windows.Forms.Label lbRoomNumberValidation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label hdCheckInId;
        private System.Windows.Forms.Label hdRoomId;
        private System.Windows.Forms.Label hdReservationId;
    }
}
