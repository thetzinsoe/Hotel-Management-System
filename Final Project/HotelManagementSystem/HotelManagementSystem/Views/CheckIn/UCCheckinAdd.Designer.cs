namespace HotelManagementSystem.Views.CheckIn
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
            this.hdReservationId = new System.Windows.Forms.Label();
            this.hdGuestNrc = new System.Windows.Forms.Label();
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
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Silver;
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(5);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1100, 57);
            this.pnTitle.TabIndex = 80;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(470, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(277, 37);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "ADD NEW CHECKIN ";
            // 
            // hdReservationId
            // 
            this.hdReservationId.AutoSize = true;
            this.hdReservationId.Location = new System.Drawing.Point(569, 94);
            this.hdReservationId.Name = "hdReservationId";
            this.hdReservationId.Size = new System.Drawing.Size(0, 12);
            this.hdReservationId.TabIndex = 177;
            this.hdReservationId.Visible = false;
            // 
            // hdGuestNrc
            // 
            this.hdGuestNrc.AutoSize = true;
            this.hdGuestNrc.Location = new System.Drawing.Point(748, 94);
            this.hdGuestNrc.Name = "hdGuestNrc";
            this.hdGuestNrc.Size = new System.Drawing.Size(0, 12);
            this.hdGuestNrc.TabIndex = 176;
            this.hdGuestNrc.Visible = false;
            // 
            // hdCheckInId
            // 
            this.hdCheckInId.AutoSize = true;
            this.hdCheckInId.Location = new System.Drawing.Point(361, 94);
            this.hdCheckInId.Name = "hdCheckInId";
            this.hdCheckInId.Size = new System.Drawing.Size(0, 12);
            this.hdCheckInId.TabIndex = 175;
            this.hdCheckInId.Visible = false;
            // 
            // lbGuestNrcValidation
            // 
            this.lbGuestNrcValidation.AutoSize = true;
            this.lbGuestNrcValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestNrcValidation.ForeColor = System.Drawing.Color.Red;
            this.lbGuestNrcValidation.Location = new System.Drawing.Point(899, 255);
            this.lbGuestNrcValidation.Name = "lbGuestNrcValidation";
            this.lbGuestNrcValidation.Size = new System.Drawing.Size(0, 20);
            this.lbGuestNrcValidation.TabIndex = 174;
            this.lbGuestNrcValidation.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(763, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 37);
            this.label12.TabIndex = 173;
            this.label12.Text = "*";
            // 
            // lbGuestNameValidation
            // 
            this.lbGuestNameValidation.AutoSize = true;
            this.lbGuestNameValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lbGuestNameValidation.Location = new System.Drawing.Point(899, 199);
            this.lbGuestNameValidation.Name = "lbGuestNameValidation";
            this.lbGuestNameValidation.Size = new System.Drawing.Size(0, 20);
            this.lbGuestNameValidation.TabIndex = 172;
            this.lbGuestNameValidation.Visible = false;
            // 
            // lbRoomNumberValidation
            // 
            this.lbRoomNumberValidation.AutoSize = true;
            this.lbRoomNumberValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNumberValidation.ForeColor = System.Drawing.Color.Red;
            this.lbRoomNumberValidation.Location = new System.Drawing.Point(898, 150);
            this.lbRoomNumberValidation.Name = "lbRoomNumberValidation";
            this.lbRoomNumberValidation.Size = new System.Drawing.Size(0, 20);
            this.lbRoomNumberValidation.TabIndex = 171;
            this.lbRoomNumberValidation.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(763, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 37);
            this.label5.TabIndex = 170;
            this.label5.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(763, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 37);
            this.label7.TabIndex = 169;
            this.label7.Text = "*";
            // 
            // lbCheckOutValidation
            // 
            this.lbCheckOutValidation.AutoSize = true;
            this.lbCheckOutValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckOutValidation.ForeColor = System.Drawing.Color.Red;
            this.lbCheckOutValidation.Location = new System.Drawing.Point(898, 356);
            this.lbCheckOutValidation.Name = "lbCheckOutValidation";
            this.lbCheckOutValidation.Size = new System.Drawing.Size(0, 20);
            this.lbCheckOutValidation.TabIndex = 168;
            this.lbCheckOutValidation.Visible = false;
            // 
            // lbCheckInDateValidation
            // 
            this.lbCheckInDateValidation.AutoSize = true;
            this.lbCheckInDateValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckInDateValidation.ForeColor = System.Drawing.Color.Red;
            this.lbCheckInDateValidation.Location = new System.Drawing.Point(897, 307);
            this.lbCheckInDateValidation.Name = "lbCheckInDateValidation";
            this.lbCheckInDateValidation.Size = new System.Drawing.Size(0, 20);
            this.lbCheckInDateValidation.TabIndex = 167;
            this.lbCheckInDateValidation.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(762, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 37);
            this.label11.TabIndex = 166;
            this.label11.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(762, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 37);
            this.label8.TabIndex = 165;
            this.label8.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(202, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 164;
            this.label2.Text = "CheckOut Date :";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOutDate.Location = new System.Drawing.Point(367, 349);
            this.dtpCheckOutDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckOutDate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtpCheckOutDate.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(516, 34);
            this.dtpCheckOutDate.TabIndex = 163;
            this.dtpCheckOutDate.Value = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.dtpCheckOutDate.ValueChanged += new System.EventHandler(this.dtpCheckOutDate_ValueChanged);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.ForeColor = System.Drawing.Color.Black;
            this.lblDob.Location = new System.Drawing.Point(202, 307);
            this.lblDob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(135, 28);
            this.lblDob.TabIndex = 162;
            this.lblDob.Text = "CheckIn Date :";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInDate.Location = new System.Drawing.Point(367, 301);
            this.dtpCheckInDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckInDate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dtpCheckInDate.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(516, 34);
            this.dtpCheckInDate.TabIndex = 158;
            this.dtpCheckInDate.Value = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.dtpCheckInDate.ValueChanged += new System.EventHandler(this.dtpCheckInDate_ValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(642, 420);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 32);
            this.btnBack.TabIndex = 161;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(506, 420);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(113, 32);
            this.btnCheckOut.TabIndex = 160;
            this.btnCheckOut.Text = "CHECK OUT";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click_1);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(367, 420);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(113, 32);
            this.btnCheckIn.TabIndex = 159;
            this.btnCheckIn.Text = "CHECKIN";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // cbGuestNrc
            // 
            this.cbGuestNrc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGuestNrc.FormattingEnabled = true;
            this.cbGuestNrc.Location = new System.Drawing.Point(367, 248);
            this.cbGuestNrc.Name = "cbGuestNrc";
            this.cbGuestNrc.Size = new System.Drawing.Size(516, 36);
            this.cbGuestNrc.TabIndex = 157;
            this.cbGuestNrc.SelectedValueChanged += new System.EventHandler(this.cbGuestNrc_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 28);
            this.label6.TabIndex = 156;
            this.label6.Text = "Guest Nrc Number :";
            // 
            // cbRoomNumber
            // 
            this.cbRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomNumber.FormattingEnabled = true;
            this.cbRoomNumber.Location = new System.Drawing.Point(367, 143);
            this.cbRoomNumber.Name = "cbRoomNumber";
            this.cbRoomNumber.Size = new System.Drawing.Size(516, 36);
            this.cbRoomNumber.TabIndex = 155;
            this.cbRoomNumber.SelectedValueChanged += new System.EventHandler(this.cbRoomNumber_SelectedValueChanged);
            // 
            // cbGuestName
            // 
            this.cbGuestName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGuestName.FormattingEnabled = true;
            this.cbGuestName.Location = new System.Drawing.Point(367, 196);
            this.cbGuestName.Name = "cbGuestName";
            this.cbGuestName.Size = new System.Drawing.Size(516, 36);
            this.cbGuestName.TabIndex = 154;
            this.cbGuestName.SelectedValueChanged += new System.EventHandler(this.cbGuestName_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 153;
            this.label1.Text = "Guest Name :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(202, 148);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(150, 28);
            this.lblGender.TabIndex = 152;
            this.lblGender.Text = "Room Number :";
            // 
            // UCCheckinAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hdReservationId);
            this.Controls.Add(this.hdGuestNrc);
            this.Controls.Add(this.hdCheckInId);
            this.Controls.Add(this.lbGuestNrcValidation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbGuestNameValidation);
            this.Controls.Add(this.lbRoomNumberValidation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbCheckOutValidation);
            this.Controls.Add(this.lbCheckInDateValidation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCheckOutDate);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.dtpCheckInDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.cbGuestNrc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbRoomNumber);
            this.Controls.Add(this.cbGuestName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.pnTitle);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCCheckinAdd";
            this.Size = new System.Drawing.Size(1100, 600);
            this.Load += new System.EventHandler(this.UCCheckinAdd_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label hdReservationId;
        private System.Windows.Forms.Label hdGuestNrc;
        private System.Windows.Forms.Label hdCheckInId;
        private System.Windows.Forms.Label lbGuestNrcValidation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbGuestNameValidation;
        private System.Windows.Forms.Label lbRoomNumberValidation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.ComboBox cbGuestNrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRoomNumber;
        private System.Windows.Forms.ComboBox cbGuestName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGender;
    }
}
