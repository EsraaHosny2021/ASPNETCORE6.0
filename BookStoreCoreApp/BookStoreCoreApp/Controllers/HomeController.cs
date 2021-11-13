using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCoreApp.Controllers
{
    //to become MVC class, inherits it from Controller parent class
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hi esraa";
        }
    }
}
