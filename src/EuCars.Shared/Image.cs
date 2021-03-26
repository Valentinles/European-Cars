using System;
using System.Collections.Generic;
using System.Text;

namespace EuCars.Shared
{
    public class Image
    {
        public int Id { get; set; }

        public string ImageContent { get; set; }


        public int AdvertisementId { get; set; }

        public Advertisement Advertisement { get; set; }
    }
}
