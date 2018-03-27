﻿using MolvenoLakeResort.Library.Interfaces;
using System;

namespace MolvenoLakeResort.Library.Core
{
    public class Reservation : IResortItem
    {
        public Guid Id { get; }
        public string Name { get; set; }
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