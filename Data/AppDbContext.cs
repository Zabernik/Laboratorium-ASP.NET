using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        private string Path { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            Path = System.IO.Path.Join(path, "contacts.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={Path}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity() 
                { 
                    Id = 1, 
                    Name = "Adam", 
                    Email = "adam@wsei.edu.pl", 
                    Phone = "127813268163", 
                    Birth = new DateTime(2000, 10, 10) 
                },
                new ContactEntity() 
                { 
                    Id = 2, 
                    Name = "Ewa", 
                    Email = "ewa@wsei.edu.pl", 
                    Phone = "293443823478", 
                    Birth = new DateTime(1999, 8, 10) 
                }
                );
            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity()
                {
                    Id = 1,
                    Name = "Mleko",
                    Price = 4,
                    Description = "Ot normalne mleko",
                    DateOdProduction = new DateTime(2023, 11, 7)
                }
                );
        }

        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
    }
}
