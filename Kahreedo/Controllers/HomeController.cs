using Amazon.LexRuntimeV2;
using Amazon.Runtime;
using Khareedo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Khareedo.Controllers
{
    public class HomeController : Controller
    {
        KhareedoEntities db = new KhareedoEntities();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MenProduct = db.Products.Where(x => x.Category.Name.Equals("Men")).ToList();
            ViewBag.WomenProduct = db.Products.Where(x => x.Category.Name.Equals("Women")).ToList();
            ViewBag.SportsProduct = db.Products.Where(x => x.Category.Name.Equals("Sports")).ToList();
            ViewBag.ElectronicsProduct = db.Products.Where(x => x.Category.Name.Equals("Phones")).ToList();
            ViewBag.Slider = db.genMainSliders.ToList();
            ViewBag.PromoRight = db.genPromoRights.ToList();

            this.GetDefaultData();

            //fot lex
           
            //var awsCredentials = new Amazon.Runtime.BasicAWSCredentials("AKIAR5ZSWCZUOANO4IX3", "t+uNRuOQSgYAL7ggQ6x2GCHUzHui+5wVuDmBnePS");
            //var lexConfig = new Amazon.LexRuntimeV2.AmazonLexRuntimeV2Config
            //{
            //    RegionEndpoint = Amazon.RegionEndpoint.USEast2 // Replace with your desired region
            //};

            //var lexClient = new Amazon.LexRuntimeV2.AmazonLexRuntimeV2Client(awsCredentials, lexConfig);

            return View();
        }      

    }
}