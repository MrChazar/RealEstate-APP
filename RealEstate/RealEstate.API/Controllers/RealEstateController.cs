using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstate.API.DTO;
using RealEstate.API.Handlers;
using RealEstate.API.Model;
using RealEstate.API.Requests;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace RealEstate.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RealEstateController : ControllerBase
    {
        
        private readonly IMediator _mediatr;

        public RealEstateController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }


        [HttpGet("Search", Name = "SearchRealEstate")]
        public async Task<ActionResult<IEnumerable<RealEstateDTO>>> Search([Required] string partOfName)
        {
            
            return Ok( await _mediatr.Send(new SearchRequest(partOfName)));
        }

        [HttpPost("Post", Name = "PostRealEstate")]
        public async Task<ActionResult> Post([FromBody] CreateRealEstateDTO dto)
        {
            await _mediatr.Send(dto);
            return Ok();
        }

        [HttpGet("Get", Name = "GetRealEstate")]
        public async Task<ActionResult<IEnumerable<RealEstateDTO>>> Get()
        {
            return Ok(await _mediatr.Send(new GetRealEstateRequest()));
        }

    }
}
