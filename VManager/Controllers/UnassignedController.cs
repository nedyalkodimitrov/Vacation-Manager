using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VManager.Data;
using VManager.Models;

namespace VManager.Controllers
{
    public class UnassignedController : Controller
    {
        private readonly VManagerContext _context;

        public UnassignedController(VManagerContext context)
        {
            _context = context;
        }

    }
}
