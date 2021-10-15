using Microsoft.Graph;

namespace HCM.ProfitCenter.Models
{
    public class ApplicationUser
    {
        public string UserId { get; set; }
        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Department { get; set; }
        public string UserPrincipalName { get; set; }

        //public string UserId 
        //{ 
        //    //get
        //    //{
        //    //    return string.IsNullOrEmpty(this.Mail) && this.Mail.IndexOf("@") == 3 
        //    //        ? this.Mail.ToUpper().Substring(3) 
        //    //        : string.Empty; 
        //    //}

        //}
    }
}