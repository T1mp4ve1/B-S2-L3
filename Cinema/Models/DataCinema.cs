namespace Cinema.Models
{
    public class DataCinema
    {
        public static List<Ticket> Tickets = new List<Ticket>();

        public static Dictionary<string, int> RoomCapacity = new Dictionary<string, int>
        {
            {"SALA NORD", 120 },
            {"SALA EST", 120 },
            {"SALA SUD", 120 },
        };

    }
}
