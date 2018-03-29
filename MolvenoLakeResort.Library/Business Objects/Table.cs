using MolvenoLakeResort.Library.Core.Business_Objects;

namespace MolvenoLakeResort.Library.Core
{
    public class Table : ResortItem
    {
       public Table()
        {
        }

        public int NumSeats { get; set; }
        public bool Reserved { get; set; }
        public bool Available { get; set; }
    }
}