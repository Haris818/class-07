using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace class_07.Controllers
{
    public class HOMEController : Controller
    {
        // GET: HOME
        public ActionResult HOME()
        {
            return View();
        }


        [HttpPost]
        public ActionResult HOME(string username, string age, string email)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                ModelState.AddModelError("username", "User name is required");
            }
            if (string.IsNullOrWhiteSpace(age))
            {
                ModelState.AddModelError("age", "User age is required");
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                ModelState.AddModelError("email", "User email is required");
            }
            if (ModelState.IsValid == true)
            {
                ViewData["SuccessMessage"] = "<script>alert('Thank you for submitting form');</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}
    