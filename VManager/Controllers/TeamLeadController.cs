using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VManager.Data;
using VManager.Models;

namespace VManager.Controllers
{
    public class TeamLeadController : Controller
    {
        private readonly VManagerContext _context;

        public TeamLeadController(VManagerContext context)
        {
            _context = context;
        }

       /* [Authorize(Roles = "TeamLead")]*/
        public async Task<IActionResult> Index()
        {
            return View();
        }

       /*[Authorize(Roles = "TeamLead")]*/
        public async Task<IActionResult> Vacations()
        {
            var user = _context.Users.Find(User.Identity.GetUserId());
            var appUser = _context.AppUsers.Where(b => b.AspUser == User.Identity.GetUserId())
                    .FirstOrDefault();
            ViewBag.Users = appUser.Team.Users;

            return View(appUser.Vacations.ToList());
        }

        /*[Authorize(Roles = "TeamLead")]*/
        public async Task<IActionResult> Team()
        {
            var user = _context.Users.Find(User.Identity.GetUserId());
            var appUser = _context.AppUsers.Where(b => b.AspUser == User.Identity.GetUserId())
                    .FirstOrDefault();

            if (appUser == null)
            {
                return NotFound(User.Identity.GetUserId());
            }

            ViewBag.Team = appUser.Team;

            return View(appUser.Team.Users.ToList());
        }


    }
}
