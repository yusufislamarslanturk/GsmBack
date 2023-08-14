using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MusteriTarifeDTO:IDto
    {
        public int tarifeId { get; set; }
        public string tarifeAdi { get; set; }
        public int musteriTarifeId { get; set; }
        public DateTime baslangic { get; set; }
        public DateTime bitis { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string TC { get; set; }
        public string GSMno { get; set; }
    }
}
