#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Data.Services.UserService.cs
// Created On    ::    06/04/2018 9:32 AM
// Altered On    ::    06/04/2018 10:10 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Linq;
using MolvenoLakeResort.Data.Items;
using MolvenoLakeResort.Data.Services.Core;
using MolvenoLakeResort.Data.Services.Interfaces;
using MolvenoLakeResort.Library.Authentication;

#endregion

namespace MolvenoLakeResort.Data.Services
{
    public class UserService : IService<User>
    {
        public bool AddOrUpdate(User user)
        {
            using (var context = new MlrContext())
            {
                var existingUser = context.DataUsers.FirstOrDefault(u => u.Id == user.Id);
                var dataUser = user.ToDataUser(existingUser != default(DataUser));
                context.DataUsers.Add(dataUser);
                context.SaveChanges();
            }

            return true;
        }

        public bool Delete(Guid id)
        {
            using (var context = new MlrContext())
            {
                var user = context.DataUsers.FirstOrDefault(dataUser => dataUser.Id == id);
                if (user != default(DataUser)) user.Deleted = true;
            }

            return true;
        }

        

        public User GetItem(Guid id)
        {
            return GetItems().FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetItems()
        {
            using (var context = new MlrContext())
            {
                var users = context.DataUsers.Where(u => !u.Deleted).ToList();
                return users.ToUsers();
            }
        }
    }
}