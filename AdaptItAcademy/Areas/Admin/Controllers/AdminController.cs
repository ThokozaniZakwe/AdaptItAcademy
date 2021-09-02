using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using AdaptItAcademy.DataAccess.Models;
using Microsoft.AspNetCore.Authorization;

namespace AdaptItAcademy.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdminController : Controller
    {
        private UserManager<IdentityUser> userManager;

        public AdminController(UserManager<IdentityUser> mgr)
        {
            userManager = mgr;
        }
        public async Task<IActionResult> Index()
        {
            return View(await userManager.FindByNameAsync("Admin"));
        }
    }
}
