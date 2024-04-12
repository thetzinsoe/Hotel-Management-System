namespace HotelManagementSystem
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestCRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnUC = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationToolStripMenuItem,
            this.guestInformationToolStripMenuItem,
            this.roomInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 59);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(132, 55);
            this.reservationToolStripMenuItem.Text = "Reservation";
            // 
            // guestInformationToolStripMenuItem
            // 
            this.guestInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestCRUDToolStripMenuItem,
            this.guestListingToolStripMenuItem});
            this.guestInformationToolStripMenuItem.Name = "guestInformationToolStripMenuItem";
            this.guestInformationToolStripMenuItem.Size = new System.Drawing.Size(193, 55);
            this.guestInformationToolStripMenuItem.Text = "Guest Information";
            // 
            // roomInformationToolStripMenuItem
            // 
            this.roomInformationToolStripMenuItem.Name = "roomInformationToolStripMenuItem";
            this.roomInformationToolStripMenuItem.Size = new System.Drawing.Size(193, 55);
            this.roomInformationToolStripMenuItem.Text = "Room Information";
            // 
            // guestCRUDToolStripMenuItem
            // 
            this.guestCRUDToolStripMenuItem.Name = "guestCRUDToolStripMenuItem";
            this.guestCRUDToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.guestCRUDToolStripMenuItem.Text = "Guest CRUD";
            this.guestCRUDToolStripMenuItem.Click += new System.EventHandler(this.guestCRUDToolStripMenuItem_Click);
            // 
            // guestListingToolStripMenuItem
            // 
            this.guestListingToolStripMenuItem.Name = "guestListingToolStripMenuItem";
            this.guestListingToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.guestListingToolStripMenuItem.Text = "Guest Listing";
            // 
            // pnUC
            // 
            this.pnUC.Location = new System.Drawing.Point(72, 103);
            this.pnUC.Name = "pnUC";
            this.pnUC.Size = new System.Drawing.Size(750, 700);
            this.pnUC.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.pnUC);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestCRUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomInformationToolStripMenuItem;
        private System.Windows.Forms.Panel pnUC;
    }
}

