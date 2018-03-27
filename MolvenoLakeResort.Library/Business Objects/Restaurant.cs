using MolvenoLakeResort.Library.Core.Business_Objects;
using System;
using System.Collections.Generic;

namespace MolvenoLakeResort.Library.Core
{
    public class Restaurant: ResortItem
    {
        public Restaurant(string name) 
            : base(name)
        {

        }

        public Restaurant(string name, bool open, DateTimeOffset openTime, DateTimeOffset closeTime, List<Room> rooms)
            : this(name)
        {
            Open = open;
            OpenTime = openTime;
            CloseTime = closeTime;
            Rooms = rooms;
        }

        public bool Open { get; set; }
        public DateTimeOffset OpenTime { get; set; }
        public DateTimeOffset CloseTime { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
