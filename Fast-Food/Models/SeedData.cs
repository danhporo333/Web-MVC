using Microsoft.EntityFrameworkCore;
using Fast_Food.Data;
namespace Fast_Food.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                       serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Food.Any())
                {
                    return;   // DB has been seeded
                }

                context.Food.AddRange(
                        new Food
                        {
                            Title = "Chicken Burger",
                            Price = 20000,
                            Category = "Burger",
                            Rating = 4.2f,
                            Image = "https://res.cloudinary.com/dpu8zudck/image/upload/v1711428192/Demo/web%20FastFood%20Image/images/product_01.3_wuoyke.jpg",
                            Quantity = 10
                        },

                        new Food
                        {
                            Title = "Vegetarian Pizza",
                            Price = 100000,
                            Category = "Pizza",
                            Rating = 4.2f,
                            Image = "https://res.cloudinary.com/dpu8zudck/image/upload/v1711428193/Demo/web%20FastFood%20Image/images/product_4.2_wrhk0s.jpg",
                            Quantity = 10
                        },

                        new Food
                        {
                            Title = "Double Cheese Margherita",
                            Price = 110000,
                            Category = "Pizza",
                            Rating = 4.6f,
                            Image = "https://res.cloudinary.com/dpu8zudck/image/upload/v1711428209/Demo/web%20FastFood%20Image/images/product_2.1_acqtsc.jpg",
                            Quantity = 10
                        },

                        new Food
                        {
                            Title = "Maxican Green Wave",
                            Price = 100000,
                            Category = "Pizza",
                            Rating = 4.2f,
                            Image = "https://res.cloudinary.com/dpu8zudck/image/upload/v1711428211/Demo/web%20FastFood%20Image/images/product_3.3_x19rji.jpg",
                            Quantity = 10
                        },
                        new Food
                        {
                            Title = "Cheese Burger",
                            Price = 20000,
                            Category = "Burger",
                            Rating = 4.2f,
                            Image = "https://res.cloudinary.com/dpu8zudck/image/upload/v1711428206/Demo/web%20FastFood%20Image/images/product_04_khaabn.jpg",
                            Quantity = 10
                        },
                        new Food
                        {
                            Title = "Royal Cheese Burger",
                            Price = 30000,
                            Category = "Burger",
                            Rating = 4.2f,
                            Image = "https://res.cloudinary.com/dpu8zudck/image/upload/v1711428221/Demo/web%20FastFood%20Image/images/product_01.1_gk8sko.jpg",
                            Quantity = 10
                        },
                        new Food
                        {
                            Title = "Seafood Pizza",
                            Price = 130000,
                            Category = "Pizza",
                            Rating = 4.2f,
                            Image = "https://mymenu.vn/assets/images/products/739/450-pizza-seafood-01.png",
                            Quantity = 10
                        },
                        new Food
                        {
                            Title = "Thin Cheese Pizza",
                            Price = 130000,
                            Category = "Pizza",
                            Rating = 4.2f,
                            Image = "https://res.cloudinary.com/dpu8zudck/image/upload/v1711428186/Demo/web%20FastFood%20Image/images/product_2.2_pwjgea.jpg",
                            Quantity = 10
                        },
                        new Food
                        {
                            Title = "Pizza With Mushroom",
                            Price = 120000,
                            Category = "Pizza",
                            Rating = 4.2f,
                            Image = "https://res.cloudinary.com/dpu8zudck/image/upload/v1711428200/Demo/web%20FastFood%20Image/images/product_2.3_oayqe3.jpg",
                            Quantity = 10
                        },
                        new Food
                        {
                            Title = "Crunchy Bread",
                            Price = 30000,
                            Category = "Bread",
                            Rating = 4.2f,
                            Image = "https://www.lifeasastrawberry.com/wp-content/uploads/2016/01/crusty-french-bread-4-copy.jpg",
                            Quantity = 10
                        },
                        new Food
                        {
                            Title = "Crunchy Bread",
                            Price = 30000,
                            Category = "Bread",
                            Rating = 4.2f,
                            Image = "https://res.cloudinary.com/dpu8zudck/image/upload/v1711428204/Demo/web%20FastFood%20Image/images/bread_2_fvalbc.png",
                            Quantity = 10
                        }

                        );
                context.SaveChanges();
            }
        }
    }
}
