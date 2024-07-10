using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstApp.Model
{
    [Table("Customers")]
    [Index(nameof(Email), IsUnique = true)]
    public class Customer
    {
        
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [MaxLength(100)]
        public string Email { get; set; }

        public bool IsActive { get; set; } = false;

        public Gender Gender { get; set; }

        [ForeignKey("Gender")]
        public int GenderId { get; set; }

    }
}
