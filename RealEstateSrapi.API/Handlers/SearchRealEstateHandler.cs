using AutoMapper;
using MediatR;
using RealEstate.API.Data;
using RealEstate.API.DTO;
using RealEstate.API.Requests;

namespace RealEstate.API.Handlers
{
    public class SearchRealEstateHandler : IRequestHandler<SearchRequest, IEnumerable<RealEstateDTO>>
    {
        private DataContext _dataContext;
        private readonly IMapper _mapper;
        public SearchRealEstateHandler(DataContext dataContext, IMapper mapper) 
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<RealEstateDTO>> Handle(SearchRequest request, CancellationToken cancellationToken)
        {

            var mod = _dataContext.RealEstates.Where(y => y.Address.Contains(request.PartOfName));
            var realEstateDtos = _mapper.Map<IEnumerable<RealEstateDTO>>(mod);
            return realEstateDtos;
        }
        
    }

}
