using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI.SuperShuttleBooking.MultiLanguage.PageModels.Common;
namespace UDI.SuperShuttleBooking.MultiLanguage.PageModels
{
    class SignInModel
    {
        public Header Header ;
        public Footer Footer;
        public string lblSignInPageTitle { get; set; }
        public string lblSignInContentHeader { get; set; }
        public string lblSignInContentInfo { get; set; }
        public string txtWatermarkEmail { get; set; }
        public string EmailRequired { get; set; }
        public string EmailInvalid { get; set; }
        public string EmailIncorrect { get; set; }
        public string txtWatermarkPassword { get; set; }
        public string PasswordRequired { get; set; }
        public string PasswordRange { get; set; }
        public string lnkForgotPassword { get; set; }
        public string chkRememberMe { get; set; }
        public string btnSignIn { get; set; }
        public string lblDoNotHaveAnAccount { get; set; }
        public string lnkSignUpHear { get; set; }
        public string lblErrorMessage1 { get; set; }
        public string lblErrorMessage2 { get; set; }
        public string lblErrorMessage3 { get; set; }

    }
}
