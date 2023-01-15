using System.ComponentModel.DataAnnotations;

namespace Proiect_master.Models.ShopViewModel
{
    public class OrderGroup
    {
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        public int InstrumentCount { get; set; }
    }
}
