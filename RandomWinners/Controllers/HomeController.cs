using Domain.Context;
using Microsoft.AspNetCore.Mvc;
using RandomWinners.Models;
using System.Diagnostics;

namespace RandomWinners.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PersonContext _personContext;

        public HomeController(ILogger<HomeController> logger, PersonContext personContext)
        {
            _logger = logger;
            _personContext = personContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Winners(WinnersRequest request)
        {

            Winners winners = new Winners(_personContext);
            return View(winners.GetWinners(request));
        }
    }
}