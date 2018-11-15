using Delta.Core.Notifications;
using Delta.Service.Trinity.Services.Interfaces;
using Delta.Trinity.DataAccess.Commands.Auth;
using Delta.Trinity.DataAccess.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Delta.WebApp.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IAccountService _accountService;
        
        public AccountController(INotificationHandler<DomainNotification> notifications,
            IAccountService accountService) : base(notifications)
        {
            _accountService = accountService;
        }
        
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register([FromBody]AccountViewModel accountViewModel)
        {
            if (!ModelState.IsValid) return View(accountViewModel);
            _accountService.Register(accountViewModel);
            
            if (IsValidOperation())
                ViewBag.Success = "Account Registered!";

            return View(accountViewModel);
        }
    }
}