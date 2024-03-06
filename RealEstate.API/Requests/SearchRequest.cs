
using MediatR;
using RealEstate.API.DTO;

namespace RealEstate.API.Requests
{
    public class SearchRequest : IRequest<IEnumerable<RealEstateDTO>>
    {
        public SearchRequest(string partOfName)
        {
            PartOfName = partOfName;
        }

        public string PartOfName { get; set; }


    }
}