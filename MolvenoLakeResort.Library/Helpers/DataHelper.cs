#region ...   [Header]   ...

// Solution      ::    MolvenoLakeResort
// Filename      ::    MolvenoLakeResort.Library.DataHelper.cs
// Created On    ::    03/04/2018 2:15 PM
// Altered On    ::    04/04/2018 8:59 AM
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MolvenoLakeResort.Library.Business_Objects;
using MolvenoLakeResort.Library.Core;

#endregion

namespace MolvenoLakeResort.Library.Helpers
{
    public static class DataHelper
    {
        private static List<Dish> dishes;
        private static List<Ingredient> ingredients;
        private static List<Reservation> reservations;
        private static readonly Random random = new Random();
        private static readonly string[] peopleNames = { "Erasmo", "Wendell", "Phillip", "Tonia", "Ocie", "Tara", "Emmaline", "Aurelia", "Arthur", "Brande", "Dreama", "Manuel", "Angelica", "Zack", "Kristy", "Marcelene", "Yun", "Cory", "Verlie", "Josphine", "Danuta", "Ina", "Reggie", "Alden", "Guillermina", "Haley", "Marti", "Mickey", "Sal", "Linsey", "Jarod", "Tamra", "Hester", "Royal", "Kenny", "Josefine", "Lucile", "Kayleigh", "Dianne", "Belle", "Ofelia", "Jannet", "Adell", "Roselle", "Kaitlin", "Gennie", "Denese", "Harlan", "Yael", "Jong" };

        public static string GetRandomPersonName()
        {
            return peopleNames[random.Next(0, peopleNames.Length)];
        }

        public static List<Ingredient> Ingredients(string path)
        {
            return ingredients ?? (ingredients = ConvertCsv(path).ToIngredients());
        }

        public static List<Reservation> Reservations => reservations ?? (reservations = new List<Reservation>
        {
            new Reservation
            {
                Name = "Fam. Johnson",
                ReservationNumber = "MOLV-HGDF",
                Start = DateTimeOffset.Now,
                NuberOfPersons = 2,
                FloorLevel = 1,
                ShowPrice = false,
                BookingNumber = "2018-0401DF",
                BookerReference = "MyRef",
                BookerType = 1
            },
            new Reservation
            {
                Name = "Fam. Peters",
                ReservationNumber = "MOLV-KITRS",
                Start = DateTimeOffset.Now,
                NuberOfPersons = 4,
                FloorLevel = 2,
                ShowPrice = true,
                BookingNumber = "2018-0401JK",
                BookerReference = "MyRef",
                BookerType = 2
            },
            new Reservation
            {
                Name = "Fam. Michaels",
                ReservationNumber = "MOLV-KILA",
                Start = DateTimeOffset.Now,
                NuberOfPersons = 6,
                FloorLevel = 1,
                ShowPrice = false,
                BookingNumber = "2018-0401LP",
                BookerReference = "MyRef",
                BookerType = 1
            },
            new Reservation
            {
                Name = "Fam. Stevenson",
                ReservationNumber = "MOLV-VHUR",
                Start = DateTimeOffset.Now,
                NuberOfPersons = 2,
                FloorLevel = 1,
                ShowPrice = true,
                BookingNumber = "2018-0401WE",
                BookerReference = "MyRef",
                BookerType = 2
            },
            new Reservation
            {
                Name = "Fam. King",
                ReservationNumber = "MOLV-HSAY",
                Start = DateTimeOffset.Now,
                NuberOfPersons = 4,
                FloorLevel = 0,
                ShowPrice = true,
                BookingNumber = "2018-0401XS",
                BookerReference = "MyRef",
                BookerType = 1
            },
            new Reservation
            {
                Name = "Fam. O'Brien",
                ReservationNumber = "MOLV-PLOI",
                Start = DateTimeOffset.Now,
                NuberOfPersons = 8,
                FloorLevel = 1,
                ShowPrice = false,
                BookingNumber = "2018-0401CF",
                BookerReference = "MyRef",
                BookerType = 1
            },
        });

