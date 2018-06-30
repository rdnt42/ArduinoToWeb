using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArduinoToWeb.Models;
using System.Threading.Tasks;
using System.Net;

namespace ArduinoToWeb.Controllers
{
    public class HomeController : Controller
    {

        DeviceContext db = new DeviceContext();

        public ActionResult Index()
        {
            //получаем из бд все объекты 

           
            //возвращаем представление
            return View(db.Devices);
        }
    }
}