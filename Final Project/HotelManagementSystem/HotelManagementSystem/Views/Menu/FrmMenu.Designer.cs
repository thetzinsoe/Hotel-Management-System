﻿using System.Drawing;
using System.Windows.Forms;

namespace HotelManagementSystem.Views.Menu
{
    partial class FrmMenu
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESERVATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUESTINFOMATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOOMENTRYLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.cHECKINLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAYMENTHISTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(1084, 668);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashBoardToolStripMenuItem,
            this.rESERVATIONToolStripMenuItem,
            this.gUESTINFOMATIONToolStripMenuItem,
            this.rOOMENTRYLISTToolStripMenuItem,
            this.cHECKINLISTToolStripMenuItem,
            this.pAYMENTHISTORYToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1084, 65);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.AutoToolTip = true;
            this.dashBoardToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.dashBoardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(119, 61);
            this.dashBoardToolStripMenuItem.Text = "DASHBOARD";
            this.dashBoardToolStripMenuItem.Click += new System.EventHandler(this.dashBoardToolStripMenuItem_Click);
            // 
            // rESERVATIONToolStripMenuItem
            // 
            this.rESERVATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationListToolStripMenuItem,
            this.reservationAddToolStripMenuItem});
            this.rESERVATIONToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rESERVATIONToolStripMenuItem.Name = "rESERVATIONToolStripMenuItem";
            this.rESERVATIONToolStripMenuItem.Size = new System.Drawing.Size(124, 61);
            this.rESERVATIONToolStripMenuItem.Text = "RESERVATION";
            this.rESERVATIONToolStripMenuItem.Click += new System.EventHandler(this.rESERVATIONToolStripMenuItem_Click);
            // 
            // reservationListToolStripMenuItem
            // 
            this.reservationListToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.reservationListToolStripMenuItem.Name = "reservationListToolStripMenuItem";
            this.reservationListToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.reservationListToolStripMenuItem.Text = "Reservation List";
            this.reservationListToolStripMenuItem.Click += new System.EventHandler(this.reservationListToolStripMenuItem_Click);
            // 
            // reservationAddToolStripMenuItem
            // 
            this.reservationAddToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.reservationAddToolStripMenuItem.Name = "reservationAddToolStripMenuItem";
            this.reservationAddToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.reservationAddToolStripMenuItem.Text = "Reservation Add";
            this.reservationAddToolStripMenuItem.Click += new System.EventHandler(this.reservationAddToolStripMenuItem_Click);
            // 
            // gUESTINFOMATIONToolStripMenuItem
            // 
            this.gUESTINFOMATIONToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gUESTINFOMATIONToolStripMenuItem.Name = "gUESTINFOMATIONToolStripMenuItem";
            this.gUESTINFOMATIONToolStripMenuItem.Size = new System.Drawing.Size(184, 61);
            this.gUESTINFOMATIONToolStripMenuItem.Text = "GUEST INFORMATION";
            // 
            // rOOMENTRYLISTToolStripMenuItem
            // 
            this.rOOMENTRYLISTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rOOMENTRYLISTToolStripMenuItem.Name = "rOOMENTRYLISTToolStripMenuItem";
            this.rOOMENTRYLISTToolStripMenuItem.Size = new System.Drawing.Size(185, 61);
            this.rOOMENTRYLISTToolStripMenuItem.Text = "ROOM INFORMATION";
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.LightGray;
            this.pnMain.Location = new System.Drawing.Point(0, 65);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1084, 697);
            this.pnMain.TabIndex = 16;
            // 
            // cHECKINLISTToolStripMenuItem
            // 
            this.cHECKINLISTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cHECKINLISTToolStripMenuItem.Name = "cHECKINLISTToolStripMenuItem";
            this.cHECKINLISTToolStripMenuItem.Size = new System.Drawing.Size(124, 61);
            this.cHECKINLISTToolStripMenuItem.Text = "CHECKIN LIST";
            this.cHECKINLISTToolStripMenuItem.Click += new System.EventHandler(this.cHECKINLISTToolStripMenuItem_Click);
            // 
            // pAYMENTHISTORYToolStripMenuItem
            // 
            this.pAYMENTHISTORYToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pAYMENTHISTORYToolStripMenuItem.Name = "pAYMENTHISTORYToolStripMenuItem";
            this.pAYMENTHISTORYToolStripMenuItem.Size = new System.Drawing.Size(162, 61);
            this.pAYMENTHISTORYToolStripMenuItem.Text = "PAYMENT HISTORY";
            this.pAYMENTHISTORYToolStripMenuItem.Click += new System.EventHandler(this.pAYMENTHISTORYToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holtel Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashBoardToolStripMenuItem;
        private ToolStripMenuItem rESERVATIONToolStripMenuItem;
        private ToolStripMenuItem gUESTINFOMATIONToolStripMenuItem;
        private ToolStripMenuItem rOOMENTRYLISTToolStripMenuItem;
        private Panel pnMain;
        private ToolStripMenuItem reservationListToolStripMenuItem;
        private ToolStripMenuItem reservationAddToolStripMenuItem;
        private ToolStripMenuItem cHECKINLISTToolStripMenuItem;
        private ToolStripMenuItem pAYMENTHISTORYToolStripMenuItem;
    }
}