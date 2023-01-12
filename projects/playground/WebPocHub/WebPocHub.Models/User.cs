using System.ComponentModel.DataAnnotations;


namespace WebPocHub.Models
{
    public class User
    {
        public int UserId { get; set; }


        [MaxLength(30), EmailAddress, Required(ErrorMessage ="Email field is required")]
        public string Email { get; set; } = string.Empty;


        [MaxLength(200), Required(ErrorMessage ="Password Field is required")]
        public string Password { get; set; } = string.Empty;

        public int RoleId { get; set; }

        public Role? Role { get; set; }



    }
}
