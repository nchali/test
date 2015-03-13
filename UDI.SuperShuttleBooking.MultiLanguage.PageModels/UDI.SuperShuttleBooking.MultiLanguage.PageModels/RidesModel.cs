using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    class  RidesModel
    {
        public Header Header ;
        public Footer Footer ;
        public NavigationMenu NavigationMenu ;

        public string lblMyRidesContentHeader { get; set; }
        public string lblMyRidesContentInfo { get; set; }
        public string txtWatermarkConfirmationOfBooking { get; set; }
        public string ConfirmationNumberInvalid { get; set; }
        public string ConfirmationNumberRequired { get; set; }
        public string btnAddBooking { get; set; }
        public string lnkActiveRides { get; set; }
        public string lnkCompleteRides { get; set; }
        public string lnkCancelledRides { get; set; }
        public string txtWatermarkFilterByMonth { get; set; }
        public string txtWatermarkFilterByYear { get; set; }
        public string lblActivebookingStatus { get; set; }
        public string lblActivebookingStatusInfo { get; set; }
        public string lblPickUpDateTime { get; set; }
        public string lblPickUpLocation { get; set; }
        public string lblDropOffLocation { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }
    }
}
