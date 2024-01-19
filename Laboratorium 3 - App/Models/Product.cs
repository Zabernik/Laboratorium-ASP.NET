using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public enum Category
    {
        [Display(Name = "Produkty mleczne")]
        Milky,
        [Display(Name = "Napoje")]
        Drinks,
        [Display(Name = "Produkty chemiczne")]
        ChemicalProducts,
        [Display(Name = "Inne")]
        Other
    }

    public class Product
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Nazwa Produktu")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Opis")]
        public string? Description { get; set; }

        [Display(Name = "Producent")]
        public string ProducerName { get; set; }

        [Display(Name = "Kategoria")]
        public Category Category { get; set; }

        [Display(Name = "Cena")]
        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Data Produkcji")]
        [DataType(DataType.Date)]
        public DateTime? DateOfProduction { get; set; }

        [ValidateNever]
        public List<SelectListItem> Producers { get; set; }
    }
}
