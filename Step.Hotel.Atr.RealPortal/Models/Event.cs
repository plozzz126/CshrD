namespace Step.Hotel.Atr.RealPortal.Models
{
    public class Event
    {
        public int id { get; set; }
        public DateTime CreateDate { get; set; }
        public int TypeImage { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ImagePath { get; set; }
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
