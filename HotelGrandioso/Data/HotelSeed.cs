
using HotelGrandioso.Models;

namespace HotelGrandioso.Data
{
    public class Seed
    {
        public static void SeedData(HotelContext context)
        {
            
            // Skapa rumstyper
       
            if (!context.RoomTypes.Any())
            {
                context.RoomTypes.Add(new RoomType
                {
                    Name = "Standard",
                    Description = "Standardrum"
                });

                context.RoomTypes.Add(new RoomType
                {
                    Name = "Luxury",
                    Description = "Lyxsvit"
                });

                context.RoomTypes.Add(new RoomType
                {
                    Name = "Bridal",
                    Description = "Bröllopssvit"
                });

                context.SaveChanges();
            }

            // Hämtar rumstyperna.
            RoomType standard = context.RoomTypes.First(r => r.Name == "Standard");
            RoomType luxury = context.RoomTypes.First(r => r.Name == "Luxury");
            RoomType bridal = context.RoomTypes.First(r => r.Name == "Bridal");


            // Kontrollera RUM 

            if (context.Rooms.Any())
            {
                return;
            }


 
            // Olika våningar med rum
            // Våning 3

            context.Rooms.Add(new Room
            {
                RoomNumber = 301,
                Floor = 3,
                SizeM2 = 120,
                PricePerNight = 1200,
                RoomTypeId = standard.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 302,
                Floor = 3,
                SizeM2 = 120,
                PricePerNight = 1200,
                RoomTypeId = standard.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 303,
                Floor = 3,
                SizeM2 = 120,
                PricePerNight = 1200,
                RoomTypeId = standard.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 304,
                Floor = 3,
                SizeM2 = 180,
                PricePerNight = 2800,
                RoomTypeId = luxury.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 305,
                Floor = 3,
                SizeM2 = 220,
                PricePerNight = 3500,
                RoomTypeId = bridal.Id
            });


            // Våning 2 

            context.Rooms.Add(new Room
            {
                RoomNumber = 201,
                Floor = 2,
                SizeM2 = 100,
                PricePerNight = 1000,
                RoomTypeId = standard.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 202,
                Floor = 2,
                SizeM2 = 100,
                PricePerNight = 1000,
                RoomTypeId = standard.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 203,
                Floor = 2,
                SizeM2 = 100,
                PricePerNight = 1000,
                RoomTypeId = standard.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 204,
                Floor = 2,
                SizeM2 = 100,
                PricePerNight = 1000,
                RoomTypeId = standard.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 205,
                Floor = 2,
                SizeM2 = 100,
                PricePerNight = 1000,
                RoomTypeId = standard.Id
            });


            //  Våning 1

            context.Rooms.Add(new Room
            {
                RoomNumber = 101,
                Floor = 1,
                SizeM2 = 80,
                PricePerNight = 800,
                RoomTypeId = standard.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 102,
                Floor = 1,
                SizeM2 = 80,
                PricePerNight = 800,
                RoomTypeId = standard.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 103,
                Floor = 1,
                SizeM2 = 80,
                PricePerNight = 800,
                RoomTypeId = standard.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 104,
                Floor = 1,
                SizeM2 = 80,
                PricePerNight = 800,
                RoomTypeId = standard.Id
            });

            context.Rooms.Add(new Room
            {
                RoomNumber = 105,
                Floor = 1,
                SizeM2 = 80,
                PricePerNight = 800,
                RoomTypeId = standard.Id
            });

            // Spara ändringarna i databasen

            context.SaveChanges();
        }
    }
}
