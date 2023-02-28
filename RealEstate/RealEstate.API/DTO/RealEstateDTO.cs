using System.Xml.Linq;

namespace RealEstate.API.DTO
{
    public class RealEstateDTO
    {

        public string Address { get; set; }
        //  public int MyProperty { get; set; }
        public decimal Area { get; set; }
        public int Rating { get; set; }
        public bool IsHighlyRated => Rating > 5;
        public decimal PricePerMetre { get; set; }
        public decimal Price { get; set; }
        

    }
}
