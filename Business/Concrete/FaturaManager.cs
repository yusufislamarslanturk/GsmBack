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
    public class FaturaManager : IFaturaService
    {
        IFaturaDal _faturaDal;
        public FaturaManager(IFaturaDal faturaDal)
        {
            _faturaDal = faturaDal;

        }
        public IResult Add(Fatura fatura)
        {
            _faturaDal.Add(fatura);
            return new SuccessResult("Fatura eklendi");
        }

        public IResult AddTransactionalTest(Fatura fatura)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Fatura fatura)
        {
            _faturaDal.Delete(fatura);
            return new SuccessResult("fatura silindi");

        }

        public IDataResult<List<Fatura>> GetAll()
        {
            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll());
        }

        public IDataResult<List<Fatura>> GetAllByCategoryId(int id)
        {
            var result = _faturaDal.GetAll(c => c.faturaId == id);
            return new SuccessDataResult<List<Fatura>>(result);
        }

        public IDataResult<Fatura> GetById(int faturaId)
        {

            var result = _faturaDal.Get(c => c.faturaId == faturaId);
            return new SuccessDataResult<Fatura>(result, "ıd ye göre listelendi");
        }

        public IDataResult<List<Fatura>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Fatura fatura)
        {
            _faturaDal.Update(fatura);
            return new SuccessDataResult<List<Fatura>>("Fatura güncellendi");
        }
    }
}
