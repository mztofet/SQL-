using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementApp.Models;

[Table("Section")]
public class Section
{
    [Key]
    public int SectionID { get; set; }

    public int? CourseID { get; set; }

    public int? InstructorID { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public ICollection<StudentSection> StudentSections { get; set; }
        = new List<StudentSection>();
}