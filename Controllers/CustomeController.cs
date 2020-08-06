using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fuela_clients.Controllers
{
    public class CustomeController :Controller
    {
        public string Index()
        {
            return "Index string called";
        }
    }
}
