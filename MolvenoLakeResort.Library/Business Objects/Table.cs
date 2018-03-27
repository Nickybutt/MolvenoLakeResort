using MolvenoLakeResort.Library.Core.Business_Objects;

namespace MolvenoLakeResort.Library.Core
{
    public class Table : ResortItem
    {
        public Table(string name, int numSeats, bool reserved, bool available)
            : this(name)
        {
            NumSeats = numSeats;
            Reserved = reserved;
            Available = available;
        }

        protected Table()
        {
        }

        protected Table(string name) : base(name)
        {
        }

        public int NumSeats { get; set; }
        public bool Reserved { get; set; }
        public bool Available { get; set; }
    }
}