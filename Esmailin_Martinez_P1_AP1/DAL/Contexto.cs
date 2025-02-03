using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Esmailin_Martinez_P1_AP1.Models;

namespace Esmailin_Martinez_P1_AP1.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Modelo> Modelo { get; set; }
    }
}
