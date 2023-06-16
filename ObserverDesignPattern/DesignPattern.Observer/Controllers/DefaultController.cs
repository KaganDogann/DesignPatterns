using DesignPattern.Observer.DAL;
using DesignPattern.Observer.Models;
using DesignPattern.Observer.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userMnaager;
        private readonly ObserverObject _observerObject;

        public DefaultController(UserManager<AppUser> userMnaager, ObserverObject observerObject)
        {
            this._userMnaager = userMnaager;
            _observerObject = observerObject;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel registerViewModel)
        {
            var appUser = new AppUser()
            {
                Name = registerViewModel.Name,
                Email = registerViewModel.Email,
                Surname = registerViewModel.Surname,
                UserName = registerViewModel.UserName,
            };
            var result = await _userMnaager.CreateAsync(appUser, registerViewModel.Password);
            if (result.Succeeded)
            {
                _observerObject.NotifyObserver(appUser);
                return View();
            }
            return View();
        }
    }
}
