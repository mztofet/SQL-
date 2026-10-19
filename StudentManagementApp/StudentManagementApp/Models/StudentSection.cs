using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementApp.Models;

[PrimaryKey(nameof(SectionID), nameof(StudentID))]
[Table("StudentSection")]
public class StudentSection
{
    public int SectionID { get; set; }

    public int StudentID { get; set; }

    public byte? Grade { get; set; }

    public byte? Absences { get; set; }

    [ForeignKey(nameof(StudentID))]
    public Student Student { get; set; } = null!;

    [ForeignKey(nameof(SectionID))]
    public Section Section { get; set; } = null!;
}