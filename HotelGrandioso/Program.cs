
using HotelGrandioso.Data;
using HotelGrandioso.Services;
using HotelGrandioso.UI;
using Microsoft.EntityFrameworkCore;

namespace HotelGrandioso
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ansluter till databasen.
            using HotelContext context = new HotelContext();

            // Skapar databastabellerna med migrationer.
            context.Database.Migrate();

            // Lägger in rumstyper och rum.
            Seed.SeedData(context);

            // Skapar repository.
            HotelRepository repository = new HotelRepository(context);

            // Startar menyn.
            HotelMenu menu = new HotelMenu(repository);
            menu.Start();
        }
    }
}

