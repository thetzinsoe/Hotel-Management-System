using HotelManagementSystem.Entities.Payment;
using HotelManagementSystem.Entities.Reservation;
using HotelManagementSystem.Services.CheckIn;
using HotelManagementSystem.Services.Payment;
using HotelManagementSystem.Services.Reservation;
using HotelManagementSystem.Views.CheckIn;
using HotelManagementSystem.Views.Reservation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Views.Payment
{
    public partial class UCPayNow : UserControl
    {
        bool checkInput = false;
        decimal totalFees = 0.00m;
        int roomId = 0;
        decimal roomFees = 0.00m;
        decimal extraFees = 0.00m;
        decimal discount = 0.00m;
        int totalDays = 0;
        DateTime checkIn, checkOut;
        CheckInService checkInService = new CheckInService();
        PaymentService paymentService = new PaymentService();
        ReservationService reservationService = new ReservationService();
        public string ID
        {
            set { hdPaymentId.Text = value; }
        }

        public UCPayNow()
        {
            InitializeComponent();
        }

        public UCPayNow(int checkinId, int room_id, decimal roomFee, DateTime checkInDate, DateTime checkOutDate)
        {
            InitializeComponent();
            txtCheckInId.Text = checkinId.ToString();
            roomId = room_id;
            roomFees = roomFee;
            checkIn = checkInDate;
            checkOut = checkOutDate;
        }

        private void UCPayNow_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hdPaymentId.Text.ToString()))
            {
                btnConfirm.Enabled = false;
                lbTitle.Text = "PAYMENT DETAIL";
            }
            else
            {
                btnPrint.Enabled = false;
                lbTitle.Text = "PAY NOW";
            }
            BindData();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbPaymentType.SelectedIndex < 0)
            {
                checkInput = false;
                MessageBox.Show("You must choose Payment Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                 checkInput=true;
                //lbPaymentTypeValidation.Text = "";
            }

            if (checkInput)
            {
                DialogResult result = MessageBox.Show("Are you sure to payment!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    AddorUpdate();
                }
            }
            else
            {
                MessageBox.Show("Somethig wrong in loading data!", "Error", MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                return;
            }

        }

        private void AddorUpdate()
        {
            if (!string.IsNullOrEmpty(txtCheckInId.Text.ToString()))
            {
                PaymentEntity paymentEntity = CreateData();
                ReservationService reservationService = new ReservationService();
                int Reid = reservationService.FindReservationId(roomId, checkIn.Date, checkOut.Date);
                if (Reid <= 0)
                {
                    MessageBox.Show("Reservation not Found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    reservationService.Delete(Reid);
                }
                bool success = paymentService.Insert(paymentEntity);
                bool delCheckin = checkInService.Delete(int.Parse(txtCheckInId.Text.ToString()));
                DataTable dt = reservationService.haveRoom(roomId);
                bool upRoom=true;
                if (dt.Rows.Count == 0)
                {
                    upRoom = reservationService.RoomUpdate(roomId, 0);
                }
                if (success && delCheckin && upRoom)
                {
                    MessageBox.Show("Payment Success.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    UCPaymentHistory uCPaymentHistory = new UCPaymentHistory();
                    this.Controls.Clear();
                    this.Controls.Add(uCPaymentHistory);
                }
                else
                {
                    MessageBox.Show("Something Wrong in Payment!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Wrong Input!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
        private PaymentEntity CreateData()
        {
            if (!string.IsNullOrEmpty(txtCheckInId.Text.ToString()))
            {
                PaymentEntity paymentEntity = new PaymentEntity();
                paymentEntity.checkin_id = int.Parse(txtCheckInId.Text.ToString());
                paymentEntity.room_fees = decimal.Parse(txtRoomFees.Text.ToString());
                paymentEntity.extra_fees = decimal.Parse(txtExtraFees.Text.ToString());
                paymentEntity.description = rtxtDescription.Text.ToString();
                paymentEntity.discount = decimal.Parse(txtDiscount.Text.ToString());
                paymentEntity.payment_type = cbPaymentType.SelectedItem.ToString();
                paymentEntity.total_fees = decimal.Parse(txtTotalAmount.Text.ToString());
                paymentEntity.created_date = DateTime.Today;
                paymentEntity.updated_date = DateTime.Today;
                return paymentEntity;
            }
            else
            {
                return null;
            }
        }

        private void BindData()
        {
            if (string.IsNullOrEmpty(hdPaymentId.Text.ToString()))
            {
                try
                {
                    TimeSpan duration = checkOut - checkIn;
                    totalDays = (int)duration.TotalDays;
                    totalDays = totalDays == 0 ? 1 : totalDays;
                    txtRoomFees.Text = (roomFees * totalDays).ToString();
                    txtDuration.Text = totalDays.ToString()+" days";
                    txtTotalAmount.Text = calculateTotal().ToString("0.00");

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                try
                {
                    DataTable dt = paymentService.Get(int.Parse(hdPaymentId.Text.ToString()));
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txtCheckInId.Text = dt.Rows[0]["checkin_id"].ToString();
                            txtRoomFees.Text = dt.Rows[0]["room_fees"].ToString();
                            txtExtraFees.Text = dt.Rows[0]["extra_fees"].ToString();
                            TimeSpan duration = DateTime.Parse(dt.Rows[0]["checkout_date"].ToString()) - DateTime.Parse(dt.Rows[0]["checkin_date"].ToString());
                            totalDays = (int)duration.TotalDays;
                            txtDuration.Text = totalDays.ToString() + " days";
                            rtxtDescription.Text = dt.Rows[0]["description"].ToString();
                            txtDiscount.Text = dt.Rows[0]["discount"].ToString();
                            cbPaymentType.Text = dt.Rows[0]["payment_type"].ToString();
                            txtTotalAmount.Text = dt.Rows[0]["total_fees"].ToString();
                        }
                    }
                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hdPaymentId.Text.ToString()))
            {
                UCCheckInList uCCheckInlist = new UCCheckInList();
                this.Controls.Clear();
                this.Controls.Add(uCCheckInlist);
            }
            else
            {
                UCPaymentHistory uCPaymentHistory = new UCPaymentHistory();
                this.Controls.Clear();
                this.Controls.Add(uCPaymentHistory);
            }
        }

        private void txtExtraFees_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtExtraFees.Text.ToString())){
                bool isDigit = txtExtraFees.Text.Any(c => char.IsDigit(c));
                if (isDigit)
                {
                    checkInput = true;
                    lbExtraFeesValidation.Text = string.Empty;
                    extraFees = decimal.Parse(txtExtraFees.Text.ToString());
                    BindData();
                }
                else
                {
                    checkInput = false;
                    lbExtraFeesValidation.Text = "Invalid input!";
                }
            }
        }

        private void txtDiscount_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiscount.Text.ToString()))
            {
                bool isDigit = txtDiscount.Text.Any(c => char.IsDigit(c));
                if (isDigit)
                {
                    checkInput = true;
                    lbDiscountValidation.Text = "";
                    discount = decimal.Parse(txtDiscount.Text.ToString());
                    BindData();
                }
                else
                {
                    checkInput = false;
                    lbDiscountValidation.Text = "Invalid input!";
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            UCPaymentReport uCPaymentReport = new UCPaymentReport();
            uCPaymentReport.ID = hdPaymentId.Text.ToString();
            this.Controls.Clear();
            this.Controls.Add(uCPaymentReport);
        }

        private decimal calculateTotal()
        {
            decimal subTotal = (roomFees * totalDays) + extraFees;
            decimal discountAmount = (roomFees * totalDays) * (discount / 100);
            return subTotal - discountAmount;
        }
    }
}
