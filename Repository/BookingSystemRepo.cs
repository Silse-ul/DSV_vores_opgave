using dsv_mini.model;

namespace dsv_mini.Repository;

public class BookingSystemRepo : IBookingSystemRepo
{
    private List<Bookingsystem> _bookingList;

    public BookingSystemRepo()
    {
        //tom liste 
        _bookingList = new List<Bookingsystem>();
    }

    public void Delete(Bookingsystem bookingsystem)
    {
        throw new NotImplementedException();
    }

    public void Add(Bookingsystem bookingsystem)
    {
        int nextId = _bookingList.Count + 1;

            
        bookingsystem.RoomId = nextId;

            
        _bookingList.Add(bookingsystem);
    }

    public void Update(Bookingsystem bookingsystem)
    {
        throw new NotImplementedException();
    }
}