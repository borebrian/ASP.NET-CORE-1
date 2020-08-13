using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//ADDD THIS FOR VIEWBAG
using System.Dynamic;
namespace Fuela_clients.Controllers
{
    public class CustomeController :Controller
    {
        public ViewResult Index()
        {
            dynamic data = new ExpandoObject();
            data.id = 1;
            data.names = "Brian Kimutai";
            ViewBag.data = data;
            return View();
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
