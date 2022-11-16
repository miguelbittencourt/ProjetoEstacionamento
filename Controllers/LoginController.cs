using Estacionamento.Entidades;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Estacionamento.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto db;

        public LoginController(Contexto contexto)
        {
            db = contexto;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string login, string senha)
        {
            Usuarios usuario = db.USUARIOS.Where(a => a.Login == login && a.Senha == senha).FirstOrDefault();

            if (usuario == null)
            {
                TempData["erro"] = "Login ou senha inválidos";
                return RedirectToAction("Index", "Login");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, usuario.Nome),
                new Claim(ClaimTypes.Sid, usuario.Id.ToString())
            };

            var userIdentity = new ClaimsIdentity(claims, "Admin");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

            await HttpContext.SignInAsync("CookieAuthentication", principal, new AuthenticationProperties());

            return Redirect("/");
        }

        public async Task<IActionResult> LogOff()
        {
            await HttpContext.SignOutAsync("CookieAuthentication");
            return RedirectToAction("Index", "Login");
        }
    }
}
