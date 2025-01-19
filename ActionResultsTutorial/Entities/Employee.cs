using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ActionResultsTutorial.Entities
{
    public class Employee
    {
        [Range(1,100)]
        public int Id { get; set; }

        [DisplayName("User Name")]
        [Required]
        public string Firstname { get; set; }

        [DisplayName("User Surname")]
        [Required]
        public string Lastname { get; set; }

        public int CityId { get; set; }
    }
}
