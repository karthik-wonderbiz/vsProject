using FirstApp.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstApp.DTO
{
    public class CustomerDTO
    {
        [Required(ErrorMessage = "Name is required!")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [MaxLength(100)]
        public string Email { get; set; }

        public bool IsActive { get; set; } = false;

        public int GenderId { get; set; }
    }
}
