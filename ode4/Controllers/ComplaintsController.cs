using odev4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odev4.Controllers
{
    public class ComplaintsController : Controller
    {
        //
        // GET: /Complaints/

        public List<Complaints> complaintsList = new List<Complaints>(){
                new Complaints(){id = 1, complaintstitle = "Deneme 1", complaintsSubject = "Deneme Konu 1", complaintWhy = "Deneme Nedeni 1", date = DateTime.Now },
                new Complaints(){id = 2, complaintstitle = "Deneme 2", complaintsSubject = "Deneme Konu 2", complaintWhy = "Deneme Nedeni 2", date = DateTime.Now },
                new Complaints(){id = 3, complaintstitle = "Deneme 3", complaintsSubject = "Deneme Konu 3", complaintWhy = "Deneme Nedeni 3", date = DateTime.Now },
                new Complaints(){id = 4, complaintstitle = "Deneme 4", complaintsSubject = "Deneme Konu 4", complaintWhy = "Deneme Nedeni 4", date = DateTime.Now },
                new Complaints(){id = 5, complaintstitle = "Deneme 5", complaintsSubject = "Deneme Konu 5", complaintWhy = "Deneme Nedeni 5", date = DateTime.Now }
          };

        public ActionResult Complaints()
        {
            return View(this.complaintsList);
        }
	}
}