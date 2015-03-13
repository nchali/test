using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    public class AirlineRewardModel
    {
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public NavigationMenu NavigationMenu { get; set; }
        public AirportRideBookingModel AirportRideBooking { get; set; }
        public PointToPointBookingModel PointToPointBooking { get; set; }
        public HourlyCharterBookingModel HourlyCharterBooking { get; set; }

        public string lblAirlineRewardTitle { get; set; }
        public string ddlWatermarkNone { get; set; }
        public string txtRewardsNumber { get; set; }
        public string btnSaveUpdate { get; set; }
        public string lblAirlineRewardCompany { get; set; }
        public string lblModify { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }

    }
}
