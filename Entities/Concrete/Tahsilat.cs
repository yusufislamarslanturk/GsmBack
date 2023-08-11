using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tahsilat:IEntity
    {
        public int tahsilatId { get; set; }
        public int tarifeId { get; set; }
        public int faturaId { get; set; }
        public DateTime tahsilTarihi { get; set; }
        public decimal tarifeUcreti { get; set; }
        public string TC { get; set; }
    }
}
