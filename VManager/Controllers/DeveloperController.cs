using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VManager.Data;
using VManager.Models;

namespace VManager.Controllers
{
    public class DeveloperController : Controller
    {
        private readonly VManagerContext _context;

        public DeveloperController(VManagerContext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
            return View();
        }

       
        public async Task<IActionResult> Vacations()
        {
            var user =  _context.Users.Find(User.Identity.GetUserId());
            var appUser = _context.AppUsers.Where(b => b.AspUser == User.Identity.GetUserId())
                    .FirstOrDefault();


            return View(appUser.Vacations.ToList());
        }

       
        public async Task<IActionResult>Team()
        {
            var user = _context.Users.Find(User.Identity.GetUserId());
            var appUser = _context.AppUsers.Where(b => b.AspUser == User.Identity.GetUserId())
                    .FirstOrDefault();

            if (appUser == null )
            {
                return NotFound(User.Identity.GetUserId());
            }

            ViewBag.Team = appUser.Team;

            return View(appUser.Team.Users.ToList());
        }


    }
}
