using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;

namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    class AccountSettingModel
    {
        public Header Header { get; set; }
        public Footer Footer { get; set; }
        public NavigationMenu NavigationMenu { get; set; }
        public string lblPersonalProfile { get; set; }
        public string lblAccountPersonalProfileInfo { get; set; }
        public string PrefixRequired { get; set; }
        public string txtWatermarkFirstName { get; set; }
        public string FirstNameRequired { get; set; }
        public string txtWatermarkLastName { get; set; }
        public string LastNameRequired { get; set; }
        public string lblDateOfBirth { get; set; }
        public string ddlWatermarkMonth { get; set; }
        public string ddlWatermarkDay { get; set; }
        public string ddlWatermarkYear { get; set; }
        public string lblAlertsAndNotifications { get; set; }
        public string lblAlertsAndNotificationsInfo { get; set; }
        public string txtWatermarkContactNumber { get; set; }
        public string ContactNumberRequired { get; set; }
        public string ddlWatermarkSetHomeAirport { get; set; }
        public string SetHomeAirportRequired { get; set; }
        public string chkEmailNewsAndSpecialOffers { get; set; }
        public string chkSmsText { get; set; }
        public string lblEmailAndPassword { get; set; }
        public string lblEmailAndPasswordInfo { get; set; }
        public string txtWatermarkEmail { get; set; }
        public string EmailRequired { get; set; }
        public string EmailInvalid { get; set; }
        public string EmailIncorrect { get; set; }
        public string txtWatermarkPassword { get; set; }
        public string PasswordRequired { get; set; }
        public string PasswordRange { get; set; }
        public string txtWatermarkNewPassword { get; set; }
        public string NewPasswordRequired { get; set; }
        public string txtWatermarkConfirmNewPassword { get; set; }
        public string NewConfirmPasswordRequired { get; set; }
        public string lblGeneralSettings { get; set; }
        public string lblGeneralSettingsInfo1 { get; set; }
        public string lnkCancelMyAccount { get; set; }
        public string lblGeneralSettingsInfo2 { get; set; }
        public string btnSaveUpdate { get; set; }
        public string lblDeleteConfirmationMsg { get; set; }
        public string btnDelete { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }


    }
}
