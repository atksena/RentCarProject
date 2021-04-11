﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new Result(true,"Ürün Eklendi");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, "Ürün Silindi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());

        }

        public IDataResult<List<Car>> GetCarsByBrandId(int bId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == bId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int cId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == cId));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, "Güncellendi");
        }
    } 
}
