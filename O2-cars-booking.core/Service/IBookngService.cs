
using O2.cars.booking.core.common;
using O2.cars.booking.core.dto;

namespace O2.cars.booking.core.service;

public interface IBookngService
{
    Task<BookingDto> GetBooking(string reference);

    Task<BookingDto> GetBooking(long id);

    Task<PagedList<BookingDto>> GetBookings(string searchString, int index = 1, int size = 10);
    
    Task AddBooking(BookingDto bookingDto);

    Task UpdateBooking(BookingDto bookingDto);

    Task DeleteBooking(long id);
}