using MolvenoLakeResort.Data.Items;
using MolvenoLakeResort.Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MolvenoLakeResort.Data.Services.Core
{
    public static class ReservationDataConverter
    {
        public static DataReservation ToDataReservation(this Reservation reservation, bool exists)
        {
            var result = new DataReservation
            {
                ReservationNumber = reservation.ReservationNumber,
                Start = reservation.Start,
                NuberOfPersons = reservation.NuberOfPersons,
                BookerReference = reservation.BookerReference,
                BookingNumber = reservation.BookingNumber,
                FloorLevel = reservation.FloorLevel,
                Active = reservation.Active,
                RestautantId = reservation.RestautantId,
                ShowPrice = reservation.ShowPrice,
                Deleted = reservation.Deleted
            };

            if (exists)
            {
                result.AlteredBy = Guid.Empty;
                result.Altered = DateTimeOffset.Now;
            }
            else
            {
                result.CreatedBy = Guid.Empty;
                result.Created = DateTimeOffset.Now;
            }

            return result;
        }

        public static Reservation ToReservation(this DataReservation reservation)
        {
            return new Reservation
            {
                ReservationNumber = reservation.ReservationNumber,
                Start = reservation.Start,
                NuberOfPersons = reservation.NuberOfPersons,
                BookerReference = reservation.BookerReference,
                BookingNumber = reservation.BookingNumber,
                FloorLevel = reservation.FloorLevel,
                Active = reservation.Active,
                RestautantId = reservation.RestautantId,
                ShowPrice = reservation.ShowPrice,
                Deleted = reservation.Deleted
            };
        }

        public static List<DataReservation> ToDataReservations(this List<Reservation> reservations)
        {
            return reservations.Select(r => r.ToDataReservation(false)).ToList();
        }

        public static List<Reservation> ToReservations(this List<DataReservation> reservations)
        {
            return reservations.Select(u => u.ToReservation()).ToList();

        }
    }
}


//var result = new DataUser
//{
//    Password = user.Password,
//    ConfirmPassword = user.ConfirmPassword,
//    Email = user.Email,
//    RememberMe = user.RememberMe != null && user.RememberMe.Value,
//    UserLevel = user.UserLevel
//};

//            if (exists)
//            {
//                result.AlteredBy = Guid.Empty;
//                result.Altered = DateTimeOffset.Now;
//            }
//            else
//            {
//                result.CreatedBy = Guid.Empty;
//                result.Created = DateTimeOffset.Now;
//            }

//            return result;
//        }

//        public static User ToUser(this DataUser user)
//{
//    return new User
//    {
//        Password = user.Password,
//        ConfirmPassword = user.ConfirmPassword,
//        Email = user.Email,
//        RememberMe = user.RememberMe,
//        UserLevel = user.UserLevel,
//    };
//}

//public static List<DataUser> ToDataUsers(this List<User> users)
//{
//    return users.Select(u => u.ToDataUser(false)).ToList();
//}

//public static List<User> ToUsers(this List<DataUser> users)
//{
//    return users.Select(u => u.ToUser()).ToList();

//}
