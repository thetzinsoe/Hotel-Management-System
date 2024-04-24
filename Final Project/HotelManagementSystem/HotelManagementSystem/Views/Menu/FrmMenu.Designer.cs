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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESERVATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUESTINFOMATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOOMENTRYLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKINLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKADDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKINLISTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pAYMENTHISTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAYMENTLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAYMENTADDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
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
            this.menuStrip1.Size = new System.Drawing.Size(1105, 65);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.AutoToolTip = true;
            this.dashBoardToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.dashBoardToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(145, 61);
            this.dashBoardToolStripMenuItem.Text = "DASHBOARD";
            this.dashBoardToolStripMenuItem.Click += new System.EventHandler(this.dashBoardToolStripMenuItem_Click);
            // 
            // rESERVATIONToolStripMenuItem
            // 
            this.rESERVATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationListToolStripMenuItem,
            this.reservationAddToolStripMenuItem});
            this.rESERVATIONToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.rESERVATIONToolStripMenuItem.Name = "rESERVATIONToolStripMenuItem";
            this.rESERVATIONToolStripMenuItem.Size = new System.Drawing.Size(152, 61);
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
            this.gUESTINFOMATIONToolStripMenuItem.Size = new System.Drawing.Size(227, 61);
            this.gUESTINFOMATIONToolStripMenuItem.Text = "GUEST INFORMATION";
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
            // rOOMENTRYLISTToolStripMenuItem
            // 
            this.rOOMENTRYLISTToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.rOOMENTRYLISTToolStripMenuItem.Name = "rOOMENTRYLISTToolStripMenuItem";
            this.rOOMENTRYLISTToolStripMenuItem.Size = new System.Drawing.Size(227, 61);
            this.rOOMENTRYLISTToolStripMenuItem.Text = "ROOM INFORMATION";
            // 
            // cHECKINLISTToolStripMenuItem
            // 
            this.cHECKINLISTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHECKADDToolStripMenuItem,
            this.cHECKINLISTToolStripMenuItem1});
            this.cHECKINLISTToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cHECKINLISTToolStripMenuItem.Name = "cHECKINLISTToolStripMenuItem";
            this.cHECKINLISTToolStripMenuItem.Size = new System.Drawing.Size(114, 61);
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
            this.pAYMENTLISTToolStripMenuItem,
            this.pAYMENTADDToolStripMenuItem});
            this.pAYMENTHISTORYToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pAYMENTHISTORYToolStripMenuItem.Name = "pAYMENTHISTORYToolStripMenuItem";
            this.pAYMENTHISTORYToolStripMenuItem.Size = new System.Drawing.Size(201, 61);
            this.pAYMENTHISTORYToolStripMenuItem.Text = "PAYMENT HISTORY";
            // 
            // pAYMENTLISTToolStripMenuItem
            // 
            this.pAYMENTLISTToolStripMenuItem.Name = "pAYMENTLISTToolStripMenuItem";
            this.pAYMENTLISTToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.pAYMENTLISTToolStripMenuItem.Text = "PAYMENT LIST";
            this.pAYMENTLISTToolStripMenuItem.Click += new System.EventHandler(this.pAYMENTLISTToolStripMenuItem_Click);
            // 
            // pAYMENTADDToolStripMenuItem
            // 
            this.pAYMENTADDToolStripMenuItem.Name = "pAYMENTADDToolStripMenuItem";
            this.pAYMENTADDToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.pAYMENTADDToolStripMenuItem.Text = "PAYMENT ADD";
            this.pAYMENTADDToolStripMenuItem.Click += new System.EventHandler(this.pAYMENTADDToolStripMenuItem_Click);
            // 
            // pnMain
            // 
            this.pnMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnMain.BackColor = System.Drawing.Color.LightGray;
            this.pnMain.Location = new System.Drawing.Point(1, 65);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1102, 698);
            this.pnMain.TabIndex = 16;
            // 
            // FrmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1105, 775);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnMain = new System.Windows.Forms.Panel();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(0, 50);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1200, 850);
            this.pnMain.TabIndex = 1;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 46);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(60, 46);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;

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
        private ToolStripMenuItem cHECKADDToolStripMenuItem;
        private ToolStripMenuItem cHECKINLISTToolStripMenuItem1;
        private ToolStripMenuItem pAYMENTLISTToolStripMenuItem;
        private ToolStripMenuItem pAYMENTADDToolStripMenuItem;
        private ToolStripMenuItem guestRegistrationToolStripMenuItem;
        private ToolStripMenuItem guestListToolStripMenuItem;
    }
}