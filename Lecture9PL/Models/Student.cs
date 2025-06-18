using System.ComponentModel.DataAnnotations;

namespace Lecture9PL.Models;

public class Student
{
    [Key]
    public int IdStudent { get; set; }
    
    
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    
    public DateTime BirthDate { get; set; }
    
}