using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Infomed.Core.Context.Sql;

namespace Informed.Core.Context.Sql.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20170212181154_Serie Entity")]
    partial class SerieEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Infomed.Core.Entities.Serie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Serie");
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
        }
    }
}
