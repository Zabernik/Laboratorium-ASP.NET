using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public enum Producer
    {
        [Display(Name = "Nestle")]
        Nestle,
        [Display(Name = "Coca-Cola")]
        Cocacola,
        [Display(Name = "Pepsi")]
        Pepsi,
        [Display(Name = "British American Tobacco")]
        BAT
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
        public Producer Producer { get; set; }

        [Display(Name = "Cena")]
        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Data Produkcji")]
        [DataType(DataType.Date)]
        public DateTime? DateOfProduction { get; set; }

    }
}
