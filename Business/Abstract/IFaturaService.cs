using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFaturaService
    {
        IDataResult<List<Fatura>> GetAll();
        IDataResult<List<Fatura>> GetAllByCategoryId(int id);

        IDataResult<List<Fatura>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<Fatura> GetById(int faturaId);
        IResult Add(Fatura fatura);
        IResult Update(Fatura fatura);
        IResult Delete(Fatura fatura);
        IResult AddTransactionalTest(Fatura fatura);
    }
}
