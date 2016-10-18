using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev4.Models;

namespace odev4.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/

        public List<Users> usersList = new List<Users>(){
                new Users(){id = 1, usernm = "Deneme 1", loginnm = "Deneme", pwd = "1", date = DateTime.Now },
                new Users(){id = 2, usernm = "Deneme 2", loginnm = "Deneme", pwd = "2", date = DateTime.Now },
                new Users(){id = 3, usernm = "Deneme 3", loginnm = "Deneme", pwd = "3", date = DateTime.Now },
                new Users(){id = 4, usernm = "Deneme 4", loginnm = "Deneme", pwd = "4", date = DateTime.Now },
                new Users(){id = 5, usernm = "Deneme 5", loginnm = "Deneme", pwd = "5", date = DateTime.Now }
          };

        public ActionResult Users()
        {
            return View(this.usersList);
        }
	}
}