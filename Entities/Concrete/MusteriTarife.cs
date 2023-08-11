using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MusteriTarife:IEntity
    {
        public int tarifeId { get; set; }
        public int musteriTarifeId { get; set; }
        public DateTime baslangic { get; set; }
        public DateTime bitis { get; set; }
        public int musteriId { get; set; }

    }
}
