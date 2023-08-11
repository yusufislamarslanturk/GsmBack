using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tarife:IEntity
    {
        public int tarifeId { get; set; }
        public string tarifeAdi { get; set; }
        public decimal tarifeUcreti { get; set; }
        public int tarifeInternet { get; set; }
        public int tarifeSms { get; set; }
        public int tarifeDk { get; set; }
        public int tarifeSuresi { get; set; }
    }
}
