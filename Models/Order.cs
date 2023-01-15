using System.Diagnostics.Metrics;

namespace Proiect_master.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int InstrumentID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public Instrument Instrument { get; set; }
    }
}
