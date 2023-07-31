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

    public class MusteriTarifeManager : IMusteriTarifeService
    {
        IMusteriTarifeDal _musteriTarifeDal;
        public MusteriTarifeManager(IMusteriTarifeDal musteriTarifeDal)
        {
            _musteriTarifeDal = musteriTarifeDal;

        }
        public IResult Add(MusteriTarife musteriTarife)
        {
            throw new NotImplementedException();
        }

        public IResult AddTransactionalTest(MusteriTarife musteriTarife)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(MusteriTarife musteriTarife)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriTarife>> GetAll()
        {
            return new SuccessDataResult<List<MusteriTarife>>(_musteriTarifeDal.GetAll());
        }

        public IDataResult<List<MusteriTarife>> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<MusteriTarife> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriTarife>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MusteriTarife musteriTarife)
        {
            throw new NotImplementedException();
        }
    }
}
