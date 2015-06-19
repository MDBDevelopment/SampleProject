using BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TechnicalTest.Models;

namespace TechnicalTest.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthenticationManager _authManager;

        public AuthController(IAuthenticationManager authManager)
        {
            _authManager = authManager;
        }

        // GET: Auth
        [AllowAnonymous]
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("Index", "Transactions");
            }

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModel loginModel)
        {
            var loginSuccess = _authManager.Login(loginModel.Email, loginModel.Password);

            if (loginSuccess)
            {
                FormsAuthentication.SetAuthCookie(loginModel.Email, true);
            }

            if (Request.IsAjaxRequest())
                return Json(loginSuccess);

            return loginSuccess ?
                RedirectToAction("Index", "Transactions") :
                RedirectToAction("Index", "Auth");
        }

        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            if (Request.IsAjaxRequest())
                return Json(true);

            return RedirectToAction("Index", "Auth");
        }
    }
}