using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MetalBandBakery.MVC;
using MetalBandBakery;
using MetalBake.Models;

namespace MetalBandBakery.MVC.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Stock(string[] itemId)
        {
            return View();
        }
    }
}