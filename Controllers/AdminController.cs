using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Web;
using HCM.ProfitCenter.Infrastructure;
using HCM.ProfitCenter.Services;

namespace HCM.ProfitCenter.Controllers
{    
    public class AdminController : Controller
    {
        private readonly ITokenAcquisition tokenAcquisition;
        private readonly WebOptions webOptions;

        public AdminController(ITokenAcquisition tokenAcquisition,
                      IOptions<WebOptions> webOptionValue)
        {
            this.tokenAcquisition = tokenAcquisition;
            this.webOptions = webOptionValue.Value;
        }

        /// <summary>
        /// Fetches all the groups a user is assigned to.  This method requires the signed-in user to be assigned to the 'DirectoryViewers' approle.
        /// </summary>
        /// <returns></returns>
        [Authorize(Policy = AuthorizationPolicies.ProfitCenterAdmin)]
        public IActionResult Index()
        {
            return View();
        }
    }
}