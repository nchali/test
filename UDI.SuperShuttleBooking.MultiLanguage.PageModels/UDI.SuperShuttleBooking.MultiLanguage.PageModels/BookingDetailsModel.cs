using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    public class BookingDetailsModel
    {
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public BookingStepsNavigationModel BookingStepsNavigation { get; set; }
        public AccountSignInModel AccountSignIn { get; set; }
        public ShoppingCartModel ShoppingCart { get; set; }
        public AirportRideFareModel AirportRideFare { get; set; }
        public PointToPointFareModel PointToPointFare { get; set; }
        public HourlyCharterFareModel HourlyCharterFare { get; set; }
        public PassengerDetailsModel PassengerDetails { get; set; }

        public string lnkAlreadyHaveAccountSignIn { get; set; }
        public string lblForYourRide { get; set; }
        public string lblPickupAt { get; set; }
        public string lblDropoffAt { get; set; }
        public string lblPassengerDetailFor { get; set; }
        public string lblPassengerDetailOn { get; set; }
        public string lblAdultPassenger { get; set; }
        public string lblKidPassenger { get; set; }
        public string lblRate { get; set; }
        public string lblExclutingTax { get; set; }
        public string lblChoosePickup { get; set; }
        public string lblPickupTimeInfo { get; set; }
        public string btmContinuePayment { get; set; }
        public string btnAddRide { get; set; }
        public string btnAddToCart { get; set; }
        public string lblNeedHelp { get; set; }
        public string lnkCheckFaq { get; set; }
        public string lblCheckFaq { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }

        public string lblVehicleRequest { get; set; }
        public string lblVehicleRequestMsg { get; set; }
        public string txtWatermarkVehicleNo { get; set; }
        public string lblNote { get; set; }

        public string lblSpecialInstruction { get; set; }
        public string lblSpecialInstructionMsg { get; set; }
        public string txtWatermarkComments { get; set; }

    }

}
