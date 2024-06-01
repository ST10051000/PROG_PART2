using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnectPlatform.Controllers
{
   // [Authorize(Roles ="Employee")]
    public class FarmerController : Controller
    {
        public IActionResult AddFarmer()
        {
            return View();
        }

        public IActionResult DisplayFarmer()
        {
            return View();
        }
    }
}
