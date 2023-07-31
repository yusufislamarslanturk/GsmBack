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
    public class TahsilatManager : ITahsilatService
    {
        ITahsilatDal _tahsilatDal;
        public TahsilatManager(ITahsilatDal tahsilatDal)
        {
            _tahsilatDal = tahsilatDal;

        }
        public IResult Add(Tahsilat tahsilat)
        {
            _tahsilatDal.Add(tahsilat);
            return new SuccessResult("tahsilat yapıldı");
        }

        public IResult AddTransactionalTest(Tahsilat tahsilat)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Tahsilat tahsilat)
        {
            _tahsilatDal.Delete(tahsilat);
            return new SuccessResult("tahsilat silindi");
        }

        public IDataResult<List<Tahsilat>> GetAll()
        {
            return new SuccessDataResult<List<Tahsilat>>(_tahsilatDal.GetAll());
        }

        public IDataResult<List<Tahsilat>> GetAllByCategoryId(int id)
        {
            var result = _tahsilatDal.GetAll(c=> c.tahsilatId == id);
            return new SuccessDataResult<List<Tahsilat>>(result, "Tahsilatlar listelendi");
        }

        public IDataResult<Tahsilat> GetById(int productId)
        {
            var result = _tahsilatDal.Get(c=>c.tahsilatId == productId);
            return new SuccessDataResult<Tahsilat>(result,"Tahsilatlar id ye göre listelendi");
        }

        public IDataResult<List<Tahsilat>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Tahsilat>>(_tahsilatDal.GetAll(p => p.tarifeUcreti >= min && p.tarifeUcreti <= max));
        }

        public IResult Update(Tahsilat tahsilat)
        {
            throw new NotImplementedException();
        }
    }
}
