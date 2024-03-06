using MediatR;
using RealEstate.API.DTO;

namespace RealEstate.API.Requests
{
    public class GetRealEstateTypeRequest : IRequest<IEnumerable<RealEstateTypeDTO>>
    {
        public GetRealEstateTypeRequest()
        {

        }
    }
}
