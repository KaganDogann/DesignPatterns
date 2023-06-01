using DesignPattern.ChainOfResponsibility.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasuer();
            Employee managerAsistant = new ManagerAsistant();
            Employee manager = new Manager();
            Employee areDirector = new AreaDirector();

            treasurer.SetNextApprover(managerAsistant);
            managerAsistant.SetNextApprover(manager);
            manager.SetNextApprover(areDirector);

            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
