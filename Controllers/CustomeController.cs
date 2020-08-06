using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fuela_clients.Controllers
{
    public class CustomeController :Controller
    {
        public ViewResult Index()
        {
            return View("Aboutus");
        } 
        public ViewResult Aboutus()
        {
            return View();
        }
        public ViewResult Contactus()
        {
            return View();
        }
    }
}
