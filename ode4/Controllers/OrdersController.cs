using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev4.Models;

namespace odev4.Controllers
{
    public class OrdersController : Controller
    {
        //
        // GET: /Orders/
        
        public List<Orders> ordersList = new List<Orders>(){
                new Orders(){id = 1, ordesnm = "Deneme 1", productnm = "1.Deneme", producprice = 22.00, producpiece = 5, date = DateTime.Now},
                new Orders(){id = 2, ordesnm = "Deneme 2", productnm = "2.Deneme", producprice = 11.00, producpiece = 2, date = DateTime.Now },
                new Orders(){id = 3, ordesnm = "Deneme 3", productnm = "3.Deneme", producprice = 52.00, producpiece = 7, date = DateTime.Now },
                new Orders(){id = 4, ordesnm = "Deneme 4", productnm = "4.Deneme", producprice = 72.00, producpiece = 1, date = DateTime.Now },
                new Orders(){id = 5, ordesnm = "Deneme 5", productnm = "5.Deneme", producprice = 19.00, producpiece = 6, date = DateTime.Now }
          };

        public ActionResult Orders()
        {
            return View(this.ordersList);
        }
	}
}