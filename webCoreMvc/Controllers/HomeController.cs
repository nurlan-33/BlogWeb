using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using webCoreMvc.Models;
using System.Data.SqlClient;

namespace webCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        Parametrs db=new Parametrs();
        public IActionResult Index()
        {
            db.number1=9;
            db.number2=4;
            ViewBag.deg="Hello world";   
            return View(db);
        }
        
    }
}
