using System;
using Microsoft.AspNetCore.Mvc;

namespace WorkAround.Controllers
{
    public class AccountController: Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        public ActionResult Validate()
        {
           return Json(new { status = true, message = "Login Successfull!" });
        }
    }
}
