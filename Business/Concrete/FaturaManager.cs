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
            throw new NotImplementedException();
        }

        public IResult AddTransactionalTest(Fatura fatura)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Fatura fatura)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Fatura>> GetAll()
        {
            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll());
        }

        public IDataResult<List<Fatura>> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Fatura> GetById(int faturaId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Fatura>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Fatura fatura)
        {
            throw new NotImplementedException();
        }
    }
}
