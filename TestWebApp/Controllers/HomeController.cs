﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());            

            foreach (IPAddress ipadd in ipHostInfo.AddressList)
            {                
                ViewBag.MachineIP = ViewBag.MachineIP + ipadd.ToString() + "<br/>";
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}