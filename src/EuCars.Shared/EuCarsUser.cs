using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EuCars.Shared
{
    public class EuCarsUser : IdentityUser
    {
        public string Name { get; set; }

        public List<Advertisement> Advertisements { get; set; }
    }
}
