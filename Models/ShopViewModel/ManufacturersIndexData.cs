namespace Proiect_master.Models.ShopViewModel
{
    public class ManufacturersIndexData
    {
        public IEnumerable<Manufacturers> Manufacturers { get; set; }
        public IEnumerable<Instrument> Instruments { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
