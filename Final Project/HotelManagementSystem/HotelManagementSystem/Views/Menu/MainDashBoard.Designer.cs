namespace HotelManagementSystem.Views.Menu
{
    partial class MainDashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TtlRoom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRoom = new System.Windows.Forms.PictureBox();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TtlAvailableRoom = new System.Windows.Forms.Label();
            this.pbAvRoom = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TtlReservation = new System.Windows.Forms.Label();
            this.pbReserve = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TtlChecked = new System.Windows.Forms.Label();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TtlEmp = new System.Windows.Forms.Label();
            this.pbEmp = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TtlGuest = new System.Windows.Forms.Label();
            this.pbGuest = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dgvFeedBack = new System.Windows.Forms.DataGridView();
            this.review = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom)).BeginInit();
            this.gbMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvRoom)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReserve)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmp)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.TtlRoom);
            this.panel1.Controls.Add(this.pbRoom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 200);
            this.panel1.TabIndex = 31;
            // 
            // TtlRoom
            // 
            this.TtlRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TtlRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtlRoom.Location = new System.Drawing.Point(2, 100);
            this.TtlRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TtlRoom.Name = "TtlRoom";
            this.TtlRoom.Size = new System.Drawing.Size(246, 38);
            this.TtlRoom.TabIndex = 2;
            this.TtlRoom.Text = "-";
            this.TtlRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Rooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbRoom
            // 
            this.pbRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRoom.Location = new System.Drawing.Point(85, 20);
            this.pbRoom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbRoom.Name = "pbRoom";
            this.pbRoom.Size = new System.Drawing.Size(75, 75);
            this.pbRoom.TabIndex = 1;
            this.pbRoom.TabStop = false;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.monthCalendar1);
            this.gbMain.Controls.Add(this.panel4);
            this.gbMain.Controls.Add(this.panel5);
            this.gbMain.Controls.Add(this.panel6);
            this.gbMain.Controls.Add(this.panel3);
            this.gbMain.Controls.Add(this.panel2);
            this.gbMain.Controls.Add(this.panel1);
            this.gbMain.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1200, 450);
            this.gbMain.TabIndex = 37;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Hotel Dashboard";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.TtlAvailableRoom);
            this.panel2.Controls.Add(this.pbAvRoom);
            this.panel2.Location = new System.Drawing.Point(5, 240);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 200);
            this.panel2.TabIndex = 32;
            // 
            // TtlAvailableRoom
            // 
            this.TtlAvailableRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TtlAvailableRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtlAvailableRoom.Location = new System.Drawing.Point(2, 100);
            this.TtlAvailableRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TtlAvailableRoom.Name = "TtlAvailableRoom";
            this.TtlAvailableRoom.Size = new System.Drawing.Size(246, 38);
            this.TtlAvailableRoom.TabIndex = 2;
            this.TtlAvailableRoom.Text = "-";
            this.TtlAvailableRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAvRoom
            // 
            this.pbAvRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAvRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvRoom.Location = new System.Drawing.Point(85, 20);
            this.pbAvRoom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbAvRoom.Name = "pbAvRoom";
            this.pbAvRoom.Size = new System.Drawing.Size(75, 75);
            this.pbAvRoom.TabIndex = 1;
            this.pbAvRoom.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TtlReservation);
            this.panel3.Controls.Add(this.pbReserve);
            this.panel3.Location = new System.Drawing.Point(255, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 200);
            this.panel3.TabIndex = 33;
            // 
            // TtlReservation
            // 
            this.TtlReservation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TtlReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtlReservation.Location = new System.Drawing.Point(2, 100);
            this.TtlReservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TtlReservation.Name = "TtlReservation";
            this.TtlReservation.Size = new System.Drawing.Size(246, 38);
            this.TtlReservation.TabIndex = 2;
            this.TtlReservation.Text = "-";
            this.TtlReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbReserve
            // 
            this.pbReserve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReserve.Location = new System.Drawing.Point(85, 20);
            this.pbReserve.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbReserve.Name = "pbReserve";
            this.pbReserve.Size = new System.Drawing.Size(75, 75);
            this.pbReserve.TabIndex = 1;
            this.pbReserve.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.TtlChecked);
            this.panel4.Controls.Add(this.pbCheck);
            this.panel4.Location = new System.Drawing.Point(255, 240);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 200);
            this.panel4.TabIndex = 32;
            // 
            // TtlChecked
            // 
            this.TtlChecked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TtlChecked.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtlChecked.Location = new System.Drawing.Point(2, 100);
            this.TtlChecked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TtlChecked.Name = "TtlChecked";
            this.TtlChecked.Size = new System.Drawing.Size(246, 38);
            this.TtlChecked.TabIndex = 2;
            this.TtlChecked.Text = "-";
            this.TtlChecked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCheck
            // 
            this.pbCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCheck.Location = new System.Drawing.Point(85, 20);
            this.pbCheck.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(75, 75);
            this.pbCheck.TabIndex = 1;
            this.pbCheck.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.TtlEmp);
            this.panel5.Controls.Add(this.pbEmp);
            this.panel5.Location = new System.Drawing.Point(505, 40);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 200);
            this.panel5.TabIndex = 32;
            // 
            // TtlEmp
            // 
            this.TtlEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TtlEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtlEmp.Location = new System.Drawing.Point(2, 100);
            this.TtlEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TtlEmp.Name = "TtlEmp";
            this.TtlEmp.Size = new System.Drawing.Size(246, 38);
            this.TtlEmp.TabIndex = 2;
            this.TtlEmp.Text = "-";
            this.TtlEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEmp
            // 
            this.pbEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEmp.Location = new System.Drawing.Point(85, 20);
            this.pbEmp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbEmp.Name = "pbEmp";
            this.pbEmp.Size = new System.Drawing.Size(75, 75);
            this.pbEmp.TabIndex = 1;
            this.pbEmp.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.TtlGuest);
            this.panel6.Controls.Add(this.pbGuest);
            this.panel6.Location = new System.Drawing.Point(505, 240);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 200);
            this.panel6.TabIndex = 32;
            // 
            // TtlGuest
            // 
            this.TtlGuest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TtlGuest.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtlGuest.Location = new System.Drawing.Point(2, 100);
            this.TtlGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TtlGuest.Name = "TtlGuest";
            this.TtlGuest.Size = new System.Drawing.Size(246, 38);
            this.TtlGuest.TabIndex = 2;
            this.TtlGuest.Text = "-";
            this.TtlGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbGuest
            // 
            this.pbGuest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGuest.Location = new System.Drawing.Point(85, 20);
            this.pbGuest.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pbGuest.Name = "pbGuest";
            this.pbGuest.Size = new System.Drawing.Size(75, 75);
            this.pbGuest.TabIndex = 1;
            this.pbGuest.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(860, 40);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 38;
            // 
            // dgvFeedBack
            // 
            this.dgvFeedBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvFeedBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedBack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.review,
            this.GuestName,
            this.Rating,
            this.Feedback});
            this.dgvFeedBack.Location = new System.Drawing.Point(5, 455);
            this.dgvFeedBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvFeedBack.Name = "dgvFeedBack";
            this.dgvFeedBack.RowHeadersWidth = 51;
            this.dgvFeedBack.Size = new System.Drawing.Size(750, 375);
            this.dgvFeedBack.TabIndex = 38;
            // 
            // review
            // 
            this.review.HeaderText = "Review No";
            this.review.MinimumWidth = 6;
            this.review.Name = "review";
            this.review.Width = 125;
            // 
            // GuestName
            // 
            this.GuestName.HeaderText = "Guest Name";
            this.GuestName.MinimumWidth = 6;
            this.GuestName.Name = "GuestName";
            this.GuestName.Width = 150;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.Width = 125;
            // 
            // Feedback
            // 
            this.Feedback.HeaderText = "Feedback Message";
            this.Feedback.MinimumWidth = 6;
            this.Feedback.Name = "Feedback";
            this.Feedback.Width = 300;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reservation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Employee";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Guests";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 28);
            this.label10.TabIndex = 5;
            this.label10.Text = "Checked In";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 28);
            this.label12.TabIndex = 3;
            this.label12.Text = "Available Rooms";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dgvFeedBack);
            this.Controls.Add(this.gbMain);
            this.Name = "MainDashBoard";
            this.Size = new System.Drawing.Size(1200, 850);
            this.Load += new System.EventHandler(this.MainDashBoard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom)).EndInit();
            this.gbMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvRoom)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReserve)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmp)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TtlRoom;
        private System.Windows.Forms.PictureBox pbRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label TtlChecked;
        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label TtlEmp;
        private System.Windows.Forms.PictureBox pbEmp;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label TtlGuest;
        private System.Windows.Forms.PictureBox pbGuest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TtlReservation;
        private System.Windows.Forms.PictureBox pbReserve;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TtlAvailableRoom;
        private System.Windows.Forms.PictureBox pbAvRoom;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgvFeedBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn review;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feedback;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
    }
}
