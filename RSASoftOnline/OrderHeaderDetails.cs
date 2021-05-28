using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSASoftOnline
{
    public class OrderHeaderDetails
    {
        public string PONumber { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public float Total { get; set; }
        public int NumberOfLines { get; set; }
        public List<OrderLineDetails> LineDetails { get; set; }
    }
}
