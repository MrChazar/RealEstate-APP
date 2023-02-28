using Microsoft.AspNetCore.Mvc;
using RealEstate.API.DTO;
using System.ComponentModel.DataAnnotations;

namespace RealEstate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RealEstateController : ControllerBase
    {
        private static List<RealEstateDTO> _realEstates = new List<RealEstateDTO>() {new RealEstateDTO { Address = "Wittiga",PricePerMetre = 100, Area = 20, Rating = 9 , Price=100*230 } };

        [HttpGet("Search", Name = "SearchRealEstate")]
        public IEnumerable<RealEstateDTO> Search([Required] string partOfName)
        {
            return _realEstates.Where(x => x.Address.Contains(partOfName, StringComparison.OrdinalIgnoreCase));
        }

        [HttpPost("Post", Name = "PostRealEstate")]
        public IEnumerable<RealEstateDTO> Post([FromBody]CreateRealEstateDTO dto)
        {
            if (_realEstates.Any(x => x.Address == dto.Adress))
            {
                return _realEstates;
            }

            _realEstates.Add(new RealEstateDTO { Address = dto.Adress, Area = dto.Area, Rating = dto.Rating, PricePerMetre= dto.PricePerMetre, Price = dto.Area*dto.PricePerMetre });
            return _realEstates;
        }

        [HttpGet("Get", Name = "GetRealEstate")]
        public IEnumerable<RealEstateDTO> Get()
        {
            return _realEstates;
        }

    }
}
