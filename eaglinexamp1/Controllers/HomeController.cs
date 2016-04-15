using eaglinexamp1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace eaglinexamp1.Controllers
{
    public class HomeController : Controller
    {
        CustomContext db = new CustomContext();

        public ActionResult Index()
        {
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
        [HttpPost]
        public void Test01()
        {
            string notUsedString = "We got to Test01";
        }

        [HttpPost]
        public JsonResult SamTest()
        {
            string notUsedString = "We Got To Sam's Test Controller";
            //return Content(notUsedString, "application/json");
            return Json(notUsedString);
        }

        [HttpPost]
        public JsonResult AnotherTest(string data)
        {
            MenuGroup menuGroup = db.MenuGroups.Find(2);
            Console.WriteLine(data);
            string notUsedString = "We Got To Sam's Test Controller";
            //return Content(notUsedString, "application/json");
            //var json = new JavaScriptSerializer().Serialize(menuGroup);


            var json = JsonConvert.SerializeObject(menuGroup,
                Formatting.None,
                    new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });



            return Json(json);
        }


        [HttpPost]
        public JsonResult RecipeTest(string q)
        {
            // Go to puppy recipe and get data based on the q
            var response = new WebClient().DownloadString("http://www.recipepuppy.com/api/?q=" + q);

            return Json(response);
        }

    }
}