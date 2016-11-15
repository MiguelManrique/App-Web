using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Order
    {
        public override string ToString()
        {
            return ShipName;
        }

        public string ContactName
        {
            set { }
            get { return this.Customer.ContactName; }
        }

        public string City
        {
            set { }
            get { return this.Customer.City; }
        }
    }
}
