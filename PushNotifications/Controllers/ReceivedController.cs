using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using PushNotifications.Models;

namespace PushNotifications.Controllers
{
    public class ReceivedController : Controller
    {

        public ActionResult Index()
        {
            SiteWideResponse.Xml += "<br />" + new StreamReader(Request.InputStream).ReadToEnd();

            return View();
        }


        public void Get()
        {
           
        }

        public string Post([FromBody] string xml)
        {
            var response = new HttpResponseMessage();

            return "test";
        }

    }
}
