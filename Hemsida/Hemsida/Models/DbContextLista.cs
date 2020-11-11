using Hemsida.Models;
using System;
using System.Collections.Generic;

namespace Hemsida.Models
{
    public static class DbContextLista
    {
        // Har listor som representerar vår databas istället för riktig.
        // Här ska jag lägga till banor sedan. 10 st som ska vara bokningsbara. 
        public static List<Room> Rooms { get; set; }
        public static List<Booking> Bookings { get; set; }

        static DbContextLista()
        {
            Rooms = new List<Room>();
            Bookings = new List<Booking>();

            Seed();
        }

        private static void Seed()
        {
            var room1 = new Room() { Id = Guid.NewGuid(), Name = "Firelink Shrine", Floor = 1, Size = 10 };
            var room2 = new Room() { Id = Guid.NewGuid(), Name = "Irithyll", Floor = 2, Size = 6 };
            var room3 = new Room() { Id = Guid.NewGuid(), Name = "Ringed City", Floor = 3, Size = 12 };

            Rooms.Add(room1);
            Rooms.Add(room2);
            Rooms.Add(room3);

            var booking1 = new Booking
            {
                Id = Guid.NewGuid(),
                Booker = "Mohammad",
                RoomId = room1.Id,
                RoomName = room1.Name,
                From = new DateTime(2020, 10, 25, 14, 0, 0),
                To = new DateTime(2020, 10, 25, 16, 0, 0)
            };

            var booking2 = new Booking
            {
                Id = Guid.NewGuid(),
                Booker = "Philip",
                RoomId = room2.Id,
                RoomName = room2.Name,
                From = new DateTime(2020, 10, 26, 14, 0, 0),
                To = new DateTime(2020, 10, 26, 16, 0, 0)
            };

            Bookings.Add(booking1);
            Bookings.Add(booking2);
        }
    }
}
