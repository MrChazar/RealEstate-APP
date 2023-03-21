using AutoMapper;
using RealEstate.API.DTO;
using RealEstate.API.Model;
using System.Linq;

namespace RealEstate.API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Mapping in various ways between RealEstateModel,CreateRealEstateModel and RealEstateDTO
            CreateMap<RealEstateModel, RealEstateDTO>()
                .ForMember(dest => dest.RealEstateId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.RealEstateTypeId, opt => opt.MapFrom(src => src.RealEstateType.Id));
            CreateMap<RealEstateDTO, RealEstateModel>();
            CreateMap<IEnumerable<RealEstateModel>, RealEstateDTO>();
        
            CreateMap<CreateRealEstateDTO, RealEstateModel>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Adress))
                .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                .ForMember(dest => dest.Area, opt => opt.MapFrom(src => src.Area))
                .ForMember(dest => dest.PricePerMetre, opt => opt.MapFrom(src => src.PricePerMetre))
                .ForMember(dest => dest.RealEstateTypeId, opt => opt.MapFrom(src => src.RealEstateTypeId));
            // Mapping in various ways between RealEstateTypeDTO,CreateRealEstateTypeDTO, and RealEstateTypeModel
            CreateMap<RealEstateTypeModel, RealEstateTypeDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
            CreateMap<RealEstateTypeDTO, RealEstateTypeModel>();
            CreateMap<IEnumerable<RealEstateTypeModel>, RealEstateTypeDTO>();
            CreateMap<CreateRealEstateTypeDTO, RealEstateTypeModel>();
           
        }
    }
}
