using System.ComponentModel.DataAnnotations;

namespace WebPocHub.Models
{
    public class Employee
    {
        //[Key]
        public int EmployeeId { get; set; }


        [MaxLength(100), Required(ErrorMessage ="Employee name is a required Field")]
        public string EmployeeName { get; set; } = string.Empty;
       
        
        [MaxLength(300)]
        public string Address { get; set; } = string.Empty;
        

        [MaxLength(50), Required(ErrorMessage = "Employee city is a required")]
        public string City { get; set; } = string.Empty;
        

        [MaxLength(10)]
        public string Phone { get; set; } = string.Empty;
        

        [MaxLength(100)]
        public string Zipcode { get; set; } = string.Empty;


        [MaxLength(100)]
        public string Avatar { get; set; } = string.Empty;


        [MaxLength(200), Required(ErrorMessage ="Email Caanot be blank"), EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}