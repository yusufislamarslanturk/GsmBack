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
            _musteriDal.Add(musteri);
            return new SuccessResult("musteri eklendi");
        }

        public IResult AddTransactionalTest(Musteri musteri)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Musteri musteri)
        {
            _musteriDal.Delete(musteri);
            return new SuccessResult("müşteri eklendi");
        }

        public IDataResult<List<Musteri>> GetAll()
        {
            return new SuccessDataResult<List<Musteri>>(_musteriDal.GetAll());
        }

        public IDataResult<List<Musteri>> GetAllByCategoryId(int id)
        {
            var result = _musteriDal.GetAll(c => c.musteriId == id);
            return new SuccessDataResult<List<Musteri>>(result,"Müşteriler Id ye göre listelendi");
        }

        public IDataResult<Musteri> GetById(int musteriId)
        {
            var result = _musteriDal.Get(c => c.musteriId == musteriId);
            return new SuccessDataResult<Musteri>(result);
        }

        public IDataResult<List<Musteri>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Musteri musteri)
        {
             _musteriDal.Update(musteri);
            return new SuccessResult("Müşteriler güncellendi");
        }
    }
}
