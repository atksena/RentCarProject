using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetRentalById(int rId);
        IDataResult<List<Rental>> GetRentalByCarId(int carId);
        IDataResult<List<Rental>> GetRentalByCustomerId(int custId);
        IDataResult<List<Rental>> GetRentalByRentDate(DateTime rentDt);
        IDataResult<List<Rental>> GetRentalByReturnDate(DateTime retrnDt);
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
