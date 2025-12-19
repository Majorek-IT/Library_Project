using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options) { }

    public DbSet<BOOK> Library { get; set; }
    public DbSet<USER> Users { get; set; }
    public DbSet<LOAN> Loans { get; set; }
}
