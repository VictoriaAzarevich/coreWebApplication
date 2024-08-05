using coreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeeklyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }

        public IActionResult StronglyTypedLogin() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginSuccess(LoginViewModel login) 
        {
            if(login.Username != null && login.Password != null) 
            {
                if(login.Username.Equals("admin") && login.Password.Equals("admin"))
                {
                    ViewBag.Message = "You are successfully logged in";
                    return View();
                }
            }
            ViewBag.Message = "Invalid credentials";
            return View();
        }

        public IActionResult UserDetail()
        {
            var user = new LoginViewModel()
            {
                Username = "Victoria",
                Password = "12345"
            };
            return View(user);
        }

        public IActionResult UserList()
        {
            var users = new List<LoginViewModel>()
            {
                new LoginViewModel() {Username = "Victoria", Password = "12345"},
                new LoginViewModel() {Username = "Edward", Password = "54321"}
            };
            return View(users);
        }
    }
}
