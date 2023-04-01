using Microsoft.AspNetCore.Mvc;

namespace OsuryuhaanDictionaryAppProj.Controllers
{
    public class PreferenceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
