using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Infrastructure;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(UserViewModel userModel, string returnUrl)
        {

            AppUser user = await UserManager
                .FindAsync(userModel.UserName, userModel.Password);

            if(user!=null)
            { 
                var ident = await UserManager
                    .CreateIdentityAsync(user, 
                                         DefaultAuthenticationTypes.ApplicationCookie);
                AuthManager.SignOut();
                AuthManager
                    .SignIn(new AuthenticationProperties{IsPersistent = false}, 
                             ident);

                return Redirect(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "Неверное имя или пароль");
            }



            return View(userModel);
        }

        private AppUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext()
                    .GetUserManager<AppUserManager>();
            }
        }

        private IAuthenticationManager AuthManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
    }
}