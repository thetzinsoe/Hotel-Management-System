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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.pnTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).BeginInit();
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
            this.pnTitle.TabIndex = 79;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(470, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(254, 30);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "CURRENT CHECKIN LIST";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchValue);
            this.groupBox1.Controls.Add(this.cbSearchType);
            this.groupBox1.Controls.Add(this.btn3xNext);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.lblPageNo);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.btn3xPrevious);
            this.groupBox1.Controls.Add(this.dgvCheckIn);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 578);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CheckIn List";
            // 
            // btn3xNext
            // 
            this.btn3xNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3xNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3xNext.Location = new System.Drawing.Point(739, 487);
            this.btn3xNext.Margin = new System.Windows.Forms.Padding(2);
            this.btn3xNext.Name = "btn3xNext";
            this.btn3xNext.Size = new System.Drawing.Size(45, 28);
            this.btn3xNext.TabIndex = 90;
            this.btn3xNext.Text = ">>";
            this.btn3xNext.UseVisualStyleBackColor = true;
            this.btn3xNext.Click += new System.EventHandler(this.btn3xNext_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(669, 487);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 28);
            this.btnNext.TabIndex = 89;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNo.Location = new System.Drawing.Point(524, 492);
            this.lblPageNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(37, 19);
            this.lblPageNo.TabIndex = 88;
            this.lblPageNo.Text = "label";
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(384, 487);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(45, 28);
            this.btnPrev.TabIndex = 87;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btn3xPrevious
            // 
            this.btn3xPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3xPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3xPrevious.Location = new System.Drawing.Point(310, 487);
            this.btn3xPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btn3xPrevious.Name = "btn3xPrevious";
            this.btn3xPrevious.Size = new System.Drawing.Size(45, 28);
            this.btn3xPrevious.TabIndex = 86;
            this.btn3xPrevious.Text = "<<";
            this.btn3xPrevious.UseVisualStyleBackColor = true;
            this.btn3xPrevious.Click += new System.EventHandler(this.btn3xPrevious_Click);
            // 
            // dgvCheckIn
            // 
            this.dgvCheckIn.AllowUserToAddRows = false;
            this.dgvCheckIn.AllowUserToDeleteRows = false;
            this.dgvCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.guestName,
            this.guestNrc,
            this.roomNumber,
            this.checkInDate,
            this.checkOutDate,
            this.checkout});
            this.dgvCheckIn.Location = new System.Drawing.Point(7, 65);
            this.dgvCheckIn.Name = "dgvCheckIn";
            this.dgvCheckIn.ReadOnly = true;
            this.dgvCheckIn.RowTemplate.Height = 30;
            this.dgvCheckIn.Size = new System.Drawing.Size(1081, 404);
            this.dgvCheckIn.TabIndex = 0;
            this.dgvCheckIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "checkin_id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Id.Width = 40;
            // 
            // guestName
            // 
            this.guestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guestName.DataPropertyName = "full_name";
            this.guestName.HeaderText = "Guest Name";
            this.guestName.Name = "guestName";
            this.guestName.ReadOnly = true;
            // 
            // guestNrc
            // 
            this.guestNrc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guestNrc.DataPropertyName = "nrc_number";
            this.guestNrc.HeaderText = "Guest Nrc Number";
            this.guestNrc.Name = "guestNrc";
            this.guestNrc.ReadOnly = true;
            // 
            // roomNumber
            // 
            this.roomNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roomNumber.DataPropertyName = "room_no";
            this.roomNumber.HeaderText = "Room Number";
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.ReadOnly = true;
            // 
            // checkInDate
            // 
            this.checkInDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkInDate.DataPropertyName = "checkin_date";
            this.checkInDate.HeaderText = "CheckIn Date";
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.ReadOnly = true;
            // 
            // checkOutDate
            // 
            this.checkOutDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkOutDate.DataPropertyName = "checkout_date";
            this.checkOutDate.HeaderText = "Check Out Date";
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.ReadOnly = true;
            // 
            // checkout
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.checkout.DefaultCellStyle = dataGridViewCellStyle2;
            this.checkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkout.HeaderText = "Check Out";
            this.checkout.Name = "checkout";
            this.checkout.ReadOnly = true;
            this.checkout.Text = "Check Out";
            this.checkout.UseColumnTextForButtonValue = true;
            // 
            // cbSearchType
            // 
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Name",
            "Nrc Number"});
            this.cbSearchType.Location = new System.Drawing.Point(923, 28);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(165, 29);
            this.cbSearchType.TabIndex = 93;
            this.cbSearchType.Text = "Choose Search Type";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(603, 28);
            this.txtSearchValue.MaxLength = 20;
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(314, 29);
            this.txtSearchValue.TabIndex = 94;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
            // 
            // UCCheckInList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnTitle);
            this.Name = "UCCheckInList";
            this.Size = new System.Drawing.Size(1100, 650);
            this.Load += new System.EventHandler(this.UCCheckInList_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCheckIn;
        private System.Windows.Forms.DataGridViewLinkColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDate;
        private System.Windows.Forms.DataGridViewButtonColumn checkout;
        private System.Windows.Forms.Button btn3xNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btn3xPrevious;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.TextBox txtSearchValue;
    }
}
