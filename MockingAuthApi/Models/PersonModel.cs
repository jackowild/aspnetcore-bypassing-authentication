using System.ComponentModel.DataAnnotations;

namespace MockingAuthApi.Models
{
    public class PersonModel
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
    }
}
