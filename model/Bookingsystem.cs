namespace dsv_mini.model;

public class Bookingsystem
{
    public string Organizer { get; set; }
    public int Id { get; set; }

    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public int RoomId { get; set; }

    public string Comment { get; set; } = string.Empty;

    private static int BookingCounter = 1;

    public Bookingsystem()
    {
        Id = BookingCounter++;
    }
}