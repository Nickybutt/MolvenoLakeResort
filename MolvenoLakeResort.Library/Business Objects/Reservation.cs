using MolvenoLakeResort.Library.Core.Business_Objects;
using System;

namespace MolvenoLakeResort.Library.Core
{
    public class Reservation : ResortItem
    {
        public Reservation(string name)
            :base(name)
        {

        }

        public Reservation(string reservationNumber, DateTimeOffset start, int nuberOfPersons, string bookerReference, int bookerType, string bookingNumber, int floorLevel, bool active, Guid restautantId, bool showPrice) 
            : this(reservationNumber)
        {
            Start = start;
            NuberOfPersons = nuberOfPersons;
            BookerReference = bookerReference;
            BookerType = bookerType;
            BookingNumber = bookingNumber;
            FloorLevel = floorLevel;
            Active = active;
            RestautantId = restautantId;
            ShowPrice = showPrice;
        }

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
    }
}
