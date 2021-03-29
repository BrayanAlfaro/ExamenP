using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Problema7.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Problema7.Models.Login Login)
        {
            if (Login.Usuario == "Admin")
            {
                if (Login.Password == "12345")
                {
                    ViewBag.Message = "Inicio de sesión correcto";
                    return PartialView("Modal");
                }
                else
                {
                    TempData["LogError"] = "Contraseña incorrecta";
                    return RedirectToAction("Login");
                }
            }
            else
            {
                TempData["LogError"] = "Usuario incorrecto";
                return RedirectToAction("Login");
            }
        }
    }
}