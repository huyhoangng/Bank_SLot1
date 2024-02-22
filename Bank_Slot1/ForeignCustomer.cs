using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Slot1
{
    public class ForeignCustomer : Customer
    {
        public string Nationality { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public double CalculateTotal()
        {
            return Quantity * UnitPrice;
        }
    }
}
