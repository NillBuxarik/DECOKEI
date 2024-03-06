using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvstwo;
using mvstwo.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace mvstwo.Controllers
{
    [Authorize]
    public class CokMainController : Controller
    {
        ApplicationContext db;
        public CokMainController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(db);
        }
        [HttpPost]
        public async Task<IActionResult> Cok(int IdCok)
        {
            ViewBag.IdCok = IdCok;
            return View(db);
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Access");
        }
        public async Task<IActionResult> Place()
        {
            return View(db);
        }
        public async Task<IActionResult> Main()
        {
            var Logins = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            ViewBag.rar = Logins.Value;
            return View(db);
        }
        public async Task<IActionResult> ProfileTeacher()
        {
            var Logins = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            ViewBag.rar = Logins.Value;
            return View(db);
        }
        public async Task<IActionResult> Quiz()
        {
            return View(db);
        }
        public async Task<IActionResult> Result()
        {
            return View(db);
        }//
        public async Task<IActionResult> Edit1()
        {
            if (1 != null)
            {
                Cok? cok = await db.Coks.FirstOrDefaultAsync(p => p.Id == 2);
                if (cok != null) return View(cok);
            }
            return NotFound();
        }
        public async Task<IActionResult> Edit(int a)
        {
            ViewBag.f = a;
            if (1 != null)
            {
                Cok? cok = await db.Coks.FirstOrDefaultAsync(p => p.Id == 2);
                if (cok != null) return View(cok);
            }
            return NotFound();
        }
        public async Task<IActionResult> EditCok(int? IdCok)
        {
            if (1 != null)
            {
                Cok? cok = await db.Coks.FirstOrDefaultAsync(p => p.Id == IdCok);
                if (cok != null) return RedirectToAction("Edit", 2);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Cok cok)
        {
            db.Coks.Update(cok);
            await db.SaveChangesAsync();
            return RedirectToAction("Main");
        }
    }
}
