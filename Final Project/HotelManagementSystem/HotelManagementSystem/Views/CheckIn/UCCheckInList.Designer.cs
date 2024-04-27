namespace HotelManagementSystem.Views.CheckIn
{
    partial class UCCheckInList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.btn3xNext = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageNo = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btn3xPrevious = new System.Windows.Forms.Button();
            this.dgvCheckIn = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.guestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1467, 76);
            this.pnTitle.TabIndex = 79;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(620, 19);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(333, 38);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "CURRENT CHECKIN LIST";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchValue.Location = new System.Drawing.Point(769, 93);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchValue.MaxLength = 20;
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(417, 34);
            this.txtSearchValue.TabIndex = 102;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownWidth = 180;
            this.cbSearchType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Name",
            "Nrc Number"});
            this.cbSearchType.Location = new System.Drawing.Point(1196, 93);
            this.cbSearchType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(257, 36);
            this.cbSearchType.TabIndex = 101;
            this.cbSearchType.Text = "Search By";
            // 
            // btn3xNext
            // 
            this.btn3xNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btn3xNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3xNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3xNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3xNext.ForeColor = System.Drawing.Color.White;
            this.btn3xNext.Location = new System.Drawing.Point(989, 656);
            this.btn3xNext.Name = "btn3xNext";
            this.btn3xNext.Size = new System.Drawing.Size(85, 45);
            this.btn3xNext.TabIndex = 100;
            this.btn3xNext.Text = ">>";
            this.btn3xNext.UseVisualStyleBackColor = false;
            this.btn3xNext.Click += new System.EventHandler(this.btn3xNext_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(896, 656);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 45);
            this.btnNext.TabIndex = 99;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNo.Location = new System.Drawing.Point(715, 664);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(55, 28);
            this.lblPageNo.TabIndex = 98;
            this.lblPageNo.Text = "label";
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(516, 656);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(85, 45);
            this.btnPrev.TabIndex = 97;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btn3xPrevious
            // 
            this.btn3xPrevious.BackColor = System.Drawing.Color.SteelBlue;
            this.btn3xPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3xPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3xPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3xPrevious.ForeColor = System.Drawing.Color.White;
            this.btn3xPrevious.Location = new System.Drawing.Point(417, 656);
            this.btn3xPrevious.Name = "btn3xPrevious";
            this.btn3xPrevious.Size = new System.Drawing.Size(85, 45);
            this.btn3xPrevious.TabIndex = 96;
            this.btn3xPrevious.Text = "<<";
            this.btn3xPrevious.UseVisualStyleBackColor = false;
            this.btn3xPrevious.Click += new System.EventHandler(this.btn3xPrevious_Click);
            // 
            // dgvCheckIn
            // 
            this.dgvCheckIn.AllowUserToAddRows = false;
            this.dgvCheckIn.AllowUserToDeleteRows = false;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.guestName,
            this.guestNrc,
            this.roomNumber,
            this.checkInDate,
            this.checkOutDate,
            this.checkout});
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckIn.DefaultCellStyle = dataGridViewCellStyle42;
            this.dgvCheckIn.Location = new System.Drawing.Point(13, 140);
            this.dgvCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCheckIn.Name = "dgvCheckIn";
            this.dgvCheckIn.ReadOnly = true;
            this.dgvCheckIn.RowHeadersVisible = false;
            this.dgvCheckIn.RowHeadersWidth = 51;
            this.dgvCheckIn.RowTemplate.Height = 30;
            this.dgvCheckIn.Size = new System.Drawing.Size(1441, 471);
            this.dgvCheckIn.TabIndex = 95;
            this.dgvCheckIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "checkin_id";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle37;
            this.Id.HeaderText = "Checkin No.";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // guestName
            // 
            this.guestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guestName.DataPropertyName = "full_name";
            this.guestName.HeaderText = "Guest Name";
            this.guestName.MinimumWidth = 6;
            this.guestName.Name = "guestName";
            this.guestName.ReadOnly = true;
            // 
            // guestNrc
            // 
            this.guestNrc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guestNrc.DataPropertyName = "nrc_number";
            this.guestNrc.HeaderText = "Guest Nrc Number";
            this.guestNrc.MinimumWidth = 6;
            this.guestNrc.Name = "guestNrc";
            this.guestNrc.ReadOnly = true;
            // 
            // roomNumber
            // 
            this.roomNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roomNumber.DataPropertyName = "room_no";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.roomNumber.DefaultCellStyle = dataGridViewCellStyle38;
            this.roomNumber.HeaderText = "Room Number";
            this.roomNumber.MinimumWidth = 6;
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.ReadOnly = true;
            // 
            // checkInDate
            // 
            this.checkInDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkInDate.DataPropertyName = "checkin_date";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.checkInDate.DefaultCellStyle = dataGridViewCellStyle39;
            this.checkInDate.HeaderText = "CheckIn Date";
            this.checkInDate.MinimumWidth = 6;
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.ReadOnly = true;
            // 
            // checkOutDate
            // 
            this.checkOutDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkOutDate.DataPropertyName = "checkout_date";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.checkOutDate.DefaultCellStyle = dataGridViewCellStyle40;
            this.checkOutDate.HeaderText = "Check Out Date";
            this.checkOutDate.MinimumWidth = 6;
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.ReadOnly = true;
            // 
            // checkout
            // 
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.checkout.DefaultCellStyle = dataGridViewCellStyle41;
            this.checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout.HeaderText = "Check Out";
            this.checkout.MinimumWidth = 6;
            this.checkout.Name = "checkout";
            this.checkout.ReadOnly = true;
            this.checkout.Text = "Check Out";
            this.checkout.UseColumnTextForButtonValue = true;
            this.checkout.Width = 125;
            // 
            // UCCheckInList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.btn3xNext);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPageNo);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btn3xPrevious);
            this.Controls.Add(this.dgvCheckIn);
            this.Controls.Add(this.pnTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCCheckInList";
            this.Size = new System.Drawing.Size(1467, 861);
            this.Load += new System.EventHandler(this.UCCheckInList_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.Button btn3xNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btn3xPrevious;
        private System.Windows.Forms.DataGridView dgvCheckIn;
        private System.Windows.Forms.DataGridViewLinkColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDate;
        private System.Windows.Forms.DataGridViewButtonColumn checkout;
    }
}
