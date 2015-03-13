using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    class FareModel
    {
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public BookingStepsNavigationModel BookingStepsNavigation { get; set; }
        public AirportRideBookingModel AirportRideBooking { get; set; }
        public PointToPointBookingModel PointToPointBooking { get; set; }
        public HourlyCharterBookingModel HourlyCharterBooking { get; set; }
        public AccountSignInModel AccountSignIn { get; set; }
        public ShoppingCartModel ShoppingCart { get; set; }

        public AirportRideFareModel AirportRideFare { get; set; }
        public PointToPointFareModel PointToPointFare { get; set; }
        public HourlyCharterFareModel HourlyCharterFare { get; set; }

        public string lnkAlreadyHaveAccountSignIn { get; set; }
        public string btnNextStep { get; set; }
        public string lblSelectVehicle { get; set; }
        public string lblOn { get; set; }
        public string lblPickupAt { get; set; }
        public string lblDropoffAt { get; set; }
        public string lblPassengerDetailFor { get; set; }
        public string lblPassengerDetailOn { get; set; }
        public string lblAdultPassenger { get; set; }
        public string lblKidPassenger { get; set; }
        public string lblFoundVehicle { get; set; }
        public string lblRate { get; set; }
        public string btnSelect { get; set; }
        public string btnSelected { get; set; }
        public string lblNeedHelp { get; set; }
        public string lnkCheckFaq { get; set; }
        public string lblCheckFaq { get; set; }
        public string lnkModifySearch { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }

    }
}
