using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    class BookingConfirmationModel
    {
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public BookingStepsNavigationModel BookingStepsNavigation { get; set; }
        public ItineraryModel Itinerary { get; set; }
        public PaymentDetailModel PaymentDetail { get; set; }
        public AccountSignInModel AccountSignIn { get; set; }


        public string lnkAlreadyHaveAccountSignIn { get; set; }
        public string lblConfirmBookingContentHeader { get; set; }
        public string lblConfirmBookingContentInfo { get; set; }
        public string lblSendEmail { get; set; }
        public string txtWatermarkEmailID { get; set; }
        public string chkTravelDiscountAndSpecialOffers { get; set; }
        public string lblEnterPasswordHere { get; set; }
        public string lblHaveAnAccount { get; set; }
        public string txtWatermarkPasswordNewAccount { get; set; }
        public string lblAlreadyHaveAccountSignIn { get; set; }
        public string lblTotalCost { get; set; }
        public string lblTotalVehicleFare { get; set; }
        public string lblDiscountForCode { get; set; }
        public string lblDiscount { get; set; }
        public string lblTip { get; set; }
        public string lblTax { get; set; }
        public string lblTolls { get; set; }
        public string lblFuelSurchargeFee { get; set; }
        public string lblNysBlackCarSurcharge { get; set; }
        public string lnktermsAndConditions { get; set; }
        public string lblNeedHelp { get; set; }
        public string lnkCheckFaq { get; set; }
        public string lblCheckFaq { get; set; }
        public string BookingRideInvalid { get; set; }
        public string btnBookNow { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }




    }
}
