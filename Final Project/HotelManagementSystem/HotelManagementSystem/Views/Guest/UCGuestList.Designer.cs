namespace HotelManagementSystem.Views.Guest
{
    partial class UCGuestList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGuestList = new System.Windows.Forms.DataGridView();
            this.GuestId = new System.Windows.Forms.DataGridViewLinkColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRCNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn3xPrevious = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPageNo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btn3xNext = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnCreateGuest = new System.Windows.Forms.Button();
            this.hdReservationId = new System.Windows.Forms.Label();
            this.btnGoToCheckin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestList)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGuestList
            // 
            this.dgvGuestList.AllowUserToAddRows = false;
            this.dgvGuestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuestList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuestList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvGuestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestId,
            this.FullName,
            this.PhoneNumber,
            this.Nationality,
            this.NRCNumber,
            this.Dob,
            this.Gender,
            this.Address,
            this.Delete});
            this.dgvGuestList.Location = new System.Drawing.Point(29, 250);
            this.dgvGuestList.Name = "dgvGuestList";
            this.dgvGuestList.RowHeadersVisible = false;
            this.dgvGuestList.RowHeadersWidth = 51;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGuestList.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvGuestList.RowTemplate.Height = 24;
            this.dgvGuestList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGuestList.Size = new System.Drawing.Size(1417, 341);
            this.dgvGuestList.TabIndex = 0;
            this.dgvGuestList.VirtualMode = true;
            this.dgvGuestList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuestList_CellContentClick);
            this.dgvGuestList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGuestList_CellFormatting);
            // 
            // GuestId
            // 
            this.GuestId.DataPropertyName = "guest_id";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GuestId.DefaultCellStyle = dataGridViewCellStyle26;
            this.GuestId.HeaderText = "ID";
            this.GuestId.MinimumWidth = 6;
            this.GuestId.Name = "GuestId";
            this.GuestId.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "full_name";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "phone_number";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nationality
            // 
            this.Nationality.DataPropertyName = "nationality";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nationality.DefaultCellStyle = dataGridViewCellStyle27;
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.MinimumWidth = 6;
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            // 
            // NRCNumber
            // 
            this.NRCNumber.DataPropertyName = "nrc_number";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NRCNumber.DefaultCellStyle = dataGridViewCellStyle28;
            this.NRCNumber.HeaderText = "NRC Number";
            this.NRCNumber.MinimumWidth = 6;
            this.NRCNumber.Name = "NRCNumber";
            this.NRCNumber.ReadOnly = true;
            // 
            // Dob
            // 
            this.Dob.DataPropertyName = "dob";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dob.DefaultCellStyle = dataGridViewCellStyle29;
            this.Dob.HeaderText = "Date of Birth";
            this.Dob.MinimumWidth = 6;
            this.Dob.Name = "Dob";
            this.Dob.ReadOnly = true;
            this.Dob.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "gender";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Gender.DefaultCellStyle = dataGridViewCellStyle30;
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.NullValue = "Delete";
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle31;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(29, 180);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1152, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(412, 100);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(210, 35);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "IMPORT EXCEL DATA";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1467, 75);
            this.pnTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(652, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GUEST LIST";
            // 
            // btn3xPrevious
            // 
            this.btn3xPrevious.BackColor = System.Drawing.Color.SteelBlue;
            this.btn3xPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3xPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3xPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3xPrevious.ForeColor = System.Drawing.Color.White;
            this.btn3xPrevious.Location = new System.Drawing.Point(423, 722);
            this.btn3xPrevious.Name = "btn3xPrevious";
            this.btn3xPrevious.Size = new System.Drawing.Size(60, 35);
            this.btn3xPrevious.TabIndex = 5;
            this.btn3xPrevious.Text = "<<";
            this.btn3xPrevious.UseVisualStyleBackColor = false;
            this.btn3xPrevious.Click += new System.EventHandler(this.btn3xPrevious_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(521, 722);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(60, 35);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNo.Location = new System.Drawing.Point(700, 727);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(46, 23);
            this.lblPageNo.TabIndex = 7;
            this.lblPageNo.Text = "label";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(901, 722);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 35);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btn3xNext
            // 
            this.btn3xNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btn3xNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3xNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3xNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3xNext.ForeColor = System.Drawing.Color.White;
            this.btn3xNext.Location = new System.Drawing.Point(995, 722);
            this.btn3xNext.Name = "btn3xNext";
            this.btn3xNext.Size = new System.Drawing.Size(60, 35);
            this.btn3xNext.TabIndex = 9;
            this.btn3xNext.Text = ">>";
            this.btn3xNext.UseVisualStyleBackColor = false;
            this.btn3xNext.Click += new System.EventHandler(this.btn3xNext_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(846, 100);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(150, 35);
            this.btnDownload.TabIndex = 10;
            this.btnDownload.Text = "DOWNLOAD";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelManagementSystem.Views.Guest.ReportGuest.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1171, 722);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(10, 10);
            this.reportViewer1.TabIndex = 11;
            this.reportViewer1.Visible = false;
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Name",
            "NRC Number"});
            this.cbSearch.Location = new System.Drawing.Point(1213, 180);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(233, 31);
            this.cbSearch.TabIndex = 12;
            this.cbSearch.Text = "Search By";
            // 
            // btnCreateGuest
            // 
            this.btnCreateGuest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGuest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGuest.ForeColor = System.Drawing.Color.White;
            this.btnCreateGuest.Location = new System.Drawing.Point(29, 100);
            this.btnCreateGuest.Name = "btnCreateGuest";
            this.btnCreateGuest.Size = new System.Drawing.Size(200, 35);
            this.btnCreateGuest.TabIndex = 13;
            this.btnCreateGuest.Text = "CREATE GUEST";
            this.btnCreateGuest.UseVisualStyleBackColor = false;
            this.btnCreateGuest.Click += new System.EventHandler(this.btnCreateGuest_Click);
            // 
            // hdReservationId
            // 
            this.hdReservationId.AutoSize = true;
            this.hdReservationId.Location = new System.Drawing.Point(753, 116);
            this.hdReservationId.Name = "hdReservationId";
            this.hdReservationId.Size = new System.Drawing.Size(0, 16);
            this.hdReservationId.TabIndex = 14;
            this.hdReservationId.Visible = false;
            // 
            // btnGoToCheckin
            // 
            this.btnGoToCheckin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGoToCheckin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGoToCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToCheckin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToCheckin.ForeColor = System.Drawing.Color.White;
            this.btnGoToCheckin.Location = new System.Drawing.Point(1246, 100);
            this.btnGoToCheckin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoToCheckin.Name = "btnGoToCheckin";
            this.btnGoToCheckin.Size = new System.Drawing.Size(200, 34);
            this.btnGoToCheckin.TabIndex = 15;
            this.btnGoToCheckin.Text = "GO TO CHECKIN";
            this.btnGoToCheckin.UseVisualStyleBackColor = false;
            this.btnGoToCheckin.Click += new System.EventHandler(this.btnGoToCheckin_Click);
            // 
            // UCGuestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnGoToCheckin);
            this.Controls.Add(this.hdReservationId);
            this.Controls.Add(this.btnCreateGuest);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btn3xNext);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPageNo);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btn3xPrevious);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvGuestList);
            this.Name = "UCGuestList";
            this.Size = new System.Drawing.Size(1467, 861);
            this.Load += new System.EventHandler(this.UCGuestList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestList)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuestList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn3xPrevious;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btn3xNext;
        private System.Windows.Forms.Button btnDownload;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnCreateGuest;
        private System.Windows.Forms.Label hdReservationId;
        private System.Windows.Forms.Button btnGoToCheckin;
        private System.Windows.Forms.DataGridViewLinkColumn GuestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRCNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
