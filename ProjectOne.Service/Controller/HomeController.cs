using System;
using Microsoft.AspNetCore.Mvc;

namespace ProjectOne.Service.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            throw new Exception("Kontrollü Hata Oluştu Home Controller / Index Action");
            //return Ok("Merhaba burası default routes");
        }

        [HttpPost]
        public IActionResult Register()
        {
            return Ok("Success register.");
        }
    }

}