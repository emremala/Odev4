using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Xml;
using odev4.Filters;
using Microsoft.Owin.Security;

namespace odev4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {           
            if (HttpContext.Application["counter"] == null)
            {
                HttpContext.Application["counter"] = 0;
            }

            HttpContext.Application["counter"] = Convert.ToInt16(HttpContext.Application["counter"]) + 1;

            ViewBag.counter = HttpContext.Application["counter"];

            return View();
        }

        public string GetIp()
        {
            var strHostName = "";
            strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            var addr = ipEntry.AddressList;
            return addr[0].ToString();
        }

        //[SessionController] //Sayfaların arasından login kontrolü
        [HttpPost]
        public ActionResult Control(string txtUsername, string txtPassword)
        {
            XmlDocument xml = new XmlDocument();

            xml.Load(Server.MapPath(@"\App_Data\db.xml"));
            var admin = xml.SelectSingleNode(@"/admin");

            var usernm = admin.SelectSingleNode("username").InnerText;
            var loginnm = admin.SelectSingleNode("loginname").InnerText;
            var pwd = admin.SelectSingleNode("password").InnerText;
            var sysadmin = admin.SelectSingleNode("sysadmin").InnerText;

            if (txtUsername == loginnm && txtPassword == pwd)
            {
                Session["name"] = usernm;
                Session["admin"] = true;

                if (sysadmin == "True")
                {
                    Session["loginRoles"] = true;
                }
                else
                {
                    Session["loginRoles"] = false;
                }

                return Redirect("/Panel/Panel");
            }

            Session["loginFailed"] = true;

            int loginErrorCount = Convert.ToInt32(Session["wrongpiece"]);

            Session["wrongpiece"] = loginErrorCount + 1;
            Session["wrongdate"] = DateTime.Now;
            Session["IP"] = GetIp();

            return Redirect("/Home/Index");
        }

        public ActionResult WrongEntry()
        {
            ViewBag.wrongpiece = Session["wrongpiece"];
            ViewBag.wrongdate = Session["wrongdate"];
            ViewBag.IP = Session["IP"];

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            IAuthenticationManager authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            Session.Clear();
            Session.Abandon();
            return Redirect("/Home/Index");
        }
    }
}
