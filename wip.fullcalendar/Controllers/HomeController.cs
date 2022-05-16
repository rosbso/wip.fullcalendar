using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using wip.fullcalendar.Models;

namespace wip.fullcalendar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Calendario()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
            //var viewModel = new HorarioViewModel();
            //var events = new List<EventViewModel>();

            string path = "Controllers/data.json";
            string readText = System.IO.File.ReadAllText(path);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var events = JsonSerializer.Deserialize<List<HorarioViewModel>>(readText, options);


            return Json(events.ToArray());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}