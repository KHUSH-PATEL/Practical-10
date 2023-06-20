using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace Practical_10.Controllers
{
    public class Test3Controller : Controller
    {
        [OutputCache(Duration = 300)]
        public ActionResult Index()
        {
            return Content(DateTime.Now.ToString());
        }
    }
}
