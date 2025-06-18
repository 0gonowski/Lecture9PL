using System.ComponentModel.DataAnnotations;

namespace Lecture9PL.Models;

public class StudentGroup
{
    [Key]
    public int IdStudentGroup { get; set; }
    
    public string Name { get; set; }
    
    public ICollection<Student> Students { get; set; }
    
}