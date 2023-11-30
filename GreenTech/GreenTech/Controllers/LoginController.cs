using GreenTech.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenTech.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Home");
                }
                return View("index");

            }catch (Exception ex)
            {
                TempData["Mensagem de Erro"] = "Não foi possivel fazer o Login"; 
                return RedirectToAction("Index");
            }
           
        }
    }
}
