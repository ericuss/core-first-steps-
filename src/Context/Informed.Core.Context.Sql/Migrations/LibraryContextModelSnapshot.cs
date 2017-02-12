using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Infomed.Core.Context.Sql;

namespace Informed.Core.Context.Sql.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infomed.Core.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Infomed.Core.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AuthorId");

                    b.Property<string>("Name");

                    b.Property<Guid?>("SerieId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("SerieId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Infomed.Core.Entities.Permision", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Permision");
                });

            modelBuilder.Entity("Infomed.Core.Entities.Serie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Serie");
                });

            modelBuilder.Entity("Infomed.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Infomed.Core.Entities.UserPermision", b =>
                {
                    b.Property<Guid>("PermisionId");

                    b.Property<Guid>("UserId");

                    b.HasKey("PermisionId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPermision");
                });

            modelBuilder.Entity("Infomed.Core.Entities.Book", b =>
                {
                    b.HasOne("Infomed.Core.Entities.Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");

                    b.HasOne("Infomed.Core.Entities.Serie", "Serie")
                        .WithMany("Books")
                        .HasForeignKey("SerieId");
                });

            modelBuilder.Entity("Infomed.Core.Entities.UserPermision", b =>
                {
                    b.HasOne("Infomed.Core.Entities.Permision", "Permision")
                        .WithMany("UserPermisions")
                        .HasForeignKey("PermisionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infomed.Core.Entities.User", "User")
                        .WithMany("UserPermisions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
