using Microsoft.AspNetCore.Mvc;

namespace Practical_10.Controllers
{
    public class Test2Controller : Controller
    {
        public IActionResult DisplayContentResult()
        {
            string message = "This message is displayed using ContentResult type of ActionResult";
            return Content(message);
        }

        public IActionResult DisplayFileContentResult()
        {
            byte[] file = System.IO.File.ReadAllBytes("TextFile.txt");
            return File(file, "text/plain");
        }

        public IActionResult DisplayJavaScriptResult()
        {
            string javascriptCode = "alert('This is a JavaScript example.');";
            return Content("<script>" + javascriptCode + "</script>", "text/html");
        }
        public IActionResult DisplayJsonResult()
        {
            var data = new
            {
                id = 1,
                name = "Khush",
                message = "This is a JsonResult example."
            };
            return Json(data);
        }
    }
}
