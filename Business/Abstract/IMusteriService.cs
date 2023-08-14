using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        IDataResult<List<Musteri>> GetAll();
        IDataResult<List<Musteri>> GetAllByCategoryId(int id);

        IDataResult<List<Musteri>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<Musteri> GetById(int musteriId);
        IResult Add(Musteri musteri);
        IResult Update(Musteri musteri);
        IResult Delete(Musteri musteri);
        IResult AddTransactionalTest(Musteri musteri);
       
    }
}
