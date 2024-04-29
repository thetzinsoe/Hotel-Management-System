using System.Drawing;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOOMENTRYLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESERVATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUESTINFOMATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEEREGISTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEELISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKINLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKADDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKINLISTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pAYMENTHISTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAYMENTLISTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pAYMENTLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
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
            // mainMenu
            // 
            this.mainMenu.AutoSize = false;
            this.mainMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashBoardToolStripMenuItem,
            this.rOOMENTRYLISTToolStripMenuItem,
            this.rESERVATIONToolStripMenuItem,
            this.gUESTINFOMATIONToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cHECKINLISTToolStripMenuItem,
            this.pAYMENTHISTORYToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1105, 50);
            this.mainMenu.TabIndex = 15;
            this.mainMenu.Text = "menuStrip1";
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.AutoToolTip = true;
            this.dashBoardToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.dashBoardToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(145, 46);
            this.dashBoardToolStripMenuItem.Text = "DASHBOARD";
            this.dashBoardToolStripMenuItem.Click += new System.EventHandler(this.dashBoardToolStripMenuItem_Click);
            // 
            // rOOMENTRYLISTToolStripMenuItem
            // 
            this.rOOMENTRYLISTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoomToolStripMenuItem,
            this.roomListToolStripMenuItem});
            this.rOOMENTRYLISTToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.rOOMENTRYLISTToolStripMenuItem.Name = "rOOMENTRYLISTToolStripMenuItem";
            this.rOOMENTRYLISTToolStripMenuItem.Size = new System.Drawing.Size(86, 46);
            this.rOOMENTRYLISTToolStripMenuItem.Text = "ROOM";
            // 
            // addRoomToolStripMenuItem
            // 
            this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.addRoomToolStripMenuItem.Text = "ROOM ADD";
            this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
            // 
            // roomListToolStripMenuItem
            // 
            this.roomListToolStripMenuItem.Name = "roomListToolStripMenuItem";
            this.roomListToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.roomListToolStripMenuItem.Text = "ROOM LIST";
            this.roomListToolStripMenuItem.Click += new System.EventHandler(this.roomListToolStripMenuItem_Click);
            // 
            // rESERVATIONToolStripMenuItem
            // 
            this.rESERVATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationListToolStripMenuItem,
            this.reservationAddToolStripMenuItem});
            this.rESERVATIONToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.rESERVATIONToolStripMenuItem.Name = "rESERVATIONToolStripMenuItem";
            this.rESERVATIONToolStripMenuItem.Size = new System.Drawing.Size(152, 46);
            this.rESERVATIONToolStripMenuItem.Text = "RESERVATION";
            // 
            // reservationListToolStripMenuItem
            // 
            this.reservationListToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.reservationListToolStripMenuItem.Name = "reservationListToolStripMenuItem";
            this.reservationListToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.reservationListToolStripMenuItem.Text = "RESERVATION LIST";
            this.reservationListToolStripMenuItem.Click += new System.EventHandler(this.reservationListToolStripMenuItem_Click);
            // 
            // reservationAddToolStripMenuItem
            // 
            this.reservationAddToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.reservationAddToolStripMenuItem.Name = "reservationAddToolStripMenuItem";
            this.reservationAddToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.reservationAddToolStripMenuItem.Text = "RESERVATION ADD";
            this.reservationAddToolStripMenuItem.Click += new System.EventHandler(this.reservationAddToolStripMenuItem_Click);
            // 
            // gUESTINFOMATIONToolStripMenuItem
            // 
            this.gUESTINFOMATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestRegistrationToolStripMenuItem,
            this.guestListToolStripMenuItem});
            this.gUESTINFOMATIONToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.gUESTINFOMATIONToolStripMenuItem.Name = "gUESTINFOMATIONToolStripMenuItem";
            this.gUESTINFOMATIONToolStripMenuItem.Size = new System.Drawing.Size(86, 46);
            this.gUESTINFOMATIONToolStripMenuItem.Text = "GUEST";
            // 
            // guestRegistrationToolStripMenuItem
            // 
            this.guestRegistrationToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.guestRegistrationToolStripMenuItem.Name = "guestRegistrationToolStripMenuItem";
            this.guestRegistrationToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.guestRegistrationToolStripMenuItem.Text = "GUEST REGISTRATION";
            this.guestRegistrationToolStripMenuItem.Click += new System.EventHandler(this.guestRegistrationToolStripMenuItem_Click);
            // 
            // guestListToolStripMenuItem
            // 
            this.guestListToolStripMenuItem.Name = "guestListToolStripMenuItem";
            this.guestListToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.guestListToolStripMenuItem.Text = "GUEST LIST";
            this.guestListToolStripMenuItem.Click += new System.EventHandler(this.guestListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMPLOYEEREGISTRATIONToolStripMenuItem,
            this.eMPLOYEELISTToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 46);
            this.toolStripMenuItem1.Text = "EMPLOYEE";
            // 
            // eMPLOYEEREGISTRATIONToolStripMenuItem
            // 
            this.eMPLOYEEREGISTRATIONToolStripMenuItem.Name = "eMPLOYEEREGISTRATIONToolStripMenuItem";
            this.eMPLOYEEREGISTRATIONToolStripMenuItem.Size = new System.Drawing.Size(335, 32);
            this.eMPLOYEEREGISTRATIONToolStripMenuItem.Text = "EMPLOYEE REGISTRATION";
            this.eMPLOYEEREGISTRATIONToolStripMenuItem.Click += new System.EventHandler(this.eMPLOYEEREGISTRATIONToolStripMenuItem_Click);
            // 
            // eMPLOYEELISTToolStripMenuItem
            // 
            this.eMPLOYEELISTToolStripMenuItem.Name = "eMPLOYEELISTToolStripMenuItem";
            this.eMPLOYEELISTToolStripMenuItem.Size = new System.Drawing.Size(335, 32);
            this.eMPLOYEELISTToolStripMenuItem.Text = "EMPLOYEE LIST";
            this.eMPLOYEELISTToolStripMenuItem.Click += new System.EventHandler(this.eMPLOYEELISTToolStripMenuItem_Click);
            // 
            // cHECKINLISTToolStripMenuItem
            // 
            this.cHECKINLISTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHECKADDToolStripMenuItem,
            this.cHECKINLISTToolStripMenuItem1});
            this.cHECKINLISTToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cHECKINLISTToolStripMenuItem.Name = "cHECKINLISTToolStripMenuItem";
            this.cHECKINLISTToolStripMenuItem.Size = new System.Drawing.Size(114, 46);
            this.cHECKINLISTToolStripMenuItem.Text = "CHECK IN";
            // 
            // cHECKADDToolStripMenuItem
            // 
            this.cHECKADDToolStripMenuItem.Name = "cHECKADDToolStripMenuItem";
            this.cHECKADDToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.cHECKADDToolStripMenuItem.Text = "CHECK IN ADD";
            this.cHECKADDToolStripMenuItem.Click += new System.EventHandler(this.cHECKADDToolStripMenuItem_Click);
            // 
            // cHECKINLISTToolStripMenuItem1
            // 
            this.cHECKINLISTToolStripMenuItem1.Name = "cHECKINLISTToolStripMenuItem1";
            this.cHECKINLISTToolStripMenuItem1.Size = new System.Drawing.Size(233, 32);
            this.cHECKINLISTToolStripMenuItem1.Text = "CHECK IN LIST";
            this.cHECKINLISTToolStripMenuItem1.Click += new System.EventHandler(this.cHECKINLISTToolStripMenuItem1_Click);
            // 
            // pAYMENTHISTORYToolStripMenuItem
            // 
            this.pAYMENTHISTORYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pAYMENTLISTToolStripMenuItem1});
            this.pAYMENTHISTORYToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pAYMENTHISTORYToolStripMenuItem.Name = "pAYMENTHISTORYToolStripMenuItem";
            this.pAYMENTHISTORYToolStripMenuItem.Size = new System.Drawing.Size(114, 46);
            this.pAYMENTHISTORYToolStripMenuItem.Text = "PAYMENT";
            // 
            // pAYMENTLISTToolStripMenuItem1
            // 
            this.pAYMENTLISTToolStripMenuItem1.Name = "pAYMENTLISTToolStripMenuItem1";
            this.pAYMENTLISTToolStripMenuItem1.Size = new System.Drawing.Size(230, 32);
            this.pAYMENTLISTToolStripMenuItem1.Text = "PAYMENT LIST";
            this.pAYMENTLISTToolStripMenuItem1.Click += new System.EventHandler(this.pAYMENTLISTToolStripMenuItem1_Click);
            // 
            // pAYMENTLISTToolStripMenuItem
            // 
            this.pAYMENTLISTToolStripMenuItem.Name = "pAYMENTLISTToolStripMenuItem";
            this.pAYMENTLISTToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.pAYMENTLISTToolStripMenuItem.Text = "PAYMENT LIST";
            this.pAYMENTLISTToolStripMenuItem.Click += new System.EventHandler(this.pAYMENTLISTToolStripMenuItem_Click);
            // 
            // pnMain
            // 
            this.pnMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnMain.BackColor = System.Drawing.Color.LightGray;
            this.pnMain.Location = new System.Drawing.Point(0, 50);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1102, 698);
            this.pnMain.TabIndex = 16;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(993, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1105, 749);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private MenuStrip mainMenu;
        private ToolStripMenuItem dashBoardToolStripMenuItem;
        private ToolStripMenuItem rESERVATIONToolStripMenuItem;
        private ToolStripMenuItem gUESTINFOMATIONToolStripMenuItem;
        private ToolStripMenuItem rOOMENTRYLISTToolStripMenuItem;
        private Panel pnMain;
        private ToolStripMenuItem reservationListToolStripMenuItem;
        private ToolStripMenuItem reservationAddToolStripMenuItem;
        private ToolStripMenuItem cHECKINLISTToolStripMenuItem;
        private ToolStripMenuItem pAYMENTHISTORYToolStripMenuItem;
        private ToolStripMenuItem cHECKADDToolStripMenuItem;
        private ToolStripMenuItem cHECKINLISTToolStripMenuItem1;
        private ToolStripMenuItem pAYMENTLISTToolStripMenuItem;
        private ToolStripMenuItem guestRegistrationToolStripMenuItem;
        private ToolStripMenuItem guestListToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem eMPLOYEEREGISTRATIONToolStripMenuItem;
        private ToolStripMenuItem eMPLOYEELISTToolStripMenuItem;
        private ToolStripMenuItem addRoomToolStripMenuItem;
        private ToolStripMenuItem roomListToolStripMenuItem;
        private ToolStripMenuItem pAYMENTLISTToolStripMenuItem1;
        private Button btnLogout;
    }
}