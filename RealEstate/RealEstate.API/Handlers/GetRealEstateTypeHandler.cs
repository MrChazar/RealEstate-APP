using AutoMapper;
using MediatR;
using RealEstate.API.DTO;
using RealEstate.API.Requests;

namespace RealEstate.API.Handlers
{
    public class GetRealEstateTypeHandler : IRequestHandler<GetRealEstateTypeRequest, IEnumerable<RealEstateTypeDTO>>
    {
        private DataContext _dataContext;
        private readonly IMapper _mapper;
        public GetRealEstateTypeHandler(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RealEstateTypeDTO>> Handle(GetRealEstateTypeRequest request, CancellationToken cancellationToken)
        {
            var mod = _dataContext.RealEstateTypes;
            var result = _mapper.Map<IEnumerable<RealEstateTypeDTO>>(mod);
            return result;
        }
    }
}
