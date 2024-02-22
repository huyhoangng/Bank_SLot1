using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Slot1
{
    public class Vietnam : Customer
    {
        public string CustomerType { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public double CalculateTotal()
        {
            double totalPrice;
            int threshold = 200;

            if (Quantity <= threshold)
            {
                totalPrice = Quantity * UnitPrice;
            }
            else
            {
                double newUnitPrice;
                if (Quantity <= 50)
                    newUnitPrice = 1000;
                else if (Quantity <= 100)
                    newUnitPrice = 1200;
                else if (Quantity <= 200)
                    newUnitPrice = 1500;
                else
                    newUnitPrice = 2000;

                totalPrice = threshold * UnitPrice + (Quantity - threshold) * newUnitPrice;
            }

            return totalPrice;
        }
    }
}
