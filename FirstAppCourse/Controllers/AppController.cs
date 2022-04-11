using FirstAppCourse.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppCourse.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index() // ActionResult est l'interface qu'on veut renvoyer
        {

            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact() // ActionResult est l'interface qu'on veut renvoyer
        {
            ViewBag.Title = "Contact Us";
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactModel model) // ActionResult est l'interface qu'on veut renvoyer
        {
            Console.WriteLine(model.Name);
            return View();
        }
        [HttpGet("about")]
        public IActionResult About() // ActionResult est l'interface qu'on veut renvoyer
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
