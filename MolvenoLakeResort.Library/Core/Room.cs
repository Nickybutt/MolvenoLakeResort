using MolvenoLakeResort.Library.Interfaces;
using System;
using System.Collections.Generic;

namespace MolvenoLakeResort.Library.Core
{
    public class Room:IItem
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public bool Open { get; set; }
        public int FloorLevel { get; set; }
        public DateTimeOffset OpenTime { get; set; }
        public DateTimeOffset OpeClosedTime { get; set; }
        public List<Table> Tables { get; set; }
    }
}
