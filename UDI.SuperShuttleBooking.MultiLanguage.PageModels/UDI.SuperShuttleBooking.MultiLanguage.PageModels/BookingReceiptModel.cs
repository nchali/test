using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    class BookingReceiptModel
    {
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public ItineraryModel Itinerary { get; set; }
        public PaymentDetailModel PaymentDetail { get; set; }

        public string lnkAlreadyHaveAccountSignIn { get; set; }
        public string lblBookingReceiptPageTitle { get; set; }
        public string lblBookingReceiptContentHeader { get; set; }
        public string lblBookingReceiptContentInfo1 { get; set; }
        public string lblBookingReceiptContentInfo1Link { get; set; }
        public string lblBookingReceiptContentInfo2 { get; set; }
        public string lnkAddBookingTripit { get; set; }
        public string lblAddBookingTripitInfo { get; set; }
        public string lblChildSeatPolicy { get; set; }
        public string lblChildSeatPolicyInfo { get; set; }
        public string lblOversizedLuggage { get; set; }
        public string lblOversizedLuggageInfo { get; set; }
        public string lblTotalCost { get; set; }
        public string lblAdditionalPassengers { get; set; }
        public string lblTotalVehicleFare { get; set; }
        public string lblDiscountForCode { get; set; }
        public string lblTax { get; set; }
        public string lblTolls { get; set; }
        public string lblFuelSurchargeFee { get; set; }
        public string lblNysBlackCarSurcharge { get; set; }
        public string lnkGoToMyAccount { get; set; }
        public string lnkBookAnotherRide { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }



    }
}
