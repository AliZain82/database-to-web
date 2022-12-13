
using Microsoft.AspNetCore.Mvc;
using database.Models;
namespace database.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            class1 CS = new class1();
            List<MyTable> Users = CS.GetAll();

            return View(Users);
        }
    }
}

