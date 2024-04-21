using DevExpress.CodeParser;
using DevExpress.XtraBars.Alerter;
using HotelManagementSystem.Services.Payment;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Views.Payment
{
    public partial class UCPaymentReport : UserControl
    {
        public string ID
        {
            set { hdPaymentId.Text = value; }
        }
        PaymentService paymentService = new PaymentService();
        public UCPaymentReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCPayNow uCPayNow = new UCPayNow();
            uCPayNow.ID = hdPaymentId.Text.ToString();
            this.Controls.Clear();
            this.Controls.Add(uCPayNow);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hdPaymentId.Text))
            {
                int id = int.Parse(hdPaymentId.Text.ToString());
                DataTable dt = paymentService.Get(id);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource datasource = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = @"E:\C-Sharp-ojt-final-project\Final Project\HotelManagementSystem\HotelManagementSystem\Views\Payment\PaymentReport.rdlc";
                reportViewer1.LocalReport.DataSources.Add(datasource);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Something Wrong!", "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
