namespace HotelManagementSystem.Views.Reservation
{
    partial class UCReservationList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn3xNext = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageNo = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btn3xPrevious = new System.Windows.Forms.Button();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.reservation_id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.room_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_phoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Silver;
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1100, 62);
            this.pnTitle.TabIndex = 0;
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchValue);
            this.groupBox1.Controls.Add(this.btn3xNext);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.lblPageNo);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.btn3xPrevious);
            this.groupBox1.Controls.Add(this.dgvReservation);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 686);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation List";
            // 
            // btn3xNext
            // 
            this.btn3xNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3xNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3xNext.Location = new System.Drawing.Point(738, 501);
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
            this.btnNext.Location = new System.Drawing.Point(668, 501);
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
            this.lblPageNo.Location = new System.Drawing.Point(523, 506);
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
            this.btnPrev.Location = new System.Drawing.Point(383, 501);
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
            this.btn3xPrevious.Location = new System.Drawing.Point(309, 501);
            this.btn3xPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btn3xPrevious.Name = "btn3xPrevious";
            this.btn3xPrevious.Size = new System.Drawing.Size(45, 28);
            this.btn3xPrevious.TabIndex = 86;
            this.btn3xPrevious.Text = "<<";
            this.btn3xPrevious.UseVisualStyleBackColor = true;
            this.btn3xPrevious.Click += new System.EventHandler(this.btn3xPrevious_Click);
            // 
            // dgvReservation
            // 
            this.dgvReservation.AllowUserToAddRows = false;
            this.dgvReservation.AllowUserToDeleteRows = false;
            this.dgvReservation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservation_id,
            this.room_number,
            this.customer_name,
            this.customer_phoneNo,
            this.checkin_date,
            this.checkout_date,
            this.checkin});
            this.dgvReservation.Location = new System.Drawing.Point(6, 64);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.RowTemplate.Height = 30;
            this.dgvReservation.Size = new System.Drawing.Size(1081, 405);
            this.dgvReservation.TabIndex = 2;
            this.dgvReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellContentClick);
            // 
            // reservation_id
            // 
            this.reservation_id.DataPropertyName = "reservation_id";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.reservation_id.DefaultCellStyle = dataGridViewCellStyle5;
            this.reservation_id.HeaderText = "ID";
            this.reservation_id.Name = "reservation_id";
            this.reservation_id.ReadOnly = true;
            this.reservation_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reservation_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reservation_id.Width = 50;
            // 
            // room_number
            // 
            this.room_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.room_number.DataPropertyName = "room_number";
            this.room_number.HeaderText = "Room Number";
            this.room_number.Name = "room_number";
            this.room_number.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "Customer Name";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // customer_phoneNo
            // 
            this.customer_phoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_phoneNo.DataPropertyName = "customer_phoneNo";
            this.customer_phoneNo.HeaderText = "Customer Phone";
            this.customer_phoneNo.Name = "customer_phoneNo";
            this.customer_phoneNo.ReadOnly = true;
            // 
            // checkin_date
            // 
            this.checkin_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkin_date.DataPropertyName = "checkin_date";
            this.checkin_date.HeaderText = "CheckIn Date";
            this.checkin_date.Name = "checkin_date";
            this.checkin_date.ReadOnly = true;
            // 
            // checkout_date
            // 
            this.checkout_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkout_date.DataPropertyName = "checkout_date";
            this.checkout_date.HeaderText = "CheckOut Date";
            this.checkout_date.Name = "checkout_date";
            this.checkout_date.ReadOnly = true;
            // 
            // checkin
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkin.DefaultCellStyle = dataGridViewCellStyle6;
            this.checkin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkin.HeaderText = "Check In";
            this.checkin.Name = "checkin";
            this.checkin.ReadOnly = true;
            this.checkin.Text = "Check In";
            this.checkin.UseColumnTextForButtonValue = true;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(773, 28);
            this.txtSearchValue.MaxLength = 20;
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(314, 29);
            this.txtSearchValue.TabIndex = 95;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 96;
            this.label1.Text = "Search With Name";
            // 
            // UCReservationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnTitle);
            this.Name = "UCReservationList";
            this.Size = new System.Drawing.Size(1100, 758);
            this.Load += new System.EventHandler(this.UCReservation_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.DataGridViewLinkColumn reservation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_phoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkout_date;
        private System.Windows.Forms.DataGridViewButtonColumn checkin;
        private System.Windows.Forms.Button btn3xNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btn3xPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchValue;
    }
}
