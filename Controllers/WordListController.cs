using Microsoft.AspNetCore.Mvc;

namespace OsuryuhaanDictionaryAppProj.Controllers
{
    public class WordListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
