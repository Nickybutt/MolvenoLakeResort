using MolvenoLakeResort.Library.Interfaces;
using System;
using System.Collections.Generic;
using MolvenoLakeResort.Library.Core.Business_Objects;

namespace MolvenoLakeResort.Library.Core
{
    public class Room : ResortItem
    {
        public Room(string name, bool open, int floorLevel, DateTimeOffset openTime, DateTimeOffset opeClosedTime, List<Table> tables)
        : this(name)
        {
            Open = open;
            FloorLevel = floorLevel;
            OpenTime = openTime;
            OpeClosedTime = opeClosedTime;
            Tables = tables;
        }

        protected Room()
        {
        }

        protected Room(string name) : base(name)
        {
        }

        public bool Open { get; set; }
        public int FloorLevel { get; set; }
        public DateTimeOffset OpenTime { get; set; }
        public DateTimeOffset OpeClosedTime { get; set; }
        public List<Table> Tables { get; set; }
    }
}
