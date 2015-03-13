using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    class BookingWidgetModel
    {
        public Header Header;
        public Footer Footer;
        public BookingStepsNavigationModel BookingStepsNavigation;
        public AirportRideBookingModel AirportRideBooking;
        public PointToPointBookingModel PointToPointBooking;
        public HourlyCharterBookingModel HourlyCharterBooking;
        public AccountSignInModel AccountSignIn;
        public ShoppingCartModel ShoppingCart;


        public string lnkAlreadyHaveAccountSignIn { get; set; }
        public string lblSearchRideType { get; set; }
        public string lblNeedHelp { get; set; }
        public string lnkCheckFaq { get; set; }
        public string lblCheckFaq { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }



    }
}
