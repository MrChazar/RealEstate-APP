using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RealEstate.API.DTO;
using RealEstate.API.Model;
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
        private DataContext _dataContext;
        private readonly IMapper _mapper;

        private static List<RealEstateTypeDTO> _realEstatesType = new List<RealEstateTypeDTO> { new RealEstateTypeDTO { Name = "Te", Description = "Całe" } };
        public RealEstateTypeController(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        [HttpGet("Search",Name = "SearchRealEstateType")]
        public async Task<ActionResult<IEnumerable<RealEstateTypeDTO>>> Search([Required] string partOfName )
        {
            var mod = _dataContext.RealEstateTypes.Where(y => y.Name.Contains(partOfName));
            var result = _mapper.Map<RealEstateTypeDTO>(mod);
            return Ok(result);
        }

        
        [HttpPost("Post",Name ="PostRealEstateType")]
        public async Task<ActionResult<IEnumerable<RealEstateTypeDTO>>> Post([FromBody]CreateRealEstateTypeDTO dto)
        {
            if (_dataContext.RealEstateTypes.Any(x => x.Name == dto.Name))
            {
                return NotFound(); 
            }

            var input = _mapper.Map<RealEstateTypeModel>(dto);
            _dataContext.RealEstateTypes.Add(input);
            _dataContext.SaveChanges();
            return Ok();
        }

     //   [HttpDelete("Delete", Name = "DeleteRealEstateType")]
        [HttpDelete]
        public async Task<ActionResult<IEnumerable<RealEstateTypeDTO>>> Delete([Required] string name)
        {
            
            var entityToDelete = _dataContext.RealEstateTypes.FirstOrDefault(x => x.Name == name);
            if (entityToDelete == null)
            {
                return NotFound(); // Return 404 if entity not found
            }

            // Remove the entity from the context and save changes
            _dataContext.RealEstateTypes.Remove(entityToDelete);
            _dataContext.SaveChanges();

            // Map and return the remaining entities as DTOs
            var remainingEntities = _dataContext.RealEstateTypes.ToList();
            var result = _mapper.Map<IEnumerable<RealEstateTypeDTO>>(remainingEntities);
            return Ok(result);
        }

        [HttpGet("Get",Name = "GetRealEstateType")]
        public async Task<ActionResult<IEnumerable<RealEstateTypeDTO>>> Get()
        {
            var mod = _dataContext.RealEstateTypes;
            var result = _mapper.Map<RealEstateTypeDTO>(mod);
            return Ok(result);
        }
    }
}
