using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvstwo.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace mvstwo.Controllers
{
    public class AccessController : Controller
    {
        ApplicationContext db;
        public AccessController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;
            if (claimUser.Identity.IsAuthenticated) return RedirectToAction("Main", "CokMain");
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(User user)
        {
            if(db.Users.FirstOrDefault(q=>q.Login==user.Login && q.Password == user.Password) != null)
            {
                
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Login),
                    new Claim("OtherProperties", "Example Role")
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = user.KeepLoggedIn
                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);
                return RedirectToAction("Main", "CokMain");
            
            }
            
            ViewData["ValidateMessage"] = "Неверный логин/пароль";
            return View();
        }
    }
}
