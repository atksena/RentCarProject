﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new Result(true, "Ürün Eklendi");
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new Result(true, "Ürün Silindi");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(cs => cs.UserId == customerId));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new Result(true, "Ürün Güncellendi");
        }
    }
}
