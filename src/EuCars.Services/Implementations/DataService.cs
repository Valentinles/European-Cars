using EuCars.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EuCars.Services.Implementations
{
    public class DataService
    {
        protected readonly EuCarsDbContext context;

        public DataService(EuCarsDbContext context)
        {
            this.context = context;
        }
    }
}
