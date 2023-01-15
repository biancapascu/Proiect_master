namespace Proiect_master.Models
{
    public class ManufacturedInstruments
    {
        public int ManufacturersID { get; set; }
        public int InstrumentID { get; set; }
        public Manufacturers Manufacturers { get; set; }
        public Instrument Instrument { get; set; }
    }
}
