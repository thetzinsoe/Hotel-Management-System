namespace HotelManagementSystem.Views.Payment
{
    partial class UCPayNow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPayNow));
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.hdPaymentId = new System.Windows.Forms.Label();
            this.lbDiscountValidation = new System.Windows.Forms.Label();
            this.lbPaymentTypeValidation = new System.Windows.Forms.Label();
            this.lbExtraFeesValidation = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtExtraFees = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomFees = new System.Windows.Forms.TextBox();
            this.txtCheckInId = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(5);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1467, 76);
            this.pnTitle.TabIndex = 78;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(627, 18);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(146, 38);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "PAY NOW";
            // 
            // hdPaymentId
            // 
            this.hdPaymentId.AutoSize = true;
            this.hdPaymentId.Location = new System.Drawing.Point(472, 91);
            this.hdPaymentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hdPaymentId.Name = "hdPaymentId";
            this.hdPaymentId.Size = new System.Drawing.Size(0, 16);
            this.hdPaymentId.TabIndex = 142;
            this.hdPaymentId.Visible = false;
            // 
            // lbDiscountValidation
            // 
            this.lbDiscountValidation.AutoSize = true;
            this.lbDiscountValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscountValidation.ForeColor = System.Drawing.Color.Red;
            this.lbDiscountValidation.Location = new System.Drawing.Point(997, 534);
            this.lbDiscountValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiscountValidation.Name = "lbDiscountValidation";
            this.lbDiscountValidation.Size = new System.Drawing.Size(0, 20);
            this.lbDiscountValidation.TabIndex = 141;
            // 
            // lbPaymentTypeValidation
            // 
            this.lbPaymentTypeValidation.AutoSize = true;
            this.lbPaymentTypeValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentTypeValidation.ForeColor = System.Drawing.Color.Red;
            this.lbPaymentTypeValidation.Location = new System.Drawing.Point(988, 601);
            this.lbPaymentTypeValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPaymentTypeValidation.Name = "lbPaymentTypeValidation";
            this.lbPaymentTypeValidation.Size = new System.Drawing.Size(0, 20);
            this.lbPaymentTypeValidation.TabIndex = 140;
            // 
            // lbExtraFeesValidation
            // 
            this.lbExtraFeesValidation.AutoSize = true;
            this.lbExtraFeesValidation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtraFeesValidation.ForeColor = System.Drawing.Color.Red;
            this.lbExtraFeesValidation.Location = new System.Drawing.Point(1000, 298);
            this.lbExtraFeesValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExtraFeesValidation.Name = "lbExtraFeesValidation";
            this.lbExtraFeesValidation.Size = new System.Drawing.Size(0, 20);
            this.lbExtraFeesValidation.TabIndex = 139;
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(479, 352);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(665, 34);
            this.txtDuration.TabIndex = 138;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(301, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 137;
            this.label6.Text = "Duration :";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(479, 662);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAmount.MaxLength = 50;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(665, 34);
            this.txtTotalAmount.TabIndex = 136;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(1089, 102);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(56, 52);
            this.btnPrint.TabIndex = 121;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtExtraFees
            // 
            this.txtExtraFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraFees.Location = new System.Drawing.Point(479, 298);
            this.txtExtraFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExtraFees.Name = "txtExtraFees";
            this.txtExtraFees.Size = new System.Drawing.Size(665, 34);
            this.txtExtraFees.TabIndex = 135;
            this.txtExtraFees.Text = "0";
            this.txtExtraFees.TextChanged += new System.EventHandler(this.txtExtraFees_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(479, 533);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(665, 34);
            this.txtDiscount.TabIndex = 134;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 133;
            this.label5.Text = "Payment Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 674);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 28);
            this.label4.TabIndex = 132;
            this.label4.Text = "Totoal Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 131;
            this.label2.Text = "Discount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 130;
            this.label3.Text = "Description :";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(479, 412);
            this.rtxtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(665, 93);
            this.rtxtDescription.TabIndex = 129;
            this.rtxtDescription.Text = "";
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPaymentType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Bank",
            "Mobile Banking"});
            this.cbPaymentType.Location = new System.Drawing.Point(479, 604);
            this.cbPaymentType.Margin = new System.Windows.Forms.Padding(4);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(665, 36);
            this.cbPaymentType.TabIndex = 128;
            this.cbPaymentType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPaymentType_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 127;
            this.label1.Text = "Extra Fees :";
            // 
            // txtRoomFees
            // 
            this.txtRoomFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomFees.Location = new System.Drawing.Point(479, 238);
            this.txtRoomFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomFees.Name = "txtRoomFees";
            this.txtRoomFees.ReadOnly = true;
            this.txtRoomFees.Size = new System.Drawing.Size(665, 34);
            this.txtRoomFees.TabIndex = 126;
            // 
            // txtCheckInId
            // 
            this.txtCheckInId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInId.Location = new System.Drawing.Point(479, 175);
            this.txtCheckInId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckInId.MaxLength = 50;
            this.txtCheckInId.Name = "txtCheckInId";
            this.txtCheckInId.ReadOnly = true;
            this.txtCheckInId.Size = new System.Drawing.Size(665, 34);
            this.txtCheckInId.TabIndex = 125;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(301, 242);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(116, 28);
            this.lblGender.TabIndex = 124;
            this.lblGender.Text = "Room Fees :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(995, 736);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 39);
            this.btnBack.TabIndex = 123;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(301, 185);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(111, 28);
            this.lblFullName.TabIndex = 119;
            this.lblFullName.Text = "CheckIn Id :";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(479, 736);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(151, 39);
            this.btnConfirm.TabIndex = 122;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(479, 175);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(665, 34);
            this.txtFullName.TabIndex = 120;
            // 
            // UCPayNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.hdPaymentId);
            this.Controls.Add(this.lbDiscountValidation);
            this.Controls.Add(this.lbPaymentTypeValidation);
            this.Controls.Add(this.lbExtraFeesValidation);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtExtraFees);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.cbPaymentType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomFees);
            this.Controls.Add(this.txtCheckInId);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.pnTitle);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCPayNow";
            this.Size = new System.Drawing.Size(1467, 866);
            this.Load += new System.EventHandler(this.UCPayNow_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label hdPaymentId;
        private System.Windows.Forms.Label lbDiscountValidation;
        private System.Windows.Forms.Label lbPaymentTypeValidation;
        private System.Windows.Forms.Label lbExtraFeesValidation;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtExtraFees;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoomFees;
        private System.Windows.Forms.TextBox txtCheckInId;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtFullName;
    }
}
