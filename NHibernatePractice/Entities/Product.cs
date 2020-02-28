using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernatePractice.Entities
{
    public class Product
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Price { get; set; }
        public virtual List<Store> StoresStockedIn { get; protected set; }

        public Product()
        {
            StoresStockedIn = new List<Store>();
        }
    }
}
