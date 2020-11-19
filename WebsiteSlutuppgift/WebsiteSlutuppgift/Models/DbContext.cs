using System;
using System.Collections.Generic;

namespace WebsiteSlutuppgift.Models
{
    public static class  DbContext // Låtsasdatabasen 
    {
        public static List<Track> Tracks { get; set; }
        public static List<Booking> Bookings { get; set; }
        public static List<Table> Tables { get; set; }
        public static List<BookingTable> BookingTables { get; set; }

        static DbContext()
        {
            Tracks = new List<Track>();
            Bookings = new List<Booking>();
            Tables = new List<Table>();
            BookingTables = new List<BookingTable>();

            Seed();
        }

        private static void Seed() 
        {
            var track1 = new Track() { Id = Guid.NewGuid(), Name = "Lane 1" };
            var track2 = new Track() { Id = Guid.NewGuid(), Name = "Lane 2" };
            var track3 = new Track() { Id = Guid.NewGuid(), Name = "Lane 3" };
            var track4 = new Track() { Id = Guid.NewGuid(), Name = "Lane 4" };
            var track5 = new Track() { Id = Guid.NewGuid(), Name = "Lane 5" };
            var track6 = new Track() { Id = Guid.NewGuid(), Name = "Lane 6" };
            var track7 = new Track() { Id = Guid.NewGuid(), Name = "Lane 7" };
            var track8 = new Track() { Id = Guid.NewGuid(), Name = "Lane 8" };
            var track9 = new Track() { Id = Guid.NewGuid(), Name = "Lane 9" };
            var track10 = new Track() { Id = Guid.NewGuid(), Name = "Lane 10" };

            Tracks.Add(track1);
            Tracks.Add(track2);
            Tracks.Add(track3);
            Tracks.Add(track4);
            Tracks.Add(track5);
            Tracks.Add(track6);
            Tracks.Add(track7);
            Tracks.Add(track8);
            Tracks.Add(track9);
            Tracks.Add(track10);

            var table1 = new Table() { Id = Guid.NewGuid(), Name = "Table 1" };
            var table2 = new Table() { Id = Guid.NewGuid(), Name = "Table 2" };
            var table3 = new Table() { Id = Guid.NewGuid(), Name = "Table 3" };
            var table4 = new Table() { Id = Guid.NewGuid(), Name = "Table 4" };
            var table5 = new Table() { Id = Guid.NewGuid(), Name = "Table 5" };
            var table6 = new Table() { Id = Guid.NewGuid(), Name = "Table 6" };
            var table7 = new Table() { Id = Guid.NewGuid(), Name = "Table 7" };
            var table8 = new Table() { Id = Guid.NewGuid(), Name = "Table 8" };
            var table9 = new Table() { Id = Guid.NewGuid(), Name = "Table 9" };
            var table10 = new Table() { Id = Guid.NewGuid(), Name = "Table 10" };

            Tables.Add(table1);
            Tables.Add(table2);
            Tables.Add(table3);
            Tables.Add(table4);
            Tables.Add(table5);
            Tables.Add(table6);
            Tables.Add(table7);
            Tables.Add(table8);
            Tables.Add(table9);
            Tables.Add(table10);


        }
    }
}
