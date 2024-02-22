using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Models;
using System.Diagnostics;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IList<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" },
                new Person { FirstName = "Jane", LastName = "Doe" },
                new Person { FirstName = "Emily", LastName = "Smith", Email = "emily.smith@example.com" },
                new Person { FirstName = "Michael", LastName = "Brown" },
                new Person { FirstName = "Jessica", LastName = "Johnson" },
                new Person { FirstName = "William", LastName = "Davis", Email = "william.davis@example.com" },
                new Person { FirstName = "Olivia", LastName = "Miller" },
                new Person { FirstName = "Henry", LastName = "Wilson", Email = "henry.wilson@example.com" },
                new Person { FirstName = "Ava", LastName = "Moore" },
                new Person { FirstName = "Sophia", LastName = "Taylor" },
                new Person { FirstName = "James", LastName = "Anderson", Email = "james.anderson@example.com" },
                new Person { FirstName = "Isabella", LastName = "Thomas" },
                new Person { FirstName = "Alexander", LastName = "Jackson" },
                new Person { FirstName = "Mia", LastName = "White", Email = "mia.white@example.com" },
                new Person { FirstName = "Charlotte", LastName = "Harris" },
                new Person { FirstName = "Benjamin", LastName = "Martin", Email = "benjamin.martin@example.com" },
                new Person { FirstName = "Amelia", LastName = "Thompson" },
                new Person { FirstName = "Ethan", LastName = "Garcia" },
                new Person { FirstName = "Harper", LastName = "Martinez" },
                new Person { FirstName = "Lucas", LastName = "Robinson", Email = "lucas.robinson@example.com" }
            };
        }
    }
}
