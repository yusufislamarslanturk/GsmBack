using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Musteri:IEntity
    {
        public int musteriId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string TC { get; set; }
        public string GSMno { get; set; }
        public string Email { get; set; }

    }
}
