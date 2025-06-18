using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    
    public string Email { get; set; }
    
    public int IdStudentGroup { get; set; }
    
    [ForeignKey("IdStudentGroup")]
    public StudentGroup StudentGroup { get; set; }
    
}