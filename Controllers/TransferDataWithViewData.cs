using Microsoft.AspNetCore.Mvc;

namespace ParagimMVC.Controllers
{
    public class TransferDataWithViewData : Controller
    {
        // GET
        public IActionResult Index()
        {
            ViewData["TestData"] = "Hello I am the data in the ViewData!";

            ViewBag.MyData = "Hello I am the data in the ViewBag!";
            return View();
        }
        public IActionResult Index1()
        {
            ViewData["TestData"] = "Hello I am the data in the ViewData!";

            ViewBag.MyData = "Hello I am the data in the ViewBag!";
            return View();
        }
    }
}