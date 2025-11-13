namespace Cinema.Models
{
    public class DataCinema
    {
        public static List<Ticket> Tickets = new List<Ticket>();

        public static Dictionary<string, int> RoomCapacity = new Dictionary<string, int>
        {
        {"NORD", 120 },
        {"EST", 120 },
        {"SUD", 120 },
        };

        //TOTAL
        public static int GetTotalForRoom(string room)
        {
            return Tickets.Count(t => t.Room == room);
        }

        //RIDOTTI
        public static int GetReduced(string room)
        {
            return Tickets.Count(t => t.Room == room && t.Type == "Ridotto");
        }
    }
}
