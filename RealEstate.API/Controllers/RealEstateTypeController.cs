using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.API.DTO;
using RealEstate.API.Requests;
using System.ComponentModel.DataAnnotations;



namespace RealEstate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RealEstateTypeController : ControllerBase
    {
        
        private readonly IMediator _mediatr;

        
        public RealEstateTypeController(IMediator mediator)
        {
            _mediatr = mediator;
        }

        [HttpGet("Search",Name = "SearchRealEstateType")]
        public async Task<ActionResult<IEnumerable<RealEstateTypeDTO>>> Search([Required] string partOfName )
        {
            return Ok(await _mediatr.Send(new SearchRealEstateTypeRequest(partOfName)));
        }

        
        [HttpPost("Post",Name ="PostRealEstateType")]
        public async Task<ActionResult<IEnumerable<RealEstateTypeDTO>>> Post([FromBody]CreateRealEstateTypeDTO dto)
        {
            await _mediatr.Send(dto);
            return Ok();
        }

    
        [HttpDelete]
        public async Task<ActionResult<IEnumerable<RealEstateTypeDTO>>> Delete([Required] string name)
        {
            return Ok(await _mediatr.Send(new DeleteRealEstateTypeRequest(name)));
        }

        [HttpGet("Get",Name = "GetRealEstateType")]
        public async Task<ActionResult<IEnumerable<RealEstateTypeDTO>>> Get()
        {
            return Ok(await _mediatr.Send(new GetRealEstateTypeRequest()));
        }
    }
}
