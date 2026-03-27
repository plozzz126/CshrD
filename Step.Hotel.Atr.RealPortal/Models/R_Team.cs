using Microsoft.AspNetCore.Identity;

namespace Step.Hotel.Atr.RealPortal.Models
{
    public class R_Team
    {
        public int Id { get; set; }

        public string PictureUrl { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Desctiption { get; set; }
    }
}
