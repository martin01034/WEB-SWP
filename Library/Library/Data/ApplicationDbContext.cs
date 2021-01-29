using System;
using System.Collections.Generic;
using System.Text;
using Library.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookData> BookDatas { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Reminder> Reminders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Borrow>()
                .HasOne<Customer>(s => s.Customer)
                .WithMany(g => g.Borrows)
                .HasForeignKey(f => f.CustomerId);

            builder.Entity<Reminder>()
                .HasOne<Borrow>(b => b.Borrow)
                .WithMany(a => a.Reminders)
                .HasForeignKey(f => f.BorrowId);

            builder.Entity<Borrow>()
                .HasOne<Book>(b => b.Book)
                .WithMany(a => a.Borrows)
                .HasForeignKey(f => f.BookId);

            base.OnModelCreating(builder);
        }

    }
}
