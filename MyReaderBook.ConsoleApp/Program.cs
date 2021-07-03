using System;
using MyReaderBook.Data;
using MyReaderBook.Domain;
using System.Collections.Generic;
using System.Linq;




namespace MyReaderBook.ConsoleApp
{
    class Program
    {
        static MyReaderBookContext context = new MyReaderBookContext();
        static void Main(string[] args)
        {
            //Inserting an "Author"
            //InsertAuthor();

            //Inserting a range of "Author"
            //InsertAuthors();

            //Showing the first "Author" based on Id
            //FindAuthor();

            //Finding "Author" the name start with "A" or "J"
            //FindAuthors();

            DeleteAuthor();
        }
        static void InsertAuthor()
        {
            var author = new Author() { FirstName = "João", LastName = "Batista" };

            context.Authors.Add(author);
            context.SaveChanges();
        }
        static void InsertAuthors()
        {
            var authors = new List<Author>()
            {
                new Author() { FirstName = "Simão", LastName = "Pedro" },
                new Author() { FirstName = "Judas", LastName = "Iscariotes" },
                new Author() { FirstName = "Jesus", LastName = "Nazaré"},
                new Author() { FirstName = "Maria", LastName = "Madalena"}

            };

            context.Authors.AddRange(authors);
            context.SaveChanges();
        }
        static void FindAuthor()
        {
            var author = context.Authors.Find(1);
            Console.WriteLine($"Author name: {author.FirstName}");
        }
        static void FindAuthors()
        {
            var authors = context.Authors
                .Where(e => e.FirstName.StartsWith("A") || e.FirstName.StartsWith("J"))
                .ToList();

            foreach (Author author in authors)
            {
                Console.WriteLine($"Author name: {author.FirstName} {author.LastName}");
            }
        }
        static void DeleteAuthor()
        {
            foreach(Author author in context.Authors)
            {
                Console.WriteLine($"Id {author.Id} : {author.FirstName} {author.LastName}");
            }
            Console.WriteLine();

            Console.WriteLine("What is Id of author you want to delete?");
            int n = int.Parse(Console.ReadLine());

            //O Single busca apenas um valor
            var dauthor = context.Authors.Single(e => e.Id == n);
            context.Authors.Remove(dauthor);
            context.SaveChanges();
        }
    }
}
