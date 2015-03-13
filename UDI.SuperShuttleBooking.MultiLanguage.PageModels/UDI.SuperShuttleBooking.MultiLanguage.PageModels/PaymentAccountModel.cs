using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    public class PaymentAccountModel
    {
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public NavigationMenu NavigationMenu { get; set; }
        public AirportRideBookingModel AirportRideBooking { get; set; }
        public PointToPointBookingModel PointToPointBooking { get; set; }
        public HourlyCharterBookingModel HourlyCharterBooking { get; set; }

        public string lblPaymentOptionTitle { get; set; }
        public string rdbCreditCards { get; set; }
        public string rdbDirectBillAccounts { get; set; }
        public string btnAddNewCreditCard { get; set; }
        public string btnClose { get; set; }
        public string txtWatermarkAccountCreditCardNo { get; set; }
        public string lblExpirationDate { get; set; }
        public string ddlWatermarkMonth { get; set; }
        public string ddlWatermarkYear { get; set; }
        public string txtWatermarkName { get; set; }
        public string txtWatermarkBillingAddress { get; set; }
        public string txtWatermarkCity { get; set; }
        public string ddlWatermarkState { get; set; }
        public string txtWatermarkZipCode { get; set; }
        public string chkIsDefault { get; set; }
        public string btnSaveUpdate { get; set; }
        public string lblCardType { get; set; }
        public string lblNumber { get; set; }
        public string lblName { get; set; }
        public string lblIsDefault { get; set; }
        public string lblModify { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }


    }
}
