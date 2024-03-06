using MediatR;
using System.ComponentModel.DataAnnotations;

namespace RealEstate.API.DTO
{
    public class CreateRealEstateTypeDTO : IRequest
    {

        [Required]
        [StringLength(100, MinimumLength = 3)]
        /*[RegularExpression("[*]")] */
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
     

        
    }
}
