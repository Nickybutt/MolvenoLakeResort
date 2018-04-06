#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Library.Authentication.User.cs
// Created On    ::    05/04/2018 9:23 AM
// Altered On    ::    05/04/2018 9:28 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using MolvenoLakeResort.Library.Helpers;
using MolvenoLakeResort.Library.Interfaces;

#endregion

namespace MolvenoLakeResort.Library.Authentication
{
    public class User:IResortItem
    {
        public User()
        {
            Id = Guid.NewGuid();
            UserLevel = 100;
        }

        public bool IsValid
        {
            get
            {
                var valid = !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Email);
                if (valid)
                {
                    valid = Password.Equals(ConfirmPassword);
                }

                return valid;
            }
        }

        public Guid Id { get; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "The email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid e-mail address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required.")]
        [Compare("Password", ErrorMessage = "Passwords do not match. Please try again.")]
        public string ConfirmPassword { get; set; }

        public int UserLevel { get; set; }

        public bool? RememberMe { get; set; }
        public string Name { get; set; }
    }
}