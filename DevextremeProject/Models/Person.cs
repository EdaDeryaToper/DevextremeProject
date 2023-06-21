using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DevextremeProject.Models
{
    public class Person
    {
        
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Notes { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }

    }
}
