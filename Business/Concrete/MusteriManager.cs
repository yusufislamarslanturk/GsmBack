using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteriDal;
        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;

        }
        public IResult Add(Musteri musteri)
        {
            throw new NotImplementedException();
        }

        public IResult AddTransactionalTest(Musteri musteri)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Musteri musteri)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Musteri>> GetAll()
        {
            return new SuccessDataResult<List<Musteri>>(_musteriDal.GetAll());
        }

        public IDataResult<List<Musteri>> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Musteri> GetById(int musteriId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Musteri>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Musteri musteri)
        {
            throw new NotImplementedException();
        }
    }
}
