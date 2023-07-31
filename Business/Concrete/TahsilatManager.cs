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
            throw new NotImplementedException();
        }

        public IResult AddTransactionalTest(Tahsilat tahsilat)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Tahsilat tahsilat)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Tahsilat>> GetAll()
        {
            return new SuccessDataResult<List<Tahsilat>>(_tahsilatDal.GetAll());
        }

        public IDataResult<List<Tahsilat>> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Tahsilat> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Tahsilat>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Tahsilat tahsilat)
        {
            throw new NotImplementedException();
        }
    }
}
