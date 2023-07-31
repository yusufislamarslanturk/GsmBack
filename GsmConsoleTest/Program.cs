using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace GsmConsoleTest
{
    public class Program
    {

        static ITarifeService _tarifeService;
        static ITahsilatDal _tahsilatDal;
        static IMusteriTarifeDal _musteriTarifeDal;
        static IFaturaDal _faturaDal;
        static void Main(string[] args)
        {
            FaturaManager faturaManager = new FaturaManager(new EfFaturaDal());
            foreach (var item in faturaManager.GetAll().Data)
            {
                Console.WriteLine(item.odendiMi);
            }
            //MusteriTarifeManager musteriTarifeManager = new MusteriTarifeManager(new EfMusteriTarifeDal());
            //foreach (var item in musteriTarifeManager.GetAll().Data)
            //{
            //    Console.WriteLine(item.baslangic);
            //}
            //TahsilatManager tahsilatManager = new TahsilatManager(new EfTahsilatDal());
            //foreach (var item in tahsilatManager.GetAll().Data)
            //{
            //    Console.WriteLine(item.TC);
            //}
            //TarifeManager tarifeManager = new TarifeManager(new EfTarifeDal());
            //foreach (var tarifeler in tarifeManager.GetAll().Data)
            //{
            //    Console.WriteLine(tarifeler.tarifeAdi);
            //}

        }
      
    }

}
