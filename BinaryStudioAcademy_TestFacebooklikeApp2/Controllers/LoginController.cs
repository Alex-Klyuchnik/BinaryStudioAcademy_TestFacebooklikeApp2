using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinaryStudioAcademy_TestFacebooklikeApp2.DataAccess;
using BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure;
using BinaryStudioAcademy_TestFacebooklikeApp2.Models;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Controllers
{
    public class LoginController : Controller
    {
        private readonly IRepository repository;
        
        public LoginController(IRepository repository)
        {
            this.repository = repository;
        }
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(LoginModel model)
        {
            repository.Save(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Password))
            {
                return View(model);
            }
            SimpleSessionPersister.Username = model.Email;
            return RedirectToAction("Index","Profile");
        }
    }
}
