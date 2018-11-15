using System.Diagnostics;
using Delta.Core.Notifications;
using Delta.WebApp.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Delta.WebApp.Areas
{
    public class HomeController : BaseController
    {
        public HomeController(INotificationHandler<DomainNotification> notifications) : base(notifications)
        {
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}