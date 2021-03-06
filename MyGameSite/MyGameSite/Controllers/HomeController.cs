﻿using MyGameSite.MyGameService;
using System.Web.Mvc;

namespace MyGameSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (MyGameServiceClient gs = new MyGameServiceClient())
            {
                gs.GetAllGames();
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