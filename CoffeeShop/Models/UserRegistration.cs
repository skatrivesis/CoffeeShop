using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class UserRegistration
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string password;
        private string coffeePreference;
        private string newsletter;

        [DisplayName("First Name")]
        [MaxLength(20)]
        [MinLength(2)]
        [Required]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [MaxLength(20)]
        [MinLength(2)]
        [Required]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("Email")]
        [EmailAddress]
        [Required]
        public string Email { get => email; set => email = value; }

        [DisplayName("Phone")]
        [Required]
        public string Phone { get => phone; set => phone = value; }

        [DisplayName("Password")]
        [PasswordPropertyText]
        [Required]
        public string Password { get => password; set => password = value; }

        [DisplayName("Coffee Preference")]
        public string CoffeePreference { get => coffeePreference; set => coffeePreference = value; }
        
        [DisplayName("Newsletter Signup?")]
        public string Newsletter { get => newsletter; set => newsletter = value; }
    }
}
