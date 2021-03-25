using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new Result(true, "Ürün Eklendi");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new Result(true, "Ürün Silindi");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<User>> GetUserByEmail(string userEmail)
        {
            return new SuccessDataResult< List <User>> (_userDal.GetAll(ue => ue.Email == userEmail));
        }

        public IDataResult<List<User>> GetUserByFirstName(string userFirstName)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(uf => uf.FirstName == userFirstName));
        }

        public IDataResult<List<User>> GetUserByLastName(string userLastName)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(ul => ul.LastName == userLastName));

        }

        public IDataResult<List<User>> GetUserByPass(string userPas)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(up => up.Password == userPas));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new Result(true, "Ürün Güncellendi");
        }
    }
}
