using EuCars.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EuCars.Shared
{
    public class AdvertisementSearchModel
    {
        public Brand Brand { get; set; }

        [Required(ErrorMessage = "Car's model is required.")]
        public string VehicleModel { get; set; }

        [Required]
        public int ModelYearFrom { get; set; }

        [Required]
        public int ModelYearTo { get; set; }

        public Category Category { get; set; }

        public Engine EngineType { get; set; }

        public Transmission Transmission { get; set; }

        [Required]
        public int HorsePowerFrom { get; set; }

        [Required]
        public int HorsePowerTo { get; set; }

        public Country Location { get; set; }

        [Required]
        public double PriceFrom { get; set; }

        [Required]
        public double PriceTo { get; set; }
    }
}
