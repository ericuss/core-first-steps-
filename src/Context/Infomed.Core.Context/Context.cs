using Infomed.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomed.Core.Context
{
    public class Context : IContext
    {
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
        public Context()
        {
            this.LoadAuthors();
            this.LoadBooks();
        }
        
        public void LoadBooks()
        {
            this.Books = new List<Book>();
            this.Books.AddRange(this.Authors.SelectMany(a => a.Books));
        }
        private void LoadAuthors()
        {
            this.Authors = new List<Author>();

            this.Authors.Add(new Author("Simon Scarrow")
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

            this.Authors.Add(new Author("Santiago Posteguillo")
            {
                Books = new List<Book>()
                {
                    new Book("Africanus: el hijo del cónsul"),
                    new Book("Las legiones malditas"),
                    new Book("La traición de Roma"),
                }
            });

            this.Authors.Add(new Author("Patrick Rothfuss")
            {
                Books = new List<Book>()
                {
                    new Book("El nombre del viento"),
                    new Book("El temor de un hombre sabio"),
                }
            });

        }
    }
}
