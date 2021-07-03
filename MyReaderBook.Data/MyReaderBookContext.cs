using Microsoft.EntityFrameworkCore;
using MyReaderBook.Domain;

namespace MyReaderBook.Data
{
    public class MyReaderBookContext : DbContext
    {
        //Esse DbSet abaixo é uma propriedade que chamamos de repositório!
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer("Server=localhost;Database=myReadBook;Trusted_Connection=True;");
        }
    }
}
