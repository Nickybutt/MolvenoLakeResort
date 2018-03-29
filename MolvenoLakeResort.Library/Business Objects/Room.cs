using MolvenoLakeResort.Library.Interfaces;
using System;
using System.Collections.Generic;
using MolvenoLakeResort.Library.Core.Business_Objects;

namespace MolvenoLakeResort.Library.Core
{
    public class Room : ResortItem
    {
        public Room()
        {
        }

        public bool Open { get; set; }
        public int FloorLevel { get; set; }
        public DateTimeOffset OpenTime { get; set; }
        public DateTimeOffset OpeClosedTime { get; set; }
        public List<Table> Tables { get; set; }
    }
}
