using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMusteriTarifeDal : EfEntityRepositoryBase<MusteriTarife, NorthwindContext>, IMusteriTarifeDal
    {
        public List<MusteriTarifeDTO> GetMusteriDetails()
        {
            using (NorthwindContext ctx = new NorthwindContext())
            {
                var result = from mt in ctx.musteriTarife
                             join m in ctx.musteri
                             on mt.musteriId equals m.musteriId
                             join t in ctx.tarife
                             on mt.tarifeId equals t.tarifeId
                             select new MusteriTarifeDTO
                             {
                                 tarifeId = mt.tarifeId,
                                 tarifeAdi = t.tarifeAdi,
                                 musteriTarifeId = mt.musteriTarifeId,
                                 baslangic = mt.baslangic,
                                 bitis = mt.bitis,
                                 ad=m.ad,
                                 soyad=m.soyad,
                                 TC=m.TC,
                                 GSMno=m.GSMno
                             };
            return result.ToList();             
            }
        }
    }
}
