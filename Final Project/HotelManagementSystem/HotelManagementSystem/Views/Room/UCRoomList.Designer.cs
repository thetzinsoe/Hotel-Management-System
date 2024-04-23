namespace HotelManagementSystem.Views.Room
{
    partial class UCRoomList
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
            this.components = new System.ComponentModel.Container();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageNo = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roomDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomDataSet = new HotelManagementSystem.Views.Room.RoomDataSet();
            this.roomTableAdapter = new HotelManagementSystem.Views.Room.RoomDataSetTableAdapters.RoomTableAdapter();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLast
            // 
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLast.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(852, 696);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(60, 35);
            this.btnLast.TabIndex = 21;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(770, 696);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 35);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageNo
            // 
            this.lblPageNo.AutoSize = true;
            this.lblPageNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNo.Location = new System.Drawing.Point(577, 708);
            this.lblPageNo.Name = "lblPageNo";
            this.lblPageNo.Size = new System.Drawing.Size(17, 23);
            this.lblPageNo.TabIndex = 19;
            this.lblPageNo.Text = "-";
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(330, 702);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(60, 35);
            this.btnPrev.TabIndex = 18;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(232, 702);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(60, 35);
            this.btnFirst.TabIndex = 17;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(31, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Room List";
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.pnTitle.Controls.Add(this.pictureBox1);
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1200, 75);
            this.pnTitle.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(780, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 35);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(232, 160);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(518, 34);
            this.txtSearch.TabIndex = 13;
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.AllowUserToAddRows = false;
            this.dgvRoomList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.RoomNumber,
            this.Type,
            this.RoomPrice,
            this.Occupied});
            this.dgvRoomList.Location = new System.Drawing.Point(232, 203);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.RowHeadersWidth = 51;
            this.dgvRoomList.RowTemplate.Height = 24;
            this.dgvRoomList.Size = new System.Drawing.Size(680, 463);
            this.dgvRoomList.TabIndex = 12;
            this.dgvRoomList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomList_CellContentClick);
            // 
            // RoomID
            // 
            this.RoomID.HeaderText = "Room ID";
            this.RoomID.MinimumWidth = 6;
            this.RoomID.Name = "RoomID";
            this.RoomID.Width = 125;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Room Number";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // RoomPrice
            // 
            this.RoomPrice.HeaderText = "Price";
            this.RoomPrice.MinimumWidth = 6;
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.Width = 125;
            // 
            // Occupied
            // 
            this.Occupied.HeaderText = "Is Occupied";
            this.Occupied.MinimumWidth = 6;
            this.Occupied.Name = "Occupied";
            this.Occupied.Width = 125;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.roomDataSetBindingSource;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagementSystem.Properties.Resources.ico_guestlist;
            this.pictureBox1.Location = new System.Drawing.Point(178, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // roomDataSetBindingSource
            // 
            this.roomDataSetBindingSource.DataSource = this.roomDataSet;
            this.roomDataSetBindingSource.Position = 0;
            // 
            // roomDataSet
            // 
            this.roomDataSet.DataSetName = "RoomDataSet";
            this.roomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // UCRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPageNo);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvRoomList);
            this.Name = "UCRoomList";
            this.Size = new System.Drawing.Size(1200, 850);
            this.Load += new System.EventHandler(this.UCRoomList_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageNo;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.BindingSource roomDataSetBindingSource;
        private RoomDataSet roomDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupied;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private RoomDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
    }
}
