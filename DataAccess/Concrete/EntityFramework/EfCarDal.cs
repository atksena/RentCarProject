using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from ca in context.Cars
                             join b in context.Brands                             
                             on ca.BrandId equals b.Id
                          join cl in context.Colors
                          on ca.ColorId equals cl.Id
                          select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 CarName = ca.CarName,
                              ColorName = cl.ColorName,
                              DailyPrice = ca.DailyPrice
                                 
                             };

                return result.ToList();
            }
        }
    }
}
