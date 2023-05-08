using Microsoft.AspNetCore.Mvc;

namespace Task20.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string GetDataFromObject(int id, string name, string secondName, string middleName, string email, string phone)
        {
            return $"{id} {name} {secondName} {middleName} {email} {phone}";
        }
    }
}
