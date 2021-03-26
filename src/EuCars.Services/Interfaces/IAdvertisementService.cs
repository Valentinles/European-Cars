using EuCars.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuCars.Services.Interfaces
{
    public interface IAdvertisementService
    {
        Task<bool> CreateAdvertisement(Advertisement ad, string userName);

        Task<List<Advertisement>> GetAll();

        Advertisement GetById(int id);

        List<Advertisement> Search(AdvertisementSearchModel searchModel);
    }
}
