using System;
using System.Collections.Generic;
using System.Text;

namespace HotelGrandioso.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public List<Room> Rooms { get; set; } = new();

    }
}
