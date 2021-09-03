using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuoteOfTheDay.Models;

namespace QuoteOfTheDay.Controllers
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
        [HttpGet]
        public IActionResult AddQuoteForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddQuoteForm(Quote quote)
        {
            if (ModelState.IsValid)
            {
                DataStore.addQuote(quote);
                return View("Thanks", quote);
            }
            else
            {
                return View();
            }

        }
        public IActionResult ViewQuotes()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
