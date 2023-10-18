using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int ID { get; set; }
        [Required(ErrorMessage = "Nie podałeś imienia!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Podane imię jest za długie!")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Podany mail jest nieprawidłowy!")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Podany numer telefonu jest nieprawidłowy!")]
        public string Phone { get; set; }
        public DateTime? Birth { get; set; }
    }
}
