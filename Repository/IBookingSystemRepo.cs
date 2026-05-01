using dsv_mini.model;

namespace dsv_mini.Repository;

public interface IBookingSystemRepo
{
    public void Update(Bookingsystem bookingsystem);
        

    public void Add(Bookingsystem bookingsystem);

    public void Delete(Bookingsystem bookingsystem);
}