using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RealEstate.API.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices;

namespace RealEstate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RealEstateTypeController : ControllerBase
    {
        private static List<RealEstateTypeDTO> _realEstates = new List<RealEstateTypeDTO>() { new RealEstateTypeDTO { Name = "Apartment" }, new RealEstateTypeDTO { Name = "Plot" }, new RealEstateTypeDTO { Name = "Office" } };

        [HttpGet("Search",Name = "SearchRealEstateType")]
        public IEnumerable<RealEstateTypeDTO> Search([Required] string partOfName )
        {
            return _realEstates.Where(x => x.Name.Contains(partOfName,StringComparison.OrdinalIgnoreCase));
        }

        
        [HttpPost("Post",Name ="PostRealEstateType")]
        public IEnumerable<RealEstateTypeDTO> Post([Required] string name, string description)
        {
            if (_realEstates.Any(x => x.Name == name))
            {
                return _realEstates; 
            }
            _realEstates.Add(new RealEstateTypeDTO { Name = name, Description = description } );
            return _realEstates;
        }

        [HttpDelete("Delete", Name = "DeleteRealEstateType")]
        public IEnumerable<RealEstateTypeDTO> Delete([Required] string name)
        {
            _realEstates.RemoveAll(x => x.Name.Equals(name));
            return _realEstates;
        }

        [HttpGet("Get",Name = "GetRealEstateType")]
        public IEnumerable<RealEstateTypeDTO> Get()
        {
            return _realEstates;
        }
    }
}
