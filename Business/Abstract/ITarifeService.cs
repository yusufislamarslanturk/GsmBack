using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITarifeService
    {
        IDataResult<List<Tarife>> GetAll();
        IDataResult<List<Tarife>> GetAllByCategoryId(int id);

        IDataResult<List<Tarife>> GetByUnitPrice(decimal min, decimal max);
    
        IDataResult<Tarife> GetById(int tarifeId);
        IResult Add(Tarife tarife);
        IResult Update(Tarife tarife);
        IResult Delete(Tarife tarife);
        IResult AddTransactionalTest(Tarife tarife);
    }
}
