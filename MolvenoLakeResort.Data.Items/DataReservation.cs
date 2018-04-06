using MolvenoLakeResort.Data.Items.Core;
using MolvenoLakeResort.Data.Items.Interfaces;
using System;

namespace MolvenoLakeResort.Data.Items
{
    public class DataReservation: BaseObject, IDeletable
    {
        public string ReservationNumber { get; set; }
        public DateTimeOffset Start { get; set; }
        public int NuberOfPersons { get; set; }
        public string BookerReference { get; set; }
        public int BookerType { get; set; }
        public string BookingNumber { get; set; }
        public int FloorLevel { get; set; }
        public bool Active { get; set; }
        public Guid RestautantId { get; set; }
        public bool ShowPrice { get; set; }
        public bool Deleted { get; set; }
    }
}
