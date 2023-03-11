using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace RealEstate.API.DTO
{
    public class RealEstateDTO
    {
        
        public int RealEstateId { get; set; }
        public string Address { get; set; }
      //  public RealEstateTypeDTO RealEstateType { get; set; } = null!;
        public decimal Area { get; set; }
        public int Rating { get; set; }
     //   public bool IsHighlyRated => Rating > 5;
        public decimal PricePerMetre { get; set; }
        public decimal Price { get; set; }
      
    }
}
