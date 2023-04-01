using Microsoft.AspNetCore.Mvc;

namespace OsuryuhaanDictionaryAppProj.Controllers
{
    public class PreferencesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
