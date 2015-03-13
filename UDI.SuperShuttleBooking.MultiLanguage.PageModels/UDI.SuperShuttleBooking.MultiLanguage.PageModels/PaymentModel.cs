using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    class PaymentModel
    {

        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public BookingStepsNavigationModel BookingStepsNavigation { get; set; }
        public AccountSignInModel AccountSignIn { get; set; }
        public ShoppingCartModel ShoppingCart { get; set; }
        public PaymentInfoModel PaymentInfo { get; set; }
        public AirlineRewardAccountModel AirlineRewardAccount { get; set; }


        public string lnkAlreadyHaveAccountSignIn { get; set; }
        public string lblForYourRide { get; set; }
        public string lblPickupAt { get; set; }
        public string lblDropoffAt { get; set; }
        public string lblAdultPassenger { get; set; }
        public string lblKidPassenger { get; set; }
        public string lblPassengerDetailFor { get; set; }
        public string lblRate { get; set; }
        public string lblPlus { get; set; }
        public string lblTip { get; set; }
        public string ddlWatermarkAddGratuity { get; set; }
        public string ddlAddGratuityItem { get; set; }
        public string lblWhatAirportFlying { get; set; }
        public string ddlWatermarkPDX { get; set; }
        public string lblWhatAirportFlyingInfo { get; set; }
        public string btnContinueToCheckout { get; set; }
        public string lblNeedHelp { get; set; }
        public string lnkCheckFaq { get; set; }
        public string lblCheckFaq { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }



    }

    public class PaymentInfoModel
    {
        public string lblPreferedPaymentMethod { get; set; }
        public string ddlWatermarkPaymentOption { get; set; }
        public string lblProvideCreditCardDetails { get; set; }
        public string lblExisitingCreditCard { get; set; }
        public string ddlWatermarkExisitingCreditCard { get; set; }
        public string lblEnterNewCard { get; set; }
        public string ddlCreditCardType { get; set; }
        public string txtWatermarkCreditCardNumber { get; set; }
        public string ddlWatermarkMonth { get; set; }
        public string ddlWatermarkYear { get; set; }
        public string txtWatermarkSecurityCode { get; set; }
        public string chkSaveToAccount { get; set; }
        public string chkAddressOutsideUs { get; set; }
        public string chkBillingAddress { get; set; }
        public string txtWatermarkBillingAddress { get; set; }
        public string txtWatermarkAptSte { get; set; }
        public string txtWatermarkCity { get; set; }
        public string ddlWatermarkState { get; set; }
        public string txtWatermarkZipCode { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }


    }

    public class AirlineRewardAccountModel
    {
        public string lblAirlineRewardAccount { get; set; }
        public string lblAirlineRewardAccountInfo { get; set; }
        public string lblSelectAccount { get; set; }
        public string ddlWatermarkAirlineRewardAccount { get; set; }
        public string txtWatermarkAccountNumber { get; set; }
        public string lblNewAccount { get; set; }
        public string txtWatermarkAccountName { get; set; }
        public string chkSaveToAccount { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }


    }


}
