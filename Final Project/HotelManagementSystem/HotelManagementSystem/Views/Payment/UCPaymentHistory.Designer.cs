namespace HotelManagementSystem.Views.Payment
{
    partial class UCPaymentHistory
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
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();
            this.payment_id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.checkin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra_fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
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
            this.pnTitle.TabIndex = 78;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(470, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(206, 30);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "PAYMENT HISTORY";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn3xNext);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.lblPageNo);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.btn3xPrevious);
            this.groupBox1.Controls.Add(this.dgvPaymentHistory);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 628);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment History";
            // 
            // btn3xNext
            // 
            this.btn3xNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3xNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3xNext.Location = new System.Drawing.Point(738, 481);
            this.btn3xNext.Margin = new System.Windows.Forms.Padding(2);
            this.btn3xNext.Name = "btn3xNext";
            this.btn3xNext.Size = new System.Drawing.Size(45, 28);
            this.btn3xNext.TabIndex = 85;
            this.btn3xNext.Text = ">>";
            this.btn3xNext.UseVisualStyleBackColor = true;
            this.btn3xNext.Click += new System.EventHandler(this.btn3xNext_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(668, 481);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 28);
            this.btnNext.TabIndex = 84;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNo.Location = new System.Drawing.Point(523, 486);
            this.lblPageNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(37, 19);
            this.lblPageNo.TabIndex = 83;
            this.lblPageNo.Text = "label";
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(383, 481);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(45, 28);
            this.btnPrev.TabIndex = 82;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // btn3xPrevious
            // 
            this.btn3xPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3xPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3xPrevious.Location = new System.Drawing.Point(309, 481);
            this.btn3xPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btn3xPrevious.Name = "btn3xPrevious";
            this.btn3xPrevious.Size = new System.Drawing.Size(45, 28);
            this.btn3xPrevious.TabIndex = 81;
            this.btn3xPrevious.Text = "<<";
            this.btn3xPrevious.UseVisualStyleBackColor = true;
            this.btn3xPrevious.Click += new System.EventHandler(this.btn3xPrevious_Click_1);
            // 
            // dgvPaymentHistory
            // 
            this.dgvPaymentHistory.AllowUserToAddRows = false;
            this.dgvPaymentHistory.AllowUserToDeleteRows = false;
            this.dgvPaymentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payment_id,
            this.checkin_id,
            this.room_fees,
            this.extra_fees,
            this.description,
            this.discount,
            this.total_fees,
            this.payment_type,
            this.payment_date});
            this.dgvPaymentHistory.Location = new System.Drawing.Point(6, 28);
            this.dgvPaymentHistory.Name = "dgvPaymentHistory";
            this.dgvPaymentHistory.ReadOnly = true;
            this.dgvPaymentHistory.RowTemplate.Height = 30;
            this.dgvPaymentHistory.Size = new System.Drawing.Size(1081, 432);
            this.dgvPaymentHistory.TabIndex = 80;
            this.dgvPaymentHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentHistory_CellContentClick);
            // 
            // payment_id
            // 
            this.payment_id.DataPropertyName = "payment_id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.payment_id.DefaultCellStyle = dataGridViewCellStyle1;
            this.payment_id.HeaderText = "ID";
            this.payment_id.Name = "payment_id";
            this.payment_id.ReadOnly = true;
            this.payment_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.payment_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.payment_id.Width = 50;
            // 
            // checkin_id
            // 
            this.checkin_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkin_id.DataPropertyName = "checkin_id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.checkin_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.checkin_id.HeaderText = "Checkin Id";
            this.checkin_id.Name = "checkin_id";
            this.checkin_id.ReadOnly = true;
            // 
            // room_fees
            // 
            this.room_fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.room_fees.DataPropertyName = "room_fees";
            this.room_fees.HeaderText = "Room Fees";
            this.room_fees.Name = "room_fees";
            this.room_fees.ReadOnly = true;
            // 
            // extra_fees
            // 
            this.extra_fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.extra_fees.DataPropertyName = "extra_fees";
            this.extra_fees.HeaderText = "Extra Fees";
            this.extra_fees.Name = "extra_fees";
            this.extra_fees.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 300;
            // 
            // discount
            // 
            this.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discount.DataPropertyName = "discount";
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // total_fees
            // 
            this.total_fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_fees.DataPropertyName = "total_fees";
            this.total_fees.HeaderText = "Total ";
            this.total_fees.Name = "total_fees";
            this.total_fees.ReadOnly = true;
            // 
            // payment_type
            // 
            this.payment_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.payment_type.DataPropertyName = "payment_type";
            this.payment_type.HeaderText = "Payment Type";
            this.payment_type.Name = "payment_type";
            this.payment_type.ReadOnly = true;
            // 
            // payment_date
            // 
            this.payment_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.payment_date.DataPropertyName = "created_date";
            this.payment_date.HeaderText = "Payment Date";
            this.payment_date.Name = "payment_date";
            this.payment_date.ReadOnly = true;
            // 
            // UCPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnTitle);
            this.Name = "UCPaymentHistory";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.UCPaymentHistory_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPaymentHistory;
        private System.Windows.Forms.DataGridViewLinkColumn payment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra_fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_date;
        private System.Windows.Forms.Button btn3xNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btn3xPrevious;
    }
}
