using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate.API.DTO;
using RealEstate.API.Model;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace RealEstate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RealEstateController : ControllerBase
    {
        private DataContext _dataContext;
        private readonly IMapper _mapper;

        public RealEstateController(DataContext dataContext,IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }


        [HttpGet("Search", Name = "SearchRealEstate")]
        public async Task<ActionResult<IEnumerable<RealEstateDTO>>> Search([Required] string partOfName)
        {
            var mod = _dataContext.RealEstates.Where(y => y.Address.Contains(partOfName));
            var realEstateDtos = _mapper.Map<IEnumerable<RealEstateDTO>>(mod);
            return Ok(realEstateDtos);
        }

        [HttpPost("Post", Name = "PostRealEstate")]
        public async Task<ActionResult> Post([FromBody] CreateRealEstateDTO dto)
        {
            var input = _mapper.Map<RealEstateModel>(dto);
            _dataContext.RealEstates.Add(input);
            _dataContext.SaveChanges();
            return Ok();
        }

        [HttpGet("Get", Name = "GetRealEstate")]
        public async Task<ActionResult<IEnumerable<RealEstateDTO>>> Get()
        {
            var mod = _dataContext.RealEstates;
            var result = _mapper.Map<IEnumerable<RealEstateDTO>>(mod);
            return Ok(result);
        }

    }
}
