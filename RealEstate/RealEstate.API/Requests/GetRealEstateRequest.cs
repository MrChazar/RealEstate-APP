using MediatR;
using RealEstate.API.DTO;

namespace RealEstate.API.Requests
{
    public class GetRealEstateRequest : IRequest<IEnumerable<RealEstateDTO>>
    {

    }
}
