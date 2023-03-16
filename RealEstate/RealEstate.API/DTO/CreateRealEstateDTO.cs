using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RealEstate.API.DTO
{
    public class CreateRealEstateDTO
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        [RegularExpression("[A-Za-z]+ [0-9]+")]
        public string Adress { get; set; }
        [Required]
        [Range(10, (double)Decimal.MaxValue)]
        public decimal Area { get; set; }
        [Required]
        [Range(1,10)]
        public int Rating { get; set; }
        public decimal PricePerMetre { get; set; }
        public int RealEstateTypeId { get; set; }
        public bool IsHighlyRated => Rating > 5;
    }
}
