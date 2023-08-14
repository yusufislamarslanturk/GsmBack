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
    public interface IMusteriTarifeService
    {
        IDataResult<List<MusteriTarife>> GetAll();
        IDataResult<List<MusteriTarife>> GetAllByCategoryId(int id);

        IDataResult<List<MusteriTarife>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<MusteriTarife> GetById(int musteriTarifeId);
        IResult Add(MusteriTarife musteriTarife);
        IResult Update(MusteriTarife musteriTarife);
        IResult Delete(MusteriTarife musteriTarife);
        IResult AddTransactionalTest(MusteriTarife musteriTarife);
        IDataResult<List<MusteriTarifeDTO>> GetMusteriTarifeDetails();
    }
}
