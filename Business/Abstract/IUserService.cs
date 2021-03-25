using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService 
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetUserByFirstName(string userFirstName);
        IDataResult<List<User>> GetUserByLastName(string userLastName);
        IDataResult<List<User>> GetUserByEmail(string userEmail);
        IDataResult<List<User>> GetUserByPass(string userPas);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
