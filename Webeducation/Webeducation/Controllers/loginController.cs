using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webeducation.Entity;

namespace Webeducation.Controllers
{
    public class loginController : Controller
    {
        educationEntities _db = new educationEntities();
        // GET: login
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult login()
        {
            return View();
        }






        [HttpPost]
        public JsonResult SetRegistration(registration model)
        {
            bool state = false;

            if (model.first_name != null && model.last_name != null && model.email_id != null && model.password != null && model.confirm_password != null)
            {
                _db.registrations.Add(model);
                _db.SaveChanges();
                state = true;


            }
            else
            {
                state = false;
            }

            return new JsonResult { Data = new { state = state } };
        }
    }
}