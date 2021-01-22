using System;
using System.Collections.Generic;
using System.Text;
using Betting_System.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Betting_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bet> Bets { get; set; }
        public DbSet<Opponent> Opponents { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Bet>()
                .HasOne<Bet>(b=>b.)
                .WithMany(s => s.)
        }
    }
}
