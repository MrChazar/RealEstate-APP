using MediatR;
using AutoMapper;
using RealEstate.API.DTO;
using RealEstate.API.Model;

namespace RealEstate.API.Handlers
{
    public class CreateRealEstateTypeHandler : IRequestHandler<CreateRealEstateTypeDTO>
    {
        private DataContext _dataContext;
        private readonly IMapper _mapper;
        public CreateRealEstateTypeHandler(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task Handle(CreateRealEstateTypeDTO request, CancellationToken cancellationToken)
        {
            var input = _mapper.Map<RealEstateTypeModel>(request);
            _dataContext.RealEstateTypes.Add(input);
            _dataContext.SaveChanges();

        }

    }
}
