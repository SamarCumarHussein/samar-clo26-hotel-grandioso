using HotelGrandioso.Data;
using HotelGrandioso.Models;
using Microsoft.EntityFrameworkCore;


namespace HotelGrandioso.Services
{
    public class HotelRepository
    {
        private HotelContext _context;


        public HotelRepository(HotelContext context)
        {
            _context = context;


        }

        // Visar alla rum med typ och pris.
        public List<Room> GetRooms()
        {
            return _context.Rooms.Include(r => r.RoomType).ToList(); ;
        }

        // Visar alla akutella bokningar med rum och gäst
        public List<Booking> GetBookings()
        {
            return _context.Bookings
           .Where(b => b.CheckOutDate > DateTime.Today)
           .Include(b => b.Room)
           .Include(b => b.Guest)
           .ToList();
        }

        // Lägger till en bokning i databasen.
        public void AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        // Ta bort en bokning samt kollar först om bokningen finns i databasen innan den tas bort
        public void RemoveBooking(Booking booking)
        {
            var bookingToRemove = _context.Bookings.FirstOrDefault(b => b.Id == booking.Id);
            if (bookingToRemove != null)
            {
                _context.Bookings.Remove(bookingToRemove);
                _context.SaveChanges();
            }
        }

        // Räknar ut totalpriset för en bokning baserat på antal nätter och pris per nattt.
        public decimal CalculateTotalPrice(Booking booking)
        {
            var nights = (booking.CheckOutDate - booking.CheckInDate).Days;
            return nights * booking.Room.PricePerNight;

        }
    }
} 


