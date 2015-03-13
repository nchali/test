using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    public class PointToPointBookingModel
    {
        public string lblViewNonAirport { get; set; }
        public string lblForPickUp { get; set; }
        public string rdbResidenceOrBusiness { get; set; }
        public string rdbHotelOrLandmark { get; set; }
        public string lblSignInNowInfo1 { get; set; }
        public string lnkSignInNow { get; set; }
        public string lblSignInNowInfo2 { get; set; }
        public string txtWatermarkPickupAddress { get; set; }
        public string txtWatermarkPickupDate { get; set; }
        public string txtWatermarkPickupTime { get; set; }
        public string lblForDropoff { get; set; }
        public string ddlWatermarkSelectServcieArea { get; set; }
        public string txtDropOffHotelOrLandmark { get; set; }
        public string btnFindRide { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }

        public BookingInfoModel BookingInfo { get; set; }

    }
}
