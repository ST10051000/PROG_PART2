using AgriEnergyConnectPlatform.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnectPlatform.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult DisplayProduct()
        {
            return View();
        }
    }
}
