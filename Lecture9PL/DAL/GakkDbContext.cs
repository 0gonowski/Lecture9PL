using Lecture9PL.Models;
using Microsoft.EntityFrameworkCore;

namespace Lecture9PL.DAL;

public class GakkDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected GakkDbContext()
    {
    }

    public GakkDbContext(DbContextOptions options) : base(options)
    {
    }
}