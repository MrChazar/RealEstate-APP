using AutoMapper;
using MediatR;
using RealEstate.API.DTO;
using RealEstate.API.Requests;

namespace RealEstate.API.Handlers
{
    public class DeleteRealEstateTypeHandler : IRequestHandler<DeleteRealEstateTypeRequest, IEnumerable<RealEstateTypeDTO>>
    {
        private DataContext _dataContext;
        private readonly IMapper _mapper;
        public DeleteRealEstateTypeHandler(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RealEstateTypeDTO>> Handle(DeleteRealEstateTypeRequest request, CancellationToken cancellationToken)
        {
            var entityToDelete = _dataContext.RealEstateTypes.FirstOrDefault(x => x.Name == request.Partname);
            if (entityToDelete == null)
            {
                return null; // Return 404 if entity not found
            }

            // Remove the entity from the context and save changes
            _dataContext.RealEstateTypes.Remove(entityToDelete);
            _dataContext.SaveChanges();

            // Map and return the remaining entities as DTOs
            var remainingEntities = _dataContext.RealEstateTypes.ToList();
            var result = _mapper.Map<IEnumerable<RealEstateTypeDTO>>(remainingEntities);
            return result;
        }

    }
}
