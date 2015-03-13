using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common
{
    public class HourlyCharterBookingModel
    {
        public string lblViewHourlyCharter { get; set; }
        public string lblForPickUp { get; set; }
        public string ddlWatermarkSelectServcieArea { get; set; }
        public string txtWatermarkPickupHotelLandmark { get; set; }
        public string txtWatermarkPickupDate { get; set; }
        public string txtWatermarkPickupTime { get; set; }
        public string lblForDropoff { get; set; }
        public string rdbResidenceOrBusiness { get; set; }
        public string rdbHotelOrLandmark { get; set; }
        public string txtWatermarkDropoffAddress { get; set; }
        public string lblTimeLikeToReserve { get; set; }
        public string ddlWatermarkHours { get; set; }
        public string ddlWatermarkMinutes { get; set; }
        public string btnFindRide { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }


        public BookingInfoModel BookingInfo { get; set; }

    }
}
