using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    class LocateRideModel
    {
        public Header Header;
        public Footer Footer;

        public string lblLocateYourRidePageTitle {get;set;}
        public string lblWhereIsMyRide {get;set;}
        public string lblWhereIsMyRideInfo1 {get;set;}
        public string lblWhereIsMyRideInfo2 {get;set;}
        public string txtWatermarkConfirmationNo {get;set;}
        public string VehicleConfirmationNumberRequired {get;set;}
        public string btnLocate {get;set;}
        public string lblErrorMessage1 {get;set;}
        public string lblErrorMessage2 {get;set;}
        public string lblErrorMessage3 {get;set;}


    }
}
