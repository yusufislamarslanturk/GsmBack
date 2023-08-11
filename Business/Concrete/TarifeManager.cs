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
            _tarifeDal.Delete(tarife);
            return new SuccessResult("tarife silindi");

        }

        public IDataResult<List<Tarife>> GetAll()
        {
            return new SuccessDataResult<List<Tarife>>(_tarifeDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Tarife>> GetAllByCategoryId(int id)
        {
            var result = _tarifeDal.GetAll(c => c.tarifeId == id);
            return new SuccessDataResult<List<Tarife>>(result);
        }

        public IDataResult<Tarife> GetById(int tarifeId)
        {
            var result = _tarifeDal.Get(c => c.tarifeId == tarifeId);
            return new SuccessDataResult<Tarife>(result);
        }

        public IDataResult<List<Tarife>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Tarife>>(_tarifeDal.GetAll(p => p.tarifeUcreti >= min && p.tarifeUcreti <= max));
        }

        public IResult Update(Tarife tarife)
        {
            _tarifeDal.Update(tarife);
            return new SuccessResult("tarife güncellendi");
        }
    }
}
