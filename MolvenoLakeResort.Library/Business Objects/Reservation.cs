using MolvenoLakeResort.Library.Core.Business_Objects;
using System;
using System.ComponentModel;

namespace MolvenoLakeResort.Library.Core
{
    public class Reservation : ResortItem
    {
       

        public Reservation()
        {
        }

      
        [DisplayName("reservation ref.")]
        public string ReservationNumber { get; set; }
        [DisplayName("start time")]
        public DateTimeOffset Start { get; set; }
        [DisplayName("no. persons")]
        public int NuberOfPersons { get; set; }
        [DisplayName("booker ref.")]
        public string BookerReference { get; set; }
        [DisplayName("booker")]
        public int BookerType { get; set; }
        [DisplayName("booker no.")]
        public string BookingNumber { get; set; }
        [DisplayName("floor")]
        public int FloorLevel { get; set; }
        [DisplayName("active")]
        public bool Active { get; set; }
        public Guid RestautantId { get; set; }
        [DisplayName("show price")]
        public bool ShowPrice { get; set; }
    }
}
