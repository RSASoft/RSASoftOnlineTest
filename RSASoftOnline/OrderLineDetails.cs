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
        public float CustomerPrice { get; set; }
        public float Total { get; set; }
    }
}