        public static List<Dish> ToDishes(this List<MolvenoIngredient> molvenoIngredients)
        {
            if (dishes == null)
            {
                var ingredients = new List<Ingredient>();
                var ingredientUpper = random.Next(1, 6);

                for (var i = 0; i < ingredientUpper; i++)
                    ingredients.Add(molvenoIngredients[random.Next(0, molvenoIngredients.Count)].ToIngredient());
                //fetch data
                dishes = new List<Dish>
                {
                    new Dish
                    {
                        Ingredients = ingredients,
                        Name = "Pancakes",
                        SuggestedRetailPrice = 4.00m,
                        PriceInEuros = 5.00m,
                        MinimumNumberOfPersons = 1
                    },
                    new Dish
                    {
                        Ingredients = ingredients,
                        Name = "Pizza",
                        SuggestedRetailPrice = 2.00m,
                        PriceInEuros = 3.00m,
                        MinimumNumberOfPersons = 1
                    },
                    new Dish
                    {
                        Ingredients = ingredients,
                        Name = "Paella",
                        SuggestedRetailPrice = 3.50m,
                        PriceInEuros = 4.50m,
                        MinimumNumberOfPersons = 1
                    },
                    new Dish
                    {
                        Ingredients = ingredients,
                        Name = "Stamppot",
                        SuggestedRetailPrice = 1.00m,
                        PriceInEuros = 2.00m,
                        MinimumNumberOfPersons = 2
                    },
                    new Dish
                    {
                        Ingredients = ingredients,
                        Name = "Kebab",
                        SuggestedRetailPrice = 2.35m,
                        PriceInEuros = 3.35m,
                        MinimumNumberOfPersons = 1
                    },
                    new Dish
                    {
                        Ingredients = ingredients,
                        Name = "Kapsalon",
                        SuggestedRetailPrice = 6.00m,
                        PriceInEuros = 9.00m,
                        MinimumNumberOfPersons = 1
                    },
                    new Dish
                    {
                        Ingredients = ingredients,
                        Name = "Roti",
                        SuggestedRetailPrice = 2.50m,
                        PriceInEuros = 3.00m,
                        MinimumNumberOfPersons = 4
                    }
                };
            }

            return dishes;
        }

        public static List<Ingredient> ToIngredients(this List<MolvenoIngredient> molvenoIngredients)
        {
            return molvenoIngredients.Select(m => m.ToIngredient()).ToList();
        }
        
        private static Ingredient ToIngredient(this MolvenoIngredient molvenoIngredient)
        {
            return new Ingredient
            {
                Name = molvenoIngredient.Description,
                CostPrice = molvenoIngredient.PricePerUnit,
                AddOnCharge = 0.25m,
                Deleted = false,
                Unit = new Unit
                {
                    Price = molvenoIngredient.PricePerUnit,
                    Amount = molvenoIngredient.Stock,
                    MeasurementType = molvenoIngredient.Quantity
                }
            };
        }

        public static List<MolvenoIngredient> ConvertCsv(string path)
        {
            var molvenoIngredients = new List<MolvenoIngredient>();
            var lines = GetLines(path);
            foreach (var line in lines)
            {
                var properties = line.Split(';');
                var molvenoIngredient = new MolvenoIngredient
                {
                    Description = properties[0],
                    Brand = properties[1],
                    Deliverer = properties[2],
                    ArticleNumber = properties[3],
                    Unit = properties[4],
                    Quantity = properties[5],
                    Price = Convert.ToDecimal(properties[6])/100,
                    Vat = properties[7],
                    PricePerUnit = Convert.ToDecimal(properties[8])/100,
                    Category = properties[9],
                    Stock = Convert.ToInt32(properties[10]),
                    StockWorth = Convert.ToDecimal(properties[11])
                };

                molvenoIngredients.Add(molvenoIngredient);
            }

            return molvenoIngredients;
        }

        private static IEnumerable<string> GetLines(string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Open))
            {
                using (var reader = new StreamReader(fileStream))
                {
                    var line = reader.ReadLine();
                    while ((line = reader.ReadLine()) != null) yield return line;
                }
            }
        }
    }
}