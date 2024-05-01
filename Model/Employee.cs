using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyAppRazor.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Employee Name")]
        public string? Name { get; set; }
        [Required]
        [DisplayName("Address")]
        [MaxLength(300, ErrorMessage = "Address must be less then 300 characters")]
        public string? Address { get; set; }
    }
}
