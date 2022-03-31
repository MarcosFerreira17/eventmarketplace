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
        public DbSet<CasaDeShow> CasaDeShows { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Ingresso> Ingressos { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

    }
}