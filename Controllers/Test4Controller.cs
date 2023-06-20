using Microsoft.AspNetCore.Mvc;
using Practical_10.CustomExceptions;

namespace Practical_10.Controllers
{
    public class Test4Controller : Controller
    {
        [TypeFilter(typeof(CustomExceptionFilter))]
        public IActionResult Index()
        {
            int a = 50;
            int b = 0;
            int result = a / b;
            return Content(result.ToString());
        }
    }
}
