using System.ComponentModel.DataAnnotations;

namespace BankCMS.Models
{
    public class Customer
    {
        [Range(1,10)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

      [EmailAddress]
        public string Email { get; set; }
    }
}
