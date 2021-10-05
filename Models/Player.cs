

namespace lab_5.Models
{
    public class Player
    {
        public string PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string TeamName { get; set; }
        public Team Team { get; set; }
    }
}