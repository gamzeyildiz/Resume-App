using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Logging;
using ResumeApp.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHtmlLocalizer<HomeController> _localizer;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IHtmlLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewData["About"] = _localizer["About"];
            ViewData["Skills"] = _localizer["Skills"];
            ViewData["Experience"] = _localizer["Experience"];
            ViewData["Education"] = _localizer["Education"];
            ViewData["Portfolio"] = _localizer["Portfolio"];
            ViewData["References"] = _localizer["References"];
            ViewData["Contact"] = _localizer["Contact"];
            ViewData["Hire Me"] = _localizer["Hire Me"];
            ViewData["Download CV"] = _localizer["Download CV"];
            ViewData["About Me"] = _localizer["About Me"];
            ViewData["Bio"] = _localizer["Bio"];
            ViewData["Professional Skills"] = _localizer["Professional Skills"];
            ViewData["Work Experience"] = _localizer["Work Experience"];
            ViewData["Send"] = _localizer["Send"];
            ViewData["All rights reserved."] = _localizer["All rights reserved."];
            ViewData["Age"] = _localizer["Age"];
            ViewData["Email"] = _localizer["Email"];
            ViewData["Phone"] = _localizer["Phone"];
            ViewData["Address"] = _localizer["Address"];
            ViewData["Name"] = _localizer["Name"];
            ViewData["Email address"] = _localizer["Email address"];
            ViewData["Message"] = _localizer["Message"];

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnUrl);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
