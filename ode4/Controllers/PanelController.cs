using odev4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace odev4.Controllers
{
    public class PanelController : Controller
    {
        //
        // GET: /Panel/

        public List<Product> productList = new List<Product>(){
                new Product(){id = 1, name = "Deneme", detail = "Deneme", price = 22.00 },
                new Product(){id = 2, name = "Deneme", detail = "Deneme", price = 11.00 },
                new Product(){id = 3, name = "Deneme", detail = "Deneme", price = 5.00 },
                new Product(){id = 4, name = "Deneme", detail = "Deneme", price = 7.00 },
                new Product(){id = 5, name = "Deneme", detail = "Deneme", price = 19.00 }
          };

        public ActionResult Panel()
        {
            if (Request.Cookies["mesaj_gosterildimi"] == null)
            {
                HttpCookie cookie = new HttpCookie("mesaj_gosterildimi", "evet");
                Response.Cookies.Add(cookie);
                ViewBag.ShowMessage = true;
            }

            ViewBag.name = Session["name"];

            return View(this.productList);
        }
	}
}