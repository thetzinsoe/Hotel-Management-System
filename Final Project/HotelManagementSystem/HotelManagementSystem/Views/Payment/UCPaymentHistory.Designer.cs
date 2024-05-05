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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btn3xNext = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageNo = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btn3xPrevious = new System.Windows.Forms.Button();
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();
            this.payment_id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.payment_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin_id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.room_fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra_fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1100, 62);
            this.pnTitle.TabIndex = 78;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(470, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(213, 30);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "PAYMENT HISTORY";
            // 
            // btn3xNext
            // 
            this.btn3xNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btn3xNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3xNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3xNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3xNext.ForeColor = System.Drawing.Color.White;
            this.btn3xNext.Location = new System.Drawing.Point(742, 593);
            this.btn3xNext.Margin = new System.Windows.Forms.Padding(2);
            this.btn3xNext.Name = "btn3xNext";
            this.btn3xNext.Size = new System.Drawing.Size(49, 30);
            this.btn3xNext.TabIndex = 91;
            this.btn3xNext.Text = ">>";
            this.btn3xNext.UseVisualStyleBackColor = false;
            this.btn3xNext.Click += new System.EventHandler(this.btn3xNext_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(672, 593);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 30);
            this.btnNext.TabIndex = 90;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNo.Location = new System.Drawing.Point(535, 600);
            this.lblPageNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(43, 21);
            this.lblPageNo.TabIndex = 89;
            this.lblPageNo.Text = "label";
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(387, 593);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(49, 30);
            this.btnPrev.TabIndex = 88;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // btn3xPrevious
            // 
            this.btn3xPrevious.BackColor = System.Drawing.Color.SteelBlue;
            this.btn3xPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3xPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3xPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3xPrevious.ForeColor = System.Drawing.Color.White;
            this.btn3xPrevious.Location = new System.Drawing.Point(313, 593);
            this.btn3xPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btn3xPrevious.Name = "btn3xPrevious";
            this.btn3xPrevious.Size = new System.Drawing.Size(49, 30);
            this.btn3xPrevious.TabIndex = 87;
            this.btn3xPrevious.Text = "<<";
            this.btn3xPrevious.UseVisualStyleBackColor = false;
            this.btn3xPrevious.Click += new System.EventHandler(this.btn3xPrevious_Click_1);
            // 
            // dgvPaymentHistory
            // 
            this.dgvPaymentHistory.AllowUserToAddRows = false;
            this.dgvPaymentHistory.AllowUserToDeleteRows = false;
            this.dgvPaymentHistory.AllowUserToResizeColumns = false;
            this.dgvPaymentHistory.AllowUserToResizeRows = false;
            this.dgvPaymentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaymentHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payment_id,
            this.payment_date,
            this.checkin_id,
            this.room_fees,
            this.extra_fees,
            this.description,
            this.discount,
            this.total_fees,
            this.payment_type});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentHistory.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPaymentHistory.Location = new System.Drawing.Point(10, 106);
            this.dgvPaymentHistory.Name = "dgvPaymentHistory";
            this.dgvPaymentHistory.ReadOnly = true;
            this.dgvPaymentHistory.RowHeadersVisible = false;
            this.dgvPaymentHistory.RowHeadersWidth = 51;
            this.dgvPaymentHistory.RowTemplate.Height = 40;
            this.dgvPaymentHistory.Size = new System.Drawing.Size(1081, 455);
            this.dgvPaymentHistory.TabIndex = 86;
            this.dgvPaymentHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentHistory_CellContentClick);
            // 
            // payment_id
            // 
            this.payment_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.payment_id.DataPropertyName = "payment_id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.payment_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.payment_id.HeaderText = "Payment No.";
            this.payment_id.MinimumWidth = 6;
            this.payment_id.Name = "payment_id";
            this.payment_id.ReadOnly = true;
            this.payment_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // payment_date
            // 
            this.payment_date.DataPropertyName = "created_date";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.payment_date.DefaultCellStyle = dataGridViewCellStyle3;
            this.payment_date.HeaderText = "Payment Date";
            this.payment_date.MinimumWidth = 6;
            this.payment_date.Name = "payment_date";
            this.payment_date.ReadOnly = true;
            this.payment_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.payment_date.Width = 150;
            // 
            // checkin_id
            // 
            this.checkin_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkin_id.DataPropertyName = "checkin_id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.checkin_id.DefaultCellStyle = dataGridViewCellStyle4;
            this.checkin_id.HeaderText = "Checkin No.";
            this.checkin_id.MinimumWidth = 6;
            this.checkin_id.Name = "checkin_id";
            this.checkin_id.ReadOnly = true;
            this.checkin_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // room_fees
            // 
            this.room_fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.room_fees.DataPropertyName = "room_fees";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.room_fees.DefaultCellStyle = dataGridViewCellStyle5;
            this.room_fees.HeaderText = "Room Fees";
            this.room_fees.MinimumWidth = 6;
            this.room_fees.Name = "room_fees";
            this.room_fees.ReadOnly = true;
            this.room_fees.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // extra_fees
            // 
            this.extra_fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.extra_fees.DataPropertyName = "extra_fees";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.extra_fees.DefaultCellStyle = dataGridViewCellStyle6;
            this.extra_fees.HeaderText = "Extra Fees";
            this.extra_fees.MinimumWidth = 6;
            this.extra_fees.Name = "extra_fees";
            this.extra_fees.ReadOnly = true;
            this.extra_fees.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.description.Width = 300;
            // 
            // discount
            // 
            this.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discount.DataPropertyName = "discount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.discount.DefaultCellStyle = dataGridViewCellStyle7;
            this.discount.HeaderText = "Discount";
            this.discount.MinimumWidth = 6;
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // total_fees
            // 
            this.total_fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_fees.DataPropertyName = "total_fees";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total_fees.DefaultCellStyle = dataGridViewCellStyle8;
            this.total_fees.HeaderText = "Total ";
            this.total_fees.MinimumWidth = 6;
            this.total_fees.Name = "total_fees";
            this.total_fees.ReadOnly = true;
            this.total_fees.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // payment_type
            // 
            this.payment_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.payment_type.DataPropertyName = "payment_type";
            this.payment_type.HeaderText = "Payment Type";
            this.payment_type.MinimumWidth = 6;
            this.payment_type.Name = "payment_type";
            this.payment_type.ReadOnly = true;
            this.payment_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UCPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btn3xNext);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPageNo);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btn3xPrevious);
            this.Controls.Add(this.dgvPaymentHistory);
            this.Controls.Add(this.pnTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCPaymentHistory";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.UCPaymentHistory_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btn3xNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btn3xPrevious;
        private System.Windows.Forms.DataGridView dgvPaymentHistory;
        private System.Windows.Forms.DataGridViewLinkColumn payment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_date;
        private System.Windows.Forms.DataGridViewLinkColumn checkin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra_fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_type;
    }
}
