using MolvenoLakeResort.Library.Interfaces;
using System;

namespace MolvenoLakeResort.Library.Core
{
    public class Table:IItem
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public int NumSeats { get; set; }
        public bool Reserved { get; set; }
        public bool Available { get; set; }
    }
}
