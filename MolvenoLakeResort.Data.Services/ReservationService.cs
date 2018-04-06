using MolvenoLakeResort.Data.Items;
using MolvenoLakeResort.Data.Services.Core;
using MolvenoLakeResort.Data.Services.Interfaces;
using MolvenoLakeResort.Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MolvenoLakeResort.Data.Services
{
    public class ReservationService : IService<Reservation>
    {
        public bool AddOrUpdate(Reservation reservation)
        {
            using (var context = new MlrContext())
            {
                var existingReservation = context.DataReservations.FirstOrDefault(r => r.Id == reservation.Id);
                var dataReservations = reservation.ToDataReservation(existingReservation != default(DataReservation));
                context.DataReservations.Add(dataReservations);
                context.SaveChanges();
            }
            return true;
        }

        public bool Delete(Guid id)
        {
            using (var context = new MlrContext())
            {
                var reservation = context.DataReservations.FirstOrDefault(dataReservation => dataReservation.Id == id);
                if (reservation != default(DataReservation)) reservation.Deleted = true;
            }

            return true;
        }

        public Reservation GetItem(Guid id)
        {
            return GetItems().FirstOrDefault(r => r.Id == id);
        }

        public List<Reservation> GetItems()
        {
            using (var context = new MlrContext())
            {
                var reservations = context.DataReservations.Where(r => !r.Deleted).ToList();
                return reservations.ToReservations();
            }
        }

    }
}
