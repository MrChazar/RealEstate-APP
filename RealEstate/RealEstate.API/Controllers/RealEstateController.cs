using Microsoft.AspNetCore.Mvc;
using RealEstate.API.DTO;
using RealEstate.API.Model;
using System.ComponentModel.DataAnnotations;

namespace RealEstate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RealEstateController : ControllerBase
    {
        private DataContext _dataContext;

        public RealEstateController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        [HttpGet("Search", Name = "SearchRealEstate")]
        public async Task<ActionResult<IEnumerable<RealEstateDTO>>> Search([Required] string partOfName)
        {
            var mod = _dataContext.RealEstates.Where(y => y.Address.Contains(partOfName));
            var result = mod.Select(x => new RealEstateDTO 
            {
                RealEstateId = x.Id,
                Address = x.Address,
                Area = x.Area, 
                PricePerMetre = x.PricePerMetre, 
                Price = x.Area * x.PricePerMetre, 
                Rating = x.Rating 
            });
            return Ok(result);
        }
        
        [HttpPost("Post", Name = "PostRealEstate")]
        public async Task<ActionResult> Post([FromBody]CreateRealEstateDTO dto)
        {
            var input = new RealEstateModel
            {
                Address = dto.Adress,
                Area = dto.Area,
                PricePerMetre = dto.PricePerMetre,
                Price = dto.PricePerMetre * dto.Area,
                Rating = dto.Rating
            };
            _dataContext.RealEstates.Add(input);
            _dataContext.SaveChanges();
            return Ok();
        }

        [HttpGet("Get", Name = "GetRealEstate")]
        public async Task<ActionResult<IEnumerable<RealEstateDTO>>> Get()
        {
            var mod = _dataContext.RealEstates;
            var result = mod.Select(x => new RealEstateDTO
            {
                RealEstateId = x.Id,
                Address = x.Address,
                Area = x.Area,
                PricePerMetre = x.PricePerMetre,
                Price = x.Area * x.PricePerMetre,
                Rating = x.Rating
            });
            return Ok(result);
        }

    }
}
