﻿using Microsoft.Extensions.Hosting;
using RealEstate.API.DTO;

namespace RealEstate.API.Model
{
    
    public class RealEstateModel
    {
        public int Id { get; set; }

        //  public string Name { get; set; }

        public string Address { get; set; }

        public decimal Area { get; set; }

        public int Rating { get; set; }

        public decimal PricePerMetre { get; set; }

        public decimal Price { get; set; }
    }
}
