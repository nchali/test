using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    public class AirportRideBookingModel
    {
        public string rdbOneWay { get; set; }
        public string rdbRoundTrip { get; set; }
        public string rdbToTheAirport { get; set; }
        public string rdbFromTheAirport { get; set; }
        public string lblSignInNowInfo1 { get; set; }
        public string lnkSignInNow { get; set; }
        public string lblSignInNowInfo2 { get; set; }
        public string ddlWatermarkPickupAirport { get; set; }
        public string txtWatermarkPickupAddress { get; set; }
        public string txtWatermarkGroupDiscountCode { get; set; }
        public string ddlWatermarkDropoffAirport { get; set; }
        public string txtWatermarkDropoffAddress { get; set; }
        public string txtWatermarkFlightDate { get; set; }
        public string txtWatermarkFlightTime { get; set; }
        public string ddlWatermarkAirline { get; set; }
        public string ddlWatermarkArrivingAirline { get; set; }
        public string txtWatermarkFlighNumber { get; set; }
        public string ddlWatermarkFlightType { get; set; }
        public string txtWatermarkDomestic { get; set; }
        public string btnBookRideToAirport { get; set; }
        public string btnBookRideFromAirport { get; set; }
        public string btnFindRideToAirport { get; set; }
        public string btnFindRideFromAirport { get; set; }
        public string txtWatermarkArrivalDate { get; set; }
        public string txtWatermarkArrivalTime { get; set; }
        public string txtWatermarkSameAsPickupAddress { get; set; }
        public string txtWatermarkReturnDate { get; set; }
        public string txtWatermarkReturnTime { get; set; }
        public string txtWatermarkReturnFlightDate { get; set; }
        public string txtWatermarkReturnFlightTime { get; set; }
        public string ddlWatermarkReturningAirline { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }


        public BookingInfoModel BookingInfo { get; set; }


    }
}
