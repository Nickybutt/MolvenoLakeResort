using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MolvenoLakeResort.Library.Business_Objects;
using MolvenoLakeResort.Library.Core;

namespace MolvenoLakeResort.Library.Helpers
{
    public static class Converter
    {
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
                AddOnCharge = 0.25,
                Deleted = false,
                Unit = new Unit
                {
                    Price = molvenoIngredient.PricePerUnit,
                    Amount = molvenoIngredient.Stock,
                    MeasurementType = molvenoIngredient.Quantity
                }
            };
        }

        public static List<MolvenoIngredient>  ConvertCsv(string path)
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
                    Price = Convert.ToDouble(properties[6]),
                    Vat = properties[7],
                    PricePerUnit = Convert.ToDouble(properties[8]),
                    Category = properties[9],
                    Stock = Convert.ToInt32(properties[10]),
                    StockWorth = Convert.ToDouble(properties[11])
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
