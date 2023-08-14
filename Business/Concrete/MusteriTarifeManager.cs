using Business.Abstract;
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

    public class MusteriTarifeManager : IMusteriTarifeService
    {
        IMusteriTarifeDal _musteriTarifeDal;
        public MusteriTarifeManager(IMusteriTarifeDal musteriTarifeDal)
        {
            _musteriTarifeDal = musteriTarifeDal;

        }
        public IResult Add(MusteriTarife musteriTarife)
        {
            _musteriTarifeDal.Add(musteriTarife);
            return new SuccessResult("eklendi");
        }

        public IResult AddTransactionalTest(MusteriTarife musteriTarife)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(MusteriTarife musteriTarife)
        {
            _musteriTarifeDal.Delete(musteriTarife);
            return new SuccessResult("silindi");

        }

        public IDataResult<List<MusteriTarife>> GetAll()
        {
            return new SuccessDataResult<List<MusteriTarife>>(_musteriTarifeDal.GetAll());
        }

        public IDataResult<List<MusteriTarife>> GetAllByCategoryId(int id)
        {
            var result = _musteriTarifeDal.GetAll(c => c.tarifeId == id);
            return new SuccessDataResult<List<MusteriTarife>>(result,"id ye göre ");
        }

        public IDataResult<MusteriTarife> GetById(int musteriTarifeId)
        {
            var result = _musteriTarifeDal.Get(c => c.musteriTarifeId ==musteriTarifeId);
            return new SuccessDataResult<MusteriTarife>(result,"ıd ye göre listeleme yapıldı");
        }

        public IDataResult<List<MusteriTarife>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriTarifeDTO>> GetMusteriTarifeDetails()
        {
            return new SuccessDataResult<List<MusteriTarifeDTO>>(_musteriTarifeDal.GetMusteriDetails());
        }

        public IResult Update(MusteriTarife musteriTarife)
        {
            _musteriTarifeDal.Update(musteriTarife);
            return new SuccessResult("güncellendi");
        }
    }
}
