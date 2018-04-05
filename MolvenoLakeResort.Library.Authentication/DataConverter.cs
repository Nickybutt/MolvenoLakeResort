using System;
using MolvenoLakeResort.Data.Items;

namespace MolvenoLakeResort.Library.Authentication
{
    public static class DataConverter
    {
        public static DataUser ToDataUser(this User user)
        {
            return new DataUser
            {
                Password = user.Password,
                ConfirmPassword = user.ConfirmPassword,
                Email = user.Email,
                RememberMe = user.RememberMe != null && user.RememberMe.Value,
                UserLevel = user.UserLevel,
                Created = DateTimeOffset.Now,
                Altered = DateTimeOffset.Now,
                AlteredBy = Guid.Empty,
                CreatedBy = Guid.Empty
            };

        }

        public static User ToDataUser(this DataUser user)
        {
            return new User
            {
                Password = user.Password,
                ConfirmPassword = user.ConfirmPassword,
                Email = user.Email,
                RememberMe = user.RememberMe,
                UserLevel = user.UserLevel,
            };
        }
    }
}
