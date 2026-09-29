using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCarRegistry.Models
{
    public class Car
    {
        public int Id {  get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string? Brand { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string? Type { get; set; }


        [Range(1915, 2050)]
        public int Year {  get; set; }


        [Range(1, 10000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Rendszám")]
        [StringLength(10, MinimumLength = 4)]
        [RegularExpression(@"^[A-Z0-9\- ]+$",
        ErrorMessage = "Kizárólag nagybetűket, szóközt és elválasztójelet írjon")]
        public string? LicensePlate { get; set; }
    }
}
