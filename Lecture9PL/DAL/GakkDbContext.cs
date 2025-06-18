using System.Text.RegularExpressions;
using Lecture9PL.Models;
using Microsoft.EntityFrameworkCore;

namespace Lecture9PL.DAL;

public class GakkDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentGroup> StudentGroups { get; set; }

    protected GakkDbContext()
    {
    }

    public GakkDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors()
            .EnableDetailedErrors();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //seed

        modelBuilder.Entity<StudentGroup>().HasData(
            new StudentGroup
            {
                IdStudentGroup = 1,
                Name = "Computer Science A",
            },
            new StudentGroup
            {
                IdStudentGroup = 2,
                Name = "Computer Science B",
            },
            new StudentGroup
            {
                IdStudentGroup = 3,
                Name = "Computer Science C",
            }
        );

        modelBuilder.Entity<Student>().HasData(

            new Student
            {
                IdStudent = 1,
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(1980, 01, 01),
                Email = "john.doe@gmail.com",
                IdStudentGroup = 1
            },

            new Student
            {
                IdStudent = 2,
                FirstName = "Jane",
                LastName = "Dose",
                BirthDate = new DateTime(1980, 01, 01),
                Email = "jane.doe@gmail.com",
                IdStudentGroup = 3
            },
            new Student
            {
                IdStudent = 3,
                FirstName = "Johne",
                LastName = "Dosse",
                BirthDate = new DateTime(1980, 01, 01),
                Email = "johne.dosse@gmail.com",
                IdStudentGroup = 3
            }
        );
    }
}