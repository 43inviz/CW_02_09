using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_02_09_new
{
    internal class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountOfEmployee { get; set; }

        public Company? Company { get; set; }

        public List<Buyer> Custumers { get; set; } 

    }
}
