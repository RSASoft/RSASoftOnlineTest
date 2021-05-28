using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSASoftOnline
{
    public class OrderLineDetails
    {
        public string StockCode { get; set; }
        public string StockDescription { get; set; }
        public int Quantity { get; set; }
        public double CustomerPrice { get; set; }
        public double Total { get; set; }

        public double GetTotal(int Quantity, double CustomerPrice)
        {
            return Quantity * CustomerPrice;
        }
    }
}
