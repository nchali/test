using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    public class LocationsModel
    {
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public NavigationMenu NavigationMenu { get; set; }
        public AirportRideBookingModel AirportRideBooking { get; set; }
        public PointToPointBookingModel PointToPointBooking { get; set; }
        public HourlyCharterBookingModel HourlyCharterBooking { get; set; }

        public string lblMyLocationTitle { get; set; }
        public string btnAddNewLocation { get; set; }
        public string btnClose { get; set; }
        public string txtWatermarkLocationName { get; set; }
        public string txtWatermarkPhoneNumber { get; set; }
        public string txtWatermarkStreetNumber { get; set; }
        public string txtWatermarkStreetName { get; set; }
        public string txtWatermarkUnitNumber { get; set; }
        public string txtWatermarkCity { get; set; }
        public string ddlWatermarkState { get; set; }
        public string txtWatermarkZipCode { get; set; }
        public string txtComments { get; set; }
        public string btnSaveUpdate { get; set; }
        public string lblLocationName { get; set; }
        public string lblAddress { get; set; }
        public string lblModify { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }

    }
}
