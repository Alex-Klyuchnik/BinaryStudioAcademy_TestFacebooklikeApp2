using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure;
using BinaryStudioAcademy_TestFacebooklikeApp2.Models;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Controllers
{
    public class ProfileController : BaseController
    {
        //
        // GET: /Profile/
        [Authorize]
        public ActionResult Index()
        {
            return View(new LoginModel{Email = this.User.Identity.Name});
        }

        public ActionResult EditProfile()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Suggest()
        {
            return View();
        }
    }
}
