using DiplomenProekt.Data.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiplomenProekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>(entity => entity.Property(x => x.Name).HasMaxLength(255));
            builder.Entity<IdentityRole>(entity => entity.Property(x => x.NormalizedName).HasMaxLength(255));
            builder.Entity<IdentityRole>(entity => entity.Property(x => x.Id).HasMaxLength(255));
            builder.Entity<IdentityUser>(entity => entity.Property(x => x.Id).HasMaxLength(255));
            base.OnModelCreating(builder);
        }

        public virtual DbSet<Vid_leglo> Vidove_Legla { get; set; }
        public virtual DbSet<Legla_Bungala> Legla_v_Bungala { get; set; }
        public virtual DbSet<Bungalo_tip> Tip_Bungala { get; set; }
        public virtual DbSet<Bungalo_statut> Bungala_statut { get; set; }

    }
}
