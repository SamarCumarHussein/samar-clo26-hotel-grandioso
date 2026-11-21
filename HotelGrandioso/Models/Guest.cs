using System;
using System.Collections.Generic;
using System.Text;

namespace HotelGrandioso.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

    }
}
