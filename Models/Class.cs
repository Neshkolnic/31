using Microsoft.EntityFrameworkCore;
using MobileStore.Models;
using WebApplication1.Models;
using System.Linq;
using MobileStore.Models;

namespace MobileStore.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}



namespace MobileStore
{
    public static class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                new Phone
                {
                    Name = "iPhone X",
                    Company = "Apple",
                    Price = 600
                },
                new Phone
                {
                    Name = "Samsung Galaxy Edge",
                    Company = "Samsung",
                    Price = 550
                },
                new Phone
                {
                    Name = "Pixel 3",
                    Company = "Google",

                    Price = 500
                }
                );
                context.SaveChanges();
            }
        }
    }
}

