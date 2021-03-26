using EuCars.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EuCars.Shared
{
    public class Advertisement
    {
        public int Id { get; set; }

        [Required]
        public Brand Brand { get; set; }

        [Required]
        public string VehicleModel { get; set; }

        [Required]
        [Range(1950, 2021,
        ErrorMessage = "The year must be between {1} and {2}.")]
        public int ModelYear { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public Engine EngineType { get; set; }

        [Required]
        public Transmission Transmission { get; set; }

        [Required]
        [Range(1, 1000,
        ErrorMessage = "The horse powers must be between {1} and {2}.")]
        public int HorsePower { get; set; }

        [Required]
        public double Kilowatts { get; set; }

        [Required]
        public EuroStandart EuroStandart { get; set; }

        [Required]
        public Condition Condition { get; set; }

        [Required]
        public int Kilometers { get; set; }

        [Required]
        public Country Location { get; set; }

        [Required]
        [Range(1, 999999,
        ErrorMessage = "The price must be between {1} and {2} euro.")]
        public double Price { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public List<Image> Images { get; set; } = new List<Image>();

        [Required]
        public string Description { get; set; }

        public string UserId { get; set; }

        public EuCarsUser User { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
