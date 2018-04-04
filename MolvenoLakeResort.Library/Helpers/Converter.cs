using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using MolvenoLakeResort.Library.Business_Objects;
using MolvenoLakeResort.Library.Core;

namespace MolvenoLakeResort.Library.Helpers
{
    public static class Converter
    {
        private static List<Dish> dishes;
        private static readonly Random random = new Random();

        public static List<Dish> ToDishes(this List<MolvenoIngredient> molvenoIngredients)
        {
            if (dishes == null)
            {
               
                var ingredients = new List<Ingredient>();
                var ingredientUpper = random.Next(1, 6);

                for (int i = 0; i < ingredientUpper; i++)
                {
                    ingredients.Add(molvenoIngredients[random.Next(0,molvenoIngredients.Count)].ToIngredient());
                }
                //fetch data
                dishes = new List<Dish>()
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
                    },
                };
            }

            return dishes;

        }

        public static List<Ingredient> ToIngredients(this List<MolvenoIngredient> molvenoIngredients)
        {
            return molvenoIngredients.Select(m => m.ToIngredient()).ToList();
        }

        public static string ToCurrency(this decimal value)
        {
            return $"€ {value:N2}";
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
                    Price = Convert.ToDecimal(properties[6]),
                    Vat = properties[7],
                    PricePerUnit = Convert.ToDecimal(properties[8]),
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
                    string line = reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        yield return line;
                    }
                }
            }
        }

    }
}
