using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if(!context.ProductCategories.Any())
                {
                    var categoryData = File.ReadAllText("../Infrastructure/Data/SeedData/categories.json");
                    var categories = System.Text.Json.JsonSerializer.Deserialize<List<ProductCategory>>(categoryData);

                    foreach (var item in categories)
                    {
                       context.ProductCategories.Add(item); 
                    }
                    await context.SaveChangesAsync();
                }

                if(!context.ProductCompanies.Any())
                {
                    var companyData = File.ReadAllText("../Infrastructure/Data/SeedData/companies.json");
                    var companies = System.Text.Json.JsonSerializer.Deserialize<List<ProductCompany>>(companyData);

                    foreach (var item in companies)
                    {
                       context.ProductCompanies.Add(item); 
                    }
                    await context.SaveChangesAsync();
                }

                if(!context.Products.Any())
                {
                    var productData = File.ReadAllText("../Infrastructure/Data/SeedData/products.json");
                    var products = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(productData);

                    foreach (var item in products)
                    {
                       context.Products.Add(item); 
                    }
                    await context.SaveChangesAsync();
                }
            }
            catch(Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}