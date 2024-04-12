using O2.cars.booking.core.common;
using O2.cars.booking.core.dto;

namespace O2.cars.booking.core.service;

public class BookService : IBookngService
{
    public Task AddBooking(BookingDto bookingDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteBooking(long id)
    {
        throw new NotImplementedException();
    }

    public Task<BookingDto> GetBooking(string reference)
    {
        throw new NotImplementedException();
    }

    public Task<BookingDto> GetBooking(long id)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<BookingDto>> GetBookings(string searchString, int index = 1, int size = 10)
    {
        throw new NotImplementedException();
    }

    public Task UpdateBooking(BookingDto bookingDto)
    {
        throw new NotImplementedException();
    }
}