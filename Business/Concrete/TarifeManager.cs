using Business.Abstract;
using Business.Constans;
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
    public class TarifeManager : ITarifeService
    {
       
        ITarifeDal _tarifeDal;
        public TarifeManager(ITarifeDal tarifeDal)
        {
            _tarifeDal = tarifeDal;

        }
        public IResult Add(Tarife tarife)
        {
            _tarifeDal.Add(tarife);

            return new SuccessResult(Messages.TarifeAdded);
        }

        public IResult AddTransactionalTest(Tarife tarife)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Tarife tarife)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Tarife>> GetAll()
        {
            return new SuccessDataResult<List<Tarife>>(_tarifeDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Tarife>> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Tarife> GetById(int tarifeId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Tarife>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Tarife tarife)
        {
            throw new NotImplementedException();
        }
    }
}
