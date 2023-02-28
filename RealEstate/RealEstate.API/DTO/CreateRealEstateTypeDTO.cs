using System.ComponentModel.DataAnnotations;

namespace RealEstate.API.DTO
{
    public class CreateRealEstateTypeDTO
    {

        [Required]
        [StringLength(100, MinimumLength = 3)]
        [RegularExpression("[A-Za-z]")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        
    }
}
