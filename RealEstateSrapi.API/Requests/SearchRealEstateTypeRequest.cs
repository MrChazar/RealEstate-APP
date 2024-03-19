using MediatR;
using RealEstate.API.DTO;

namespace RealEstate.API.Requests
{
    public class SearchRealEstateTypeRequest : IRequest<IEnumerable<RealEstateTypeDTO>>
    {
        public SearchRealEstateTypeRequest(string partOfName)
        {
            PartOfName = partOfName;
        }

        public string PartOfName { get; set; }
    }
}
