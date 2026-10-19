using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementApp.Models;

[Table("Student")]
public class Student
{
    [Key]
    public int StudentID { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Alias { get; set; } = string.Empty;

    public DateTime DoB { get; set; }

    public ICollection<StudentPower> StudentPowers { get; set; }
        = new List<StudentPower>();

    public ICollection<StudentSection> StudentSections { get; set; }
        = new List<StudentSection>();
}