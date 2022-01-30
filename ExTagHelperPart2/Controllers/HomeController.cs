using ExTagHelperPart2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExTagHelperPart2.Controllers
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
            TeamViewModel teamViewModel = new TeamViewModel
            {
                Teams = new System.Collections.Generic.List<SelectListItem>()
                {
                    new SelectListItem{Value="1" , Text="استقلال"}  ,
                    new SelectListItem{Value="1" , Text="پرسپولیس"} ,
                    new SelectListItem{Value="1" , Text="پیکان"}  ,
                    new SelectListItem{Value="1" , Text="نفت"}  ,
                    new SelectListItem{Value="1" , Text="ذوب آهن"}  
                } ,

                SelectListTeamMltipe = new List<SelectListItem>()
                {
                    new SelectListItem{Value="1" , Text="استقلال"}  ,
                    new SelectListItem{Value="1" , Text="پرسپولیس"} ,
                    new SelectListItem{Value="1" , Text="پیکان"}  ,
                    new SelectListItem{Value="1" , Text="نفت"}  ,
                    new SelectListItem{Value="1" , Text="ذوب آهن"}
                }
            };
            return View(teamViewModel);
        }

        public IActionResult Privacy()
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
