using System;
using System.Collections.Generic;
using System.Text;
using EventMarketplace.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventMarketplace.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        DbSet<ShowHouse> ShowHouses { get; set; }
        DbSet<Event> Events { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // protected override void OnModelCreating(ModelBuilder builder)
        // {

        //     builder.Entity<ShowHouse>()
        //     .HasData(new List<ShowHouse>{
        //             new ShowHouse(1, "LaCasa", "Ibarapuera"),
        //             new ShowHouse(2, "Los Hermanos", "SmartEvent Center"),
        //             new ShowHouse(3, "The Rock Power", "BarHouse"),
        //             new ShowHouse(4, "Berthold", "EsquinaBar"),
        //             new ShowHouse(5, "Shopping Pop", "PopCenter"),
        //      });

        //     builder.Entity<Event>()
        //         .HasData(new List<Event>(){
        //             new Event(1, "Mamonas Assasinas", 10000, "mamonas.jpg", DateTime.Now, 200.00, ShowHouseId, "Rock"),
        //             new Event(2, "Ramones"),
        //             new Event(3, "Zeca pá Gordinho"),
        //             new Event(4, "Linkin Park Cover"),
        //             new Event(5, "Lil Nas X"),
        //         });

        // }
    }
}