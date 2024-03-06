using AutoMapper;
using MediatR;
using RealEstate.API.DTO;
using RealEstate.API.Requests;

namespace RealEstate.API.Handlers
{
    public class SearchRealEstateTypeHandler : IRequestHandler<SearchRealEstateTypeRequest, IEnumerable<RealEstateTypeDTO>>
    {
        private DataContext _dataContext;
        private readonly IMapper _mapper;
        public SearchRealEstateTypeHandler(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<RealEstateTypeDTO>> Handle(SearchRealEstateTypeRequest request, CancellationToken cancellationToken)
        {
            var mod = _dataContext.RealEstateTypes.Where(x => x.Name == request.PartOfName);
            var result = _mapper.Map<IEnumerable<RealEstateTypeDTO>>(mod);
            return result;
        }
    }
}
