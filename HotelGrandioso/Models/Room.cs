using System;
using System.Collections.Generic;
using System.Text;

namespace HotelGrandioso.Models
{
    public  class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set ; }
        public int RoomTypeId { get; set; }
        public int Floor { get; set; }
        public decimal SizeM2 { get; set; }
        public decimal PricePerNight { get; set; }
        public List<Booking> Bookings { get; set; } = new();

    }
}
