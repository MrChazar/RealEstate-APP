using MediatR;
using RealEstate.API.DTO;

namespace RealEstate.API.Requests
{
    public class DeleteRealEstateTypeRequest : IRequest<IEnumerable<RealEstateTypeDTO>>
    {
        public DeleteRealEstateTypeRequest(string partname)
        {
            Partname = partname;
        }

        public string Partname { get; set; }
    }
}
