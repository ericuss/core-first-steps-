using Infomed.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Context.Sql
{
    public static class LibraryDbInitializer
    {

        public static void Initialize(LibraryContext context)
        {
            if (!context.Authors.Any())
            {
                LoadAuthors(context);
            }
        }

        private static void LoadAuthors(LibraryContext context)
        {
            context.Authors.Add(new Author("Simon Scarrow")
            {
                Books = new List<Book>()
                {
                    new Book("El aguila del imperio"),
                    new Book("Roma Vincit!"),
                    new Book("Las garras del águila"),
                    new Book("Los Lobos del águila"),
                    new Book("El águila abandona Britania"),
                    new Book("La profecía del águila"),
                    new Book("El águila en el desierto"),
                    new Book("Centurión"),
                    new Book("El gladiador"),
                    new Book("La Legión"),
                    new Book("Pretoriano"),
                    new Book("Cuervos sangrientos"),
                    new Book("Hermanos de sangre"),
                    new Book("Britania"),
                    new Book("Invictus"),
                }
            });

            context.Authors.Add(new Author("Santiago Posteguillo")
            {
                Books = new List<Book>()
                {
                    new Book("Africanus: el hijo del cónsul"),
                    new Book("Las legiones malditas"),
                    new Book("La traición de Roma"),
                }
            });

            context.Authors.Add(new Author("Patrick Rothfuss")
            {
                Books = new List<Book>()
                {
                    new Book("El nombre del viento"),
                    new Book("El temor de un hombre sabio"),
                }
            });
            context.SaveChanges();

        }
    }
}
