using EuCars.Common;
using EuCars.Data;
using EuCars.Services.Interfaces;
using EuCars.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuCars.Services.Implementations
{
    public class AdvertisementService : DataService, IAdvertisementService
    {
        public AdvertisementService(EuCarsDbContext context) : base(context)
        {
        }

        public async Task<bool> CreateAdvertisement(Advertisement ad, string userName)
        {
            try
            {
                var user = await this.context.Users.FirstOrDefaultAsync(x => x.UserName == userName);
                ad.User = user;
                ad.UserId = user.Id;
                ad.Kilowatts = ad.HorsePower * ApplicationConstants.Kilowat;
                if (ad.Images.Count() == 0)
                {
                    var img = new Image() { ImageContent = ApplicationConstants.NoImage  };
                    ad.Images.Add(img);
                }
                await this.context.Advertisements.AddAsync(ad);
                await this.context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Task<List<Advertisement>> GetAll()
        {
            return Task.FromResult(this.context.Advertisements.Include(x => x.Images)
                .OrderByDescending(x=>x.CreatedOn)
                .ToList());
        }

        public Advertisement GetById(int id)
        {
            return this.context.Advertisements
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == id);
        }

        public List<Advertisement> Search(AdvertisementSearchModel searchModel)
        {
            var result = this.context.Advertisements.AsQueryable();

            if (searchModel != null)
            {
                result = result.Where(x => x.Brand.Equals(searchModel.Brand));
                result = result.Where(x => x.VehicleModel.Contains(searchModel.VehicleModel));
                result = result.Where(x => x.Category.Equals(searchModel.Category));
                result = result.Where(x => x.EngineType.Equals(searchModel.EngineType));
                result = result.Where(x => x.Transmission.Equals(searchModel.Transmission));
                result = result.Where(x => x.Location.Equals(searchModel.Location));
                result = result.Where(x => x.ModelYear >= searchModel.ModelYearFrom);
                result = result.Where(x => x.ModelYear <= searchModel.ModelYearTo);
                result = result.Where(x => x.HorsePower >= searchModel.HorsePowerFrom);
                result = result.Where(x => x.HorsePower <= searchModel.HorsePowerTo);
                result = result.Where(x => x.Price >= searchModel.PriceFrom);
                result = result.Where(x => x.Price <= searchModel.PriceTo);
            }
            return result.ToList();
        }
    }
}
