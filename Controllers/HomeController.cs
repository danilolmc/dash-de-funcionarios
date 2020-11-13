using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using desafio_mvc.Models;
using desafio_mvc.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace desafio_mvc.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ApplicationDbContext database;

        private readonly ILogger<HomeController> _logger;

        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext database, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            this.database = database;
            _userManager = userManager;
        }

        [Route("")]
        [Route("wa")]
        public async Task<IActionResult> Index()
        {   
            var alreadyExistsAdmin = database.UserClaims.Where(user => user.ClaimValue == "admin").ToList().Count > 0;

            if(!alreadyExistsAdmin){

                var user = new IdentityUser { UserName = "adminwa@gft.com", Email = "adminwa@gft.com" };
          
                var result = await _userManager.CreateAsync(user, "adminwa@123");

                if(result.Succeeded){

                    await _userManager.AddClaimAsync(user, new Claim("levelAccess", "admin"));
                }
            
            }

            return View();

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
