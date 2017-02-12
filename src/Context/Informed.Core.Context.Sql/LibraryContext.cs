using Infomed.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Context.Sql
{
    public class LibraryContext : DbContext, IDisposable
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Permision> Permisions { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<Serie>().ToTable("Serie");
            modelBuilder.Entity<User>().ToTable("User");

            modelBuilder.Entity<UserPermision>()
                        .ToTable("UserPermision")
                        .HasKey(u => new { u.PermisionId, u.UserId });

            modelBuilder.Entity<UserPermision>()
                        .HasOne(up => up.User)
                        .WithMany(up => up.UserPermisions)
                        .HasForeignKey(up => up.UserId);

            modelBuilder.Entity<UserPermision>()
                        .HasOne(up => up.Permision)
                        .WithMany(up => up.UserPermisions)
                        .HasForeignKey(up => up.PermisionId);


            modelBuilder.Entity<Permision>().ToTable("Permision");
            //modelBuilder.Entity<CourseAssignment>()
            //    .HasKey(c => new { c.CourseID, c.InstructorID });


        }
        public override void Dispose()
        {
            this.SaveChanges(); 
            base.Dispose();
        }
    }
}
