using AutoMapper;
using MediatR;
using RealEstate.API.DTO;
using RealEstate.API.Requests;

namespace RealEstate.API.Handlers
{
    public class GetRealEstateHandler : IRequestHandler<GetRealEstateRequest, IEnumerable<RealEstateDTO>>
    {
        private DataContext _dataContext;
        private readonly IMapper _mapper;
        public GetRealEstateHandler(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<RealEstateDTO>> Handle(GetRealEstateRequest request, CancellationToken cancellationToken)
        {
            var mod = _dataContext.RealEstates;
            var result = _mapper.Map<IEnumerable<RealEstateDTO>>(mod);
            return result;
        }
    }
}
