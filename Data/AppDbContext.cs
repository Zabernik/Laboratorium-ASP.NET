using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<ProducerEntity> Producers { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }

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
            base.OnModelCreating(modelBuilder);

            var user = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "test",
                NormalizedUserName = "TEST",
                Email = "test@wsei.edu.pl",
                NormalizedEmail = "TEST@WSEI.EDU.PL",
                EmailConfirmed = true
            };

            var adminRole = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "admin",
                NormalizedName = "ADMIN",
            };

            var userRole = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "user",
                NormalizedName = "USER",
            };

            adminRole.ConcurrencyStamp = adminRole.Id;

            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();

            user.PasswordHash = passwordHasher.HashPassword(user, "1234Ab!");

            modelBuilder.Entity<IdentityUser>()
                .HasData(user);

            modelBuilder.Entity<IdentityRole>() 
                .HasData(adminRole);
            modelBuilder.Entity<IdentityRole>()
                .HasData(userRole);

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>()
                    {
                        RoleId = adminRole.Id,
                        UserId = user.Id,
                    }
                );
            modelBuilder.Entity<ContactEntity>()
                .HasOne(e => e.Organization)
                .WithMany(o => o.Contacts)
                .HasForeignKey(e => e.OrganizationId);

            modelBuilder.Entity<OrganizationEntity>().HasData(
                new OrganizationEntity()
                {
                    Id = 1,
                    Title = "WSEI",
                    Nip = "83492384",
                    Regon = "13424234",
                },
                new OrganizationEntity()
                {
                    Id = 2,
                    Title = "Firma",
                    Nip = "2498534",
                    Regon = "0873439249",
                }
                );

            modelBuilder.Entity<OrganizationEntity>()
                .OwnsOne(e => e.Address)
                .HasData(
                    new { OrganizationEntityId = 1, City = "Kraków", Street = "Św. Filipa 17", PostalCode = "31-150", Region = "małopolskie" },
                    new { OrganizationEntityId = 2, City = "Kraków", Street = "Krowoderska 45/6", PostalCode = "31-150", Region = "małopolskie" }
                );

            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity() 
                { 
                    Id = 1, 
                    Name = "Adam", 
                    Email = "adam@wsei.edu.pl", 
                    Phone = "127813268163", 
                    Birth = new DateTime(2000, 10, 10),
                    OrganizationId = 1,
                },
                new ContactEntity() 
                { 
                    Id = 2, 
                    Name = "Ewa", 
                    Email = "ewa@wsei.edu.pl", 
                    Phone = "293443823478", 
                    Birth = new DateTime(1999, 8, 10),
                    OrganizationId = 2,
                }
                );
            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity()
                {
                    Id = 1,
                    Name = "Mleko",
                    Price = 4,
                    Description = "Ot normalne mleko",
                    DateOfProduction = new DateTime(2023, 11, 19),
                    Category = 0,
                    ProducerName = "Nestle"
                },
                new ProductEntity()
                {
                    Id = 2,
                    Name = "Cocolino",
                    Price = 5,
                    Description = "Płyn do płukania prania",
                    DateOfProduction = new DateTime(2023, 05, 08),
                    Category = 1,
                    ProducerName = "Unilever"
                },
                new ProductEntity()
                {
                    Id = 3,
                    Name = "Mirinda",
                    Price = 4,
                    Description = "Napój gazowany o smaku pomarańczowym",
                    DateOfProduction = new DateTime(2024, 01, 05),
                    Category = 1,
                    ProducerName = "PepsiCo"
                },
                new ProductEntity()
                {
                    Id = 4,
                    Name = "Sprite",
                    Price = 6,
                    Description = "Napój gazowany",
                    DateOfProduction = new DateTime(2024, 01, 17),
                    Category = 1,
                    ProducerName = "PepsiCo"
                }
                );
            modelBuilder.Entity<ProducerEntity>().HasData(
                new ProducerEntity()
                {
                    Id = 1,
                    Name = "PepsiCo",
                    Regon = "012610700",
                    NIP = "5260210530",
                    ProducerCategory = "Food"
                },
                new ProducerEntity()
                {
                    Id = 2,
                    Name = "BAT",
                    Regon = "140471142",
                    NIP = "7962468402",
                    ProducerCategory = "Cigarettes"
                },
                new ProducerEntity()
                {
                    Id = 3,
                    Name = "Nestle",
                    Regon = "010006420",
                    NIP = "5270203968",
                    ProducerCategory = "Food"
                },
                new ProducerEntity()
                {
                    Id = 4,
                    Name = "Unilever",
                    Regon = "140566233",
                    NIP = "5213390341",
                    ProducerCategory = "Chemistry"
                });
        }
    }
}
