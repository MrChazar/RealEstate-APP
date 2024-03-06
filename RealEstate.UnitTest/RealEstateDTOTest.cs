using FluentAssertions;
using RealEstate.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.UnitTest
{
    public class RealEstateDTOTest
    {
        [Fact]
        public void IsHiglyRatedWhenBiggerThanFive()
        {
            var thing = new RealEstateDTO() { Rating = 6 };
            thing.IsHighlyRated.Should().BeTrue();
        }
        [Fact]
        public void IsHiglyRatedWhenSmallerThanFive()
        {
            var thing = new RealEstateDTO() { Rating = 4 };
            thing.IsHighlyRated.Should().BeFalse();
        }

    }
}
