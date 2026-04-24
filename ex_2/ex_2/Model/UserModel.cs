using System.ComponentModel.DataAnnotations;

namespace ex_2.Model
{
    public class UserModel
    {
        public int UserID { get; set; } = 0;

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = "";

        public string? Address { get; set; }

        [Range(18, 120, ErrorMessage = "Must be at least 18 years old.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = "";
    }
}
