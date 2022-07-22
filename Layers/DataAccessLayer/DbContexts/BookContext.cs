using System; 
using Microsoft.EntityFrameworkCore; 
using Models.Entities;

#nullable disable

namespace DataAccessLayer.DbContexts
{
    public partial class BookContext : DbContext
    {
        public BookContext()
        {
        }

        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }
        //tüm tablolarınn bulunduğu alan
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookAuthorPublish> BookAuthorPublishes { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Reader> Readers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Server= EMINE-HOMEPC\\SQLEXPRESS;Database=emine;Trusted_Connection=True;"));
        }

    }
}
