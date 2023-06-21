using DevextremeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace DevextremeProject.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            List<Person> person = new List<Person>()
            {new Person(){
                    ID = 1,
                FirstName = "Eda",
                LastName = "Toper",
                BirthDate = DateTime.Parse("1964/03/16"),
                Email = "test@test.com",
                Phone = "05555555",
                Notes = "Olivia loves to sell. She has been selling DevAV products since 2012.",
                Image = "/Image/1.png"

            },
                new Person(){
                    ID = 2,
                    FirstName = "Derya",
                    LastName = "Kop",
                    BirthDate = DateTime.Parse("1964/03/16"),
                    Email = "test@test.com",
                    Phone = "051111111",
                    Notes = "Robert was recently voted the CMO of the year by CMO Magazine.",
                    Image = "/Image/1.png"},

            };
            
            return View(person);
        }
    }
}
