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
        private static List<RealEstateTypeDTO> _realEstatesType = new List<RealEstateTypeDTO>() { new RealEstateTypeDTO { Name = "Apartment" , Description = "Simple As" }, new RealEstateTypeDTO { Name = "Plot" }, new RealEstateTypeDTO { Name = "Office" } };

        [HttpGet("Search",Name = "SearchRealEstateType")]
        public IEnumerable<RealEstateTypeDTO> Search([Required] string partOfName )
        {
            return _realEstatesType.Where(x => x.Name.Contains(partOfName,StringComparison.OrdinalIgnoreCase));
        }

        
        [HttpPost("Post",Name ="PostRealEstateType")]
        public IEnumerable<RealEstateTypeDTO> Post([FromBody]CreateRealEstateTypeDTO dto)
        {
            if (_realEstatesType.Any(x => x.Name == dto.Name))
            {
                return _realEstatesType; 
            }

            _realEstatesType.Add(new RealEstateTypeDTO { Name = dto.Name, Description = dto.Description } );
            return _realEstatesType;
        }

     //   [HttpDelete("Delete", Name = "DeleteRealEstateType")]
        [HttpDelete]
        public IEnumerable<RealEstateTypeDTO> Delete([Required] string name)
        {
            _realEstatesType.RemoveAll(x => x.Name.Equals(name));
            return _realEstatesType;
        }

        [HttpGet("Get",Name = "GetRealEstateType")]
        public IEnumerable<RealEstateTypeDTO> Get()
        {
            return _realEstatesType;
        }
    }
}
