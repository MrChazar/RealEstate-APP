using AutoMapper;
using MediatR;
using RealEstate.API.DTO;
using RealEstate.API.Model;

namespace RealEstate.API.Handlers
{
    public class CreateRealEstateHandler : IRequestHandler<CreateRealEstateDTO>
    {
        private DataContext _dataContext;
        private readonly IMapper _mapper;
        public CreateRealEstateHandler(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task Handle(CreateRealEstateDTO request, CancellationToken cancellationToken)
        {
            var input = _mapper.Map<RealEstateModel>(request);
            input.Price = request.PricePerMetre * request.Area;
            _dataContext.RealEstates.Add(input);
            _dataContext.SaveChanges();
            
        }
    }
}
