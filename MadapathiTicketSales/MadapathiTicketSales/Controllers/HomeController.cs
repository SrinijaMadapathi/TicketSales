using MadapathiTicketSales.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MadapathiTicketSales.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Created by Madapathi Srinija
         * 6666666666666666666666666666
         */
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}