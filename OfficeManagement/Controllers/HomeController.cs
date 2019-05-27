using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeManagement.Models;
using OfficeManagement.Data;
using Microsoft.AspNetCore.Http;

namespace OfficeManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            String userName = HttpContext.Session.GetString("user");
            if (userName!=null && !userName.Equals(""))
            {
                if (userName.Equals("Admin@yahoo.com"))
                {
                    return RedirectToAction("Admin", "Account");
                }
                else return RedirectToAction("UserDetailNoAdmin","Account", new { userName = userName });
            }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Admin()
        {
            ViewData["Message"] = "Your application description page.";

            Data.ApplicationDbContext applicationDbContext = new Data.ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());
            List<ApplicationUser> applicationUsers = applicationDbContext.ApplicationUsers.ToList();

            return View(applicationUsers);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
