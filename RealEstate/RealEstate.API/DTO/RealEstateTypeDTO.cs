using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace RealEstate.API.DTO
{
    public class RealEstateTypeDTO
    {

        public string Name { get; set; }

        public string Description { get; set; }
        
    }
}
