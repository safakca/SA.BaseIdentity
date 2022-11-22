using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _appUserManager; 
        public RegisterController(UserManager<AppUser> appUserManager)
        {
            _appUserManager = appUserManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterViewModel appUserRegisterViewModel)
        {
            //TODO: Mapping refactoring et !
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Name = appUserRegisterViewModel.Name,
                    Surname = appUserRegisterViewModel.Surname,
                    Email = appUserRegisterViewModel.Mail,
                    UserName = appUserRegisterViewModel.Username,
                };

                if (appUserRegisterViewModel.Password == appUserRegisterViewModel.ConfirmPassword)
                {
                    var result = await _appUserManager.CreateAsync(appUser, appUserRegisterViewModel.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Password Not Combine");
                }
            }
            return View();
        }
    }
}
