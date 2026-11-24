using HotelGrandioso.Models;
using HotelGrandioso.Services;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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

        // Bokar ett rum.
        private void BookRoom()
        {
            Console.Write("\nGästens namn: ");
            string guestName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(guestName))
            {
                Console.WriteLine("Ange gästens namn.");
                return;
            }

            Console.Write("Incheckning (ÅÅÅÅ-MM-DD): ");

            if (!DateTime.TryParse(Console.ReadLine(), out DateTime checkIn))
            {
                Console.WriteLine("Felaktigt datum.");
                return;
            }

            Console.Write("Utcheckning (ÅÅÅÅ-MM-DD): ");

            if (!DateTime.TryParse(Console.ReadLine(), out DateTime checkOut))
            {
                Console.WriteLine("Felaktigt datum.");
                return;
            }

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Felaktiga datum.");
                return;
            }

            // Visar alla rum.
            ShowRooms();

            Console.Write("\nAnge rumsnummer: ");

            if (!int.TryParse(Console.ReadLine(), out int roomNumber))
            {
                Console.WriteLine("Felaktigt rumsnummer.");
                return;
            }

            // Hittar valt rum.
            Room room = repository.GetRooms()
                .FirstOrDefault(r => r.RoomNumber == roomNumber);

            if (room == null)
            {
                Console.WriteLine("Rummet finns inte.");
                return;
            }

            // Kontrollerar om rummet redan är bokat.
            List<Booking> bookings = repository.GetBookings();

            foreach (Booking oldBooking in bookings)
            {
                if (oldBooking.RoomId == room.Id &&
                    checkIn < oldBooking.CheckOutDate &&
                    checkOut > oldBooking.CheckInDate)
                {
                    Console.WriteLine("Rummet är redan bokat.");
                    return;
                }
            }

           Guest guest = new Guest

