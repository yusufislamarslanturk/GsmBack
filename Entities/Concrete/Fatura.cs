using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Fatura:IEntity
    {
        public int faturaId { get; set; }
        public int tarifeId { get; set; }
        public int musteriTarifeId { get; set; }
        public decimal donemUcreti { get; set; }
        public string donemAdi { get; set; }
        public  bool odendiMi { get; set; }
        public string TC { get; set; }
    }
}
