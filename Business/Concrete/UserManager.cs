using Business.Abstract;
using Core.Aspects.Transaction;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
           
        }

        //[TransactionScopeAspect]
        public IResult Add(User user)
        {
            var result = BusinessRules.Run(CheckIfEmailIsAlreadyRegistered(user.Email));
            
            if (false) return result;

            _userDal.Add(user);
            return new SuccessResult("eklendi");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult("silindi");
        }

        public IDataResult<List<User>> GetAll()
        {
            var result = _userDal.GetAll();
            return new SuccessDataResult<List<User>>(result, "listelendi");
        }

        public IDataResult<User> GetByEmail(string email)
        {
            var result = _userDal.Get(u => u.Email == email);
            return new SuccessDataResult<User>(result,"email getirildi");
        }

        public IDataResult<User> GetById(int id)
        {
            var result = _userDal.Get(u => u.Id == id);
            return new SuccessDataResult<User>(result, "ıd ye göre getirildi");
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            var result = _userDal.GetClaims(user);
            return new SuccessDataResult<List<OperationClaim>>(result, "roller listelendi");
        }

        public IDataResult<UserDTO> GetDTOById(int id)
        {
            var result = _userDal.GetDTO(u => u.Id == id);
            return new SuccessDataResult<UserDTO>(result, "id ye göre listelendi");
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("güncellendi");
        }

        public IResult UpdateEmail(UpdateEmailDTO updateEmailDTO)
        {
            var rulesResult = BusinessRules.Run(CheckIfEmailIsAlreadyRegistered(updateEmailDTO.Email));

            if (rulesResult != null)
            {
                return rulesResult;
            }

            var result = _userDal.Get(u => u.Id == updateEmailDTO.Id);
            result.Email = updateEmailDTO.Email;
            _userDal.Update(result);
            return new SuccessResult("email güncellendi");
        }

        public IResult UpdateFirstAndLastName(UpdateFirstAndLastNameDTO updateFirstAndLastNameDTO)
        {
            var result = _userDal.Get(u => u.Id == updateFirstAndLastNameDTO.Id);
            result.FirstName = updateFirstAndLastNameDTO.FirstName;
            result.LastName = updateFirstAndLastNameDTO.LastName;
            _userDal.Update(result);
            return new SuccessResult("ad soyad güncellendi");
        }

        private IResult CheckIfEmailIsAlreadyRegistered(string email)
        {
            var userResult = _userDal.Get(u => u.Email == email);
            if (userResult != null) return new ErrorResult("email zaten kayıtlı");

            return new SuccessResult("geldi");
        }
    }
}
