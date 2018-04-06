using System;
using System.Collections.Generic;
using System.Linq;
using MolvenoLakeResort.Data.Items;
using MolvenoLakeResort.Library.Authentication;

namespace MolvenoLakeResort.Data.Services.Core
{
    public static class DataConverter
    {
        public static DataUser ToDataUser(this User user, bool exists)
        {
            var result = new DataUser
            {
                Password = user.Password,
                ConfirmPassword = user.ConfirmPassword,
                Email = user.Email,
                RememberMe = user.RememberMe != null && user.RememberMe.Value,
                UserLevel = user.UserLevel
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

        public static User ToUser(this DataUser user)
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

        public static List<DataUser> ToDataUsers(this List<User> users)
        {
            return users.Select(u=>u.ToDataUser(false)).ToList();
        }

        public static List<User> ToUsers(this List<DataUser> users)
        {
            return users.Select(u => u.ToUser()).ToList();

        }
    }
}
