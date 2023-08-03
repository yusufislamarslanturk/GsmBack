using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITahsilatService
    {
        IDataResult<List<Tahsilat>> GetAll();
        IDataResult<List<Tahsilat>> GetAllByCategoryId(int id);

        IDataResult<List<Tahsilat>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<Tahsilat> GetById(int productId);
        IResult Add(Tahsilat tahsilat);
        IResult Update(Tahsilat tahsilat);
        IResult Delete(Tahsilat tahsilat);
        IResult AddTransactionalTest(Tahsilat tahsilat);
    }
}
