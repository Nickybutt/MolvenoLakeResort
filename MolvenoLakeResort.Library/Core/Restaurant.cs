using MolvenoLakeResort.Library.Interfaces;
using System;
using System.Collections.Generic;

namespace MolvenoLakeResort.Library.Core
{
    public class Restaurant:IItem
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public bool Open { get; set; }
        public DateTimeOffset OpenTime { get; set; }
        public DateTimeOffset CloseTime { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
