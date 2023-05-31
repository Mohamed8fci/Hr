using System.ComponentModel.DataAnnotations;

namespace Hr.Models
{
    public class Employess
    {
        [Required]
        public string EmployeeName { get; set; }
        [Required]

        public string Department { get; set; }

        public bool isActive { get; set; }

        public string JobTitle { get; set; }

        public DateTime BirthDate { get; set; }

        public string EmailAddress { get; set; }
    }
}
