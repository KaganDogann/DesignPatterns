using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Content("Film-Dizi");
            ViewBag.v4 = netflixPlans.Price(65.99);
            ViewBag.v5 = netflixPlans.Resolution("480px");
            return View();
        }

        public IActionResult StandardPlanIndex()
        {
            NetflixPlans netflixPlans = new StandardPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standard Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Content("Film-Dizi-animasyon");
            ViewBag.v4 = netflixPlans.Price(96.99);
            ViewBag.v5 = netflixPlans.Resolution("720px");
            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new UltraPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(3);
            ViewBag.v3 = netflixPlans.Content("Film-Dizi-Animasyon-Her şey");
            ViewBag.v4 = netflixPlans.Price(196.99);
            ViewBag.v5 = netflixPlans.Resolution("1080px");
            return View();
        }
    }
}
