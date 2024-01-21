using CodeAcademy.ViewModel;
using CodeAcademyDAL.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.Versioning;
using System.Xml.Linq;

namespace CodeAcademy.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _usermanager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> usermanager, SignInManager<ApplicationUser> signInManager ) {
            _usermanager = usermanager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterVM Model) {
           
            if (ModelState.IsValid) {
                var User = new ApplicationUser()
                {
                    FName = Model.FName,
                    LName = Model.LName,
                    Email = Model.Email

                };
               // var res = 
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
