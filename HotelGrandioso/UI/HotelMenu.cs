using HotelGrandioso.Models;
using HotelGrandioso.Services;
using System;
using System.Linq;
using System.Collections.Generic;

namespace HotelGrandioso.UI
{
    public class HotelMenu
    {
        private HotelRepository repository;

        // Tar emot repository när menyn skapas.
        public HotelMenu(HotelRepository repository)
        {
            this.repository = repository;
        }

        // Startar huvudmenyn.
        public void Start()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== HOTEL GRANDIOSO ===");
                Console.WriteLine("1. Boka rum");
                Console.WriteLine("2. Avboka bokning");
                Console.WriteLine("3. Visa bokningar");
                Console.WriteLine("4. Visa alla rum");
                Console.WriteLine("5. Avsluta");
                Console.Write("\nVälj: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    BookRoom();
                }
                else if (choice == "2")
                {
                    CancelBooking();
                }
                else if (choice == "3")
                {
                    ShowBookings();
                }
                else if (choice == "4")
                {
                    ShowRooms();
                }
                else if (choice == "5")
                {
                    running = false;
                    Console.WriteLine("Programmet avslutas.");
                }
                else
                {
                    Console.WriteLine("Felaktigt val.");
                }
            }
        }

    

