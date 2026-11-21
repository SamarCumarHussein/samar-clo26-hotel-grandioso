using System;
using System.Collections.Generic;
using System.Text;

namespace HotelGrandioso.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int RoomId { get; set; }
    }
}
