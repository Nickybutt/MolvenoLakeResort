using MolvenoLakeResort.Library.Core.Business_Objects;
using MolvenoLakeResort.Library.Interfaces;
using System;
using System.Collections.Generic;

namespace MolvenoLakeResort.Library.Core
{
    public class Restaurant: ResortItem
    {
       public Restaurant()
        {
        }

        public bool Open { get; set; }
        public DateTimeOffset OpenTime { get; set; }
        public DateTimeOffset CloseTime { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
