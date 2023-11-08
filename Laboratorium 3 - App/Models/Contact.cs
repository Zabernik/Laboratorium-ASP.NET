using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Laboratorium_3___App.Models
{
    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum e)
        {
            return e.GetType()
                .GetMember(e.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                .GetName();
        }
    }

    public enum Priority
    {
        [Display(Name = "Niski")]
        Low,
        [Display(Name = "Normalny")]
        Normal,
        [Display(Name = "Ważny")]
        Urgent
    }

    public class Contact
    {
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public int ID { get; set; }
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Nie podałeś imienia!")]
        [StringLength(maximumLength: 30, ErrorMessage = "Podane imię jest za długie!")]
        public string Name { get; set; }
        [Display(Name = "Adres Email")]
        [EmailAddress(ErrorMessage = "Podany mail jest nieprawidłowy!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Numer Telefonu")]
        [Phone(ErrorMessage = "Podany numer telefonu jest nieprawidłowy!")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Display(Name = "Data Urodzenia")]
        [DataType(DataType.Date)]
        public DateTime? Birth { get; set; }

        [HiddenInput]
        public DateTime Created { get; set; }
    }
}
