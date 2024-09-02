using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_02_09_new
{
    internal class Buyer
    {
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }

        public List<Shop> buyerShops { get; set; } = new List<Shop>();
    } 
}
