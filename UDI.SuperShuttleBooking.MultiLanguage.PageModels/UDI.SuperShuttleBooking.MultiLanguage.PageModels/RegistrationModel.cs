using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    class RegistrationModel
    {
        public Header Header;
        public Footer Footer;
        public string lblSignUpHeader { get; set; }
        public string lblSignUpContentHeader { get; set; }
        public string lblPersonalProfile { get; set; }
        public string lblSignUpPersonalProfileInfo { get; set; }
        public string txtWatermarkFirstName { get; set; }
        public string FirstNameRequired { get; set; }
        public string ddlWatermarkPrefix { get; set; }
        public string PrefixRequired { get; set; }
        public string txtWatermarkLastName { get; set; }
        public string LastNameRequired { get; set; }
        public string lblDateOfBirth { get; set; }
        public string ddlWatermarkMonth { get; set; }
        public string ddlWatermarkDay { get; set; }
        public string ddlWatermarkYear { get; set; }
        public string lblEmailAndPassword { get; set; }
        public string lblSignUpEmailAndPasswordInfo { get; set; }
        public string txtWatermarkEmail { get; set; }
        public string EmailRequired { get; set; }
        public string EmailInvalid { get; set; }
        public string EmailIncorrect { get; set; }
        public string txtWatermarkPassword { get; set; }
        public string PasswordRequired { get; set; }
        public string PasswordRange { get; set; }
        public string txtWatermarkConfirmPassword { get; set; }
        public string ConfirmPasswordRequired { get; set; }
        public string ConfirmPasswordCompare { get; set; }
        public string lblAlertsAndNotification { get; set; }
        public string lblSignUpAlertsAndNotificationInfo { get; set; }
        public string txtWatermarkContactNumber { get; set; }
        public string ContactNumberRequired { get; set; }
        public string ddlWatermarkSetHomeAirport { get; set; }
        public string HomeSetAirportRequired { get; set; }
        public string chkSmsText { get; set; }
        public string chkEmailNewsAndSpecialOffers { get; set; }
        public string divTermsAndConditions { get; set; }
        public string divAlreadyMemberAndSignIn { get; set; }
        public string btnSignUp { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }


    }
}
