using Microsoft.EntityFrameworkCore;

public class Vasilca_Robert_Lab2Context(DbContextOptions<Vasilca_Robert_Lab2Context> options) : DbContext(options)
{
    public DbSet<Vasilca_Robert_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Vasilca_Robert_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Vasilca_Robert_Lab2.Models.Author> Author { get; set; } = default!;
}
